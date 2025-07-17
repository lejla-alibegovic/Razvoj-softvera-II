﻿namespace WoodTrack.Api;

public class AccessManager : IAccessManager
{
    private readonly IConfiguration _configuration;
    private readonly UserManager<User> _userManager;
    private readonly ICrypto _crypto;
    private readonly IEmail _email;
    private readonly IMapper _mapper;
    private readonly IUsersService _usersService;
    private readonly IRolesService _rolesService;
    private readonly IPasswordHasher<User> _passwordHasher;

    public AccessManager(IConfiguration configuration, UserManager<User> userManager, ICrypto crypto, IEmail email,
                        IMapper mapper, IUsersService usersService, IRolesService rolesService, IPasswordHasher<User> passwordHasher)
    {
        _configuration = configuration;
        _userManager = userManager;
        _crypto = crypto;
        _email = email;
        _mapper = mapper;
        _usersService = usersService;
        _passwordHasher = passwordHasher;
        _rolesService = rolesService;
    }

    public async Task<LoginInformationModel> SignInAsync(string username, string password, bool rememberMe = false)
    {
        var user = await _usersService.FindByUserNameOrEmailAsync(username);
        if (user == null)
        {
            throw new Exception("UserNotFound");
        }

        if (!user.EmailConfirmed)
        {
            throw new Exception("EmailIsNotConfirmed");
        }

        if (!await _userManager.CheckPasswordAsync(new User() { PasswordHash = user.PasswordHash }, password))
        {
            throw new Exception("WrongCredentials");
        }
        var loginInformation = _mapper.Map<LoginInformationModel>(user);
        loginInformation.Token = GenerateToken(user);
        loginInformation.IsClient = user.UserRoles.Any(x => x.RoleId == (int)RoleLevel.Client);
        return loginInformation;
    }

    public async Task<bool> ChangePassword(int userId, string currentPassword, string newPassword)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new Exception("UserNotFound");
        }
        var checkPasswordResult = await _userManager.CheckPasswordAsync(user, currentPassword);
        if (!checkPasswordResult)
        {
            throw new Exception("CurrentPasswordIsNotValid");
        }
        var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
        return result.Succeeded;
    }

    private string GenerateToken(UserLoginDataModel user)
    {
        try
        {
            var claims = CreateClaims(user);

            var tokenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection(ConfigurationValues.TokenKey).Value!));
            var signInCreds = new SigningCredentials(tokenKey, SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddMinutes(int.Parse(_configuration.GetSection(ConfigurationValues.TokenValidityInMinutes).Value!)), signingCredentials: signInCreds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        catch
        {

            throw;
        }
    }

    private IEnumerable<Claim> CreateClaims(UserLoginDataModel user)
    {
        var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

        identity.AddClaim(new Claim(CustomClaimTypes.Id, user.Id.ToString()));
        if (user.FirstName != null)
        {
            identity.AddClaim(new Claim(ClaimTypes.Name, user.FirstName));
        }
        if (user.LastName != null)
        {
            identity.AddClaim(new Claim(ClaimTypes.Surname, user.LastName));
        }
        if (user.Email != null)
        {
            identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
        }
        if (user.UserName != null)
        {
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.UserName));
        }
        if (user.ProfilePhoto != null)
        {
            identity.AddClaim(new Claim(CustomClaimTypes.ProfilePhoto, user.ProfilePhoto));
        }
        if (user.ProfilePhotoThumbnail != null)
        {
            identity.AddClaim(new Claim(CustomClaimTypes.ProfilePhotoThumbnail, user.ProfilePhotoThumbnail));
        }

        foreach (var item in user.UserRoles)
            identity.AddClaim(new Claim(ClaimTypes.Role, item.Role.RoleLevel.ToString()));

        return identity.Claims;
    }
}

