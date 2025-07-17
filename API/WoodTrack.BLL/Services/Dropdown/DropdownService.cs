using WoodTrack.Common.Helpers;

namespace WoodTrack.BLL;

public class DropdownService : IDropdownService
{
    private readonly ICountriesService _countriesService;
    private readonly ICitiesService _citiesService;
    private readonly IUsersService _usersService;
    private readonly IToolCategoriesService _productCategoriesService;

    public DropdownService(
        ICitiesService citiesService,
        ICountriesService countriesService,
        IUsersService usersService,
        IToolCategoriesService productCategoriesService
        )
    {
        _countriesService = countriesService;
        _citiesService = citiesService;
        _usersService = usersService;
        this._productCategoriesService = productCategoriesService;
    }

    public async Task<IEnumerable<KeyValuePair<int, string>>> GetGendersAsync() => await Task.FromResult(GetValues<Gender>());
    public async Task<IEnumerable<KeyValuePair<int, string>>> GetOrderStatusesAsync() => await Task.FromResult(GetValues<OrderStatus>());
    public async Task<IEnumerable<KeyValuePair<int, string>>> GetReportTypesAsync() => await Task.FromResult(GetValues<ReportType>());
    public async Task<IEnumerable<KeyValuePair<int, string>>> GetCitiesAsync(int? countryId) => await _citiesService.GetDropdownItems(countryId);
    public async Task<IEnumerable<KeyValuePair<int, string>>> GetCountriesAsync() => await _countriesService.GetDropdownItems();
    public async Task<IEnumerable<KeyValuePair<int, string>>> GetEmployeesAsync() => await _usersService.GetEmployeesDropdownItems();
    public async Task<IEnumerable<KeyValuePair<int, string>>> GetClientsAsync() => await _usersService.GetClientsDropdownItems();
    public async Task<IEnumerable<KeyValuePair<int, string>>> GetProductCategoriesAsync() => await _productCategoriesService.GetDropdownItems();

    private IEnumerable<KeyValuePair<int, string>> GetValues<T>() where T : Enum
    {
        var values = Enum.GetValues(typeof(T)).Cast<T>();
        foreach (var value in values)
        {
            string displayName;
            if (typeof(T) == typeof(Gender))
            {
                displayName = EnumTranslations.GenderTranslations[(Gender)(object)value];
            }
            else
            {
                displayName = Enum.GetName(typeof(T), value)!;
            }
            yield return new KeyValuePair<int, string>(Convert.ToInt32(value), displayName);
        }
    }

}
