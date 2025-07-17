using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WoodTrack.BLL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    RoleLevel = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abrv = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "interval", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsFirstLogin = table.Column<bool>(type: "boolean", nullable: false),
                    VerificationSent = table.Column<bool>(type: "boolean", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "text", nullable: true),
                    ProfilePhotoThumbnail = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    LicenseNumber = table.Column<string>(type: "text", nullable: true),
                    YearsOfExperience = table.Column<int>(type: "integer", nullable: true),
                    WorkingHours = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abrv = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    IsEnable = table.Column<bool>(type: "boolean", nullable: false),
                    Manufacturer = table.Column<string>(type: "text", nullable: true),
                    Barcode = table.Column<string>(type: "text", nullable: true),
                    Ingredients = table.Column<string>(type: "text", nullable: true),
                    ProductCategoryId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActivityId = table.Column<int>(type: "integer", nullable: false),
                    TableName = table.Column<string>(type: "text", nullable: true),
                    RowId = table.Column<int>(type: "integer", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    IPAddress = table.Column<string>(type: "text", nullable: false),
                    HostName = table.Column<string>(type: "text", nullable: false),
                    WebBrowser = table.Column<string>(type: "text", nullable: false),
                    ActiveUrl = table.Column<string>(type: "text", nullable: false),
                    ReferrerUrl = table.Column<string>(type: "text", nullable: false),
                    Controller = table.Column<string>(type: "text", nullable: false),
                    ActionMethod = table.Column<string>(type: "text", nullable: false),
                    ExceptionType = table.Column<string>(type: "text", nullable: true),
                    ExceptionMessage = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    Read = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    TransactionId = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true),
                    DeliveryMethod = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PublisherId = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Data = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsPaid = table.Column<bool>(type: "boolean", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateTo = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Discount = table.Column<decimal>(type: "numeric", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    TransactionId = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateUpdated", "IsDeleted", "Name", "NormalizedName", "RoleLevel" },
                values: new object[,]
                {
                    { 1, "56103a24-16e1-4609-85a3-cc6f465516c4", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Administrator", "ADMINISTRATOR", 1 },
                    { 2, "6770931e-5b70-4611-970d-4c52f3c2ae87", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Employee", "EMPLOYEE", 2 },
                    { 3, "675d434e-5d92-40b4-b063-1ee43ce666aa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Client", "CLIENT", 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "CountryId", "DateCreated", "DateUpdated", "Description", "Email", "EmailConfirmed", "FirstName", "Gender", "IsActive", "IsDeleted", "IsFirstLogin", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "ProfilePhoto", "ProfilePhotoThumbnail", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationSent", "WorkingHours", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, 0, "Mostar b.b", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "b1bb1b25-894e-4e25-bd6e-01eefb1aff9d", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, null, "site.admin@crystal_skin.com", true, "Site", 1, true, false, false, "Admin", null, false, null, "SITE.ADMIN@CRYSTAL_SKIN.COM", "SITE.ADMIN", "AQAAAAEAACcQAAAAEAGwZeqqUuR5X1kcmNbxwyTWxg2VDSnKdFTIFBQrQe5J/UTwcPlFFe6VkMa+yAmKgQ==", "38762123456", false, null, null, null, null, false, "site.admin", false, null, null },
                    { 2, 0, "Mostar b.b", new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "f1e11ec2-1d38-4d0b-aa38-ac662ae1cf03", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, null, "employee@mail.com", true, "Employee", 1, true, false, false, "1", null, false, null, "EMPLOYEE@MAIL.COM", "EMPLOYEE", "AQAAAAEAACcQAAAAEAGwZeqqUuR5X1kcmNbxwyTWxg2VDSnKdFTIFBQrQe5J/UTwcPlFFe6VkMa+yAmKgQ==", "38762123456", false, null, null, null, null, false, "employee", false, null, null },
                    { 3, 0, "Mostar b.b", new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "3e9727dd-184d-4152-84d8-8833a6aa383f", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, null, "client1@mail.com", true, "Client", 1, true, false, false, "1", null, false, null, "CLIENT1@MAIL.COM", "CLIENT1", "AQAAAAEAACcQAAAAEAGwZeqqUuR5X1kcmNbxwyTWxg2VDSnKdFTIFBQrQe5J/UTwcPlFFe6VkMa+yAmKgQ==", "38762123456", false, null, null, null, null, false, "client1", false, null, null },
                    { 4, 0, "Mostar b.b", new DateTime(1979, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ffdc56fa-aa46-4b08-9828-f66c711d15ac", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, null, "client2@mail.com", true, "Client", 2, true, false, false, "2", null, false, null, "CLIENT2@MAIL.COM", "CLIENT2", "AQAAAAEAACcQAAAAEAGwZeqqUuR5X1kcmNbxwyTWxg2VDSnKdFTIFBQrQe5J/UTwcPlFFe6VkMa+yAmKgQ==", "38762123456", false, null, null, null, null, false, "client2", false, null, null },
                    { 5, 0, "Mostar b.b", new DateTime(1989, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "a6b03ffa-142d-4a8b-8c67-9752bda08128", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, null, "client3@mail.com", true, "Client", 1, true, false, false, "3", null, false, null, "Client3@MAIL.COM", "CLIENT3", "AQAAAAEAACcQAAAAEAGwZeqqUuR5X1kcmNbxwyTWxg2VDSnKdFTIFBQrQe5J/UTwcPlFFe6VkMa+yAmKgQ==", "38762123456", false, null, null, null, null, false, "client3", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Abrv", "DateCreated", "DateUpdated", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "BiH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, "Bosna i Hercegovina" },
                    { 2, "HR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, "Hrvatska" },
                    { 3, "SRB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, "Srbija" },
                    { 4, "CG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, "Crna Gora" },
                    { 5, "MKD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, "Makedonija" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Njega lica" },
                    { 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Njega tijela" },
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Dodaci prehrani" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Duration", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, new TimeSpan(0, 0, 10, 0, 0), false, "Konsultacija kože" },
                    { 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, new TimeSpan(0, 0, 20, 0, 0), false, "Tretman akni" },
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, new TimeSpan(0, 0, 30, 0, 0), false, "Uklanjanje mladeža" },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, new TimeSpan(0, 0, 35, 0, 0), false, "Laser terapija" },
                    { 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, new TimeSpan(0, 0, 40, 0, 0), false, "Hemijski piling" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 1, 1 },
                    { 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 2, 2 },
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 3, 3 },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 3, 4 },
                    { 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, false, 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Abrv", "CountryId", "DateCreated", "DateUpdated", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "MO", 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, true, false, "Mostar" },
                    { 2, "SA", 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, true, false, "Sarajevo" },
                    { 3, "JC", 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, true, false, "Jajce" },
                    { 4, "TZ", 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, true, false, "Tuzla" },
                    { 5, "ZG", 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, true, false, "Zagreb" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Message", "Read", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Dobrodošli u dermatološki centar! Vaš profil je aktiviran.", false, 3 },
                    { 2, new DateTime(2025, 5, 22, 14, 30, 0, 0, DateTimeKind.Unspecified), null, false, "Termin pregleda potvrđen za 03.06.2025. u 11:00.", true, 3 },
                    { 3, new DateTime(2025, 5, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), null, false, "Vaši rezultati testiranja kože su spremni za preuzimanje.", false, 3 },
                    { 4, new DateTime(2025, 5, 21, 8, 45, 0, 0, DateTimeKind.Unspecified), null, false, "Podsjetnik: tretman odstranjivanja madeža 05.06.2025. u 12:00.", false, 4 },
                    { 5, new DateTime(2025, 5, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), null, false, "Upute za pripremu kože prije tretmana su poslane na vašu e-poštu.", true, 4 },
                    { 6, new DateTime(2025, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Novi savjet za njegu kože dostupan je na vašem profilu.", false, 4 },
                    { 7, new DateTime(2025, 5, 19, 13, 20, 0, 0, DateTimeKind.Unspecified), null, false, "Vaš zahtjev za promjenu termina je odobren.", true, 5 },
                    { 8, new DateTime(2025, 5, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Podsjetnik: savjetovanje s dermatologom sutra u 10:00.", false, 5 },
                    { 9, new DateTime(2025, 5, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Ponuda: 10% popusta na paket tretmana lica.", false, 5 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "ClientId", "Date", "DateCreated", "DateUpdated", "DeliveryMethod", "FullName", "IsDeleted", "Note", "PaymentMethod", "PhoneNumber", "Status", "TotalAmount", "TransactionId" },
                values: new object[,]
                {
                    { 1, "Adresa 3", 3, new DateTime(2025, 5, 11, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4633), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 3", false, "Napomena za narudžbu 1", "kartica", "061-100030", 2, 276m, "i_0001" },
                    { 2, "Adresa 3", 3, new DateTime(2025, 4, 13, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4747), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 3", false, "Napomena za narudžbu 2", "kartica", "061-100031", 2, 175m, "i_0002" },
                    { 3, "Adresa 3", 3, new DateTime(2025, 3, 28, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 3", false, "Napomena za narudžbu 3", "kartica", "061-100032", 2, 177m, "i_0003" },
                    { 4, "Adresa 4", 4, new DateTime(2025, 3, 27, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4825), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 4", false, "Napomena za narudžbu 4", "kartica", "061-100040", 2, 205m, "i_0004" },
                    { 5, "Adresa 4", 4, new DateTime(2025, 4, 15, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4840), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 4", false, "Napomena za narudžbu 5", "kartica", "061-100041", 2, 132m, "i_0005" },
                    { 6, "Adresa 4", 4, new DateTime(2025, 3, 22, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 4", false, "Napomena za narudžbu 6", "kartica", "061-100042", 2, 228m, "i_0006" },
                    { 7, "Adresa 5", 5, new DateTime(2025, 6, 3, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4873), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 5", false, "Napomena za narudžbu 7", "kartica", "061-100050", 2, 148m, "i_0007" },
                    { 8, "Adresa 5", 5, new DateTime(2025, 6, 4, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4889), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 5", false, "Napomena za narudžbu 8", "kartica", "061-100051", 2, 169m, "i_0008" },
                    { 9, "Adresa 5", 5, new DateTime(2025, 6, 4, 22, 26, 13, 708, DateTimeKind.Utc).AddTicks(4927), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dostavaa", "Klijent 5", false, "Napomena za narudžbu 9", "kartica", "061-100052", 2, 99m, "i_0009" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "DateCreated", "DateUpdated", "Description", "ImageUrl", "Ingredients", "IsDeleted", "IsEnable", "Manufacturer", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[,]
                {
                    { 1, "1234567890123", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Krema za dubinsku hidrataciju suhe kože.", "https://logotyp.us/file/dm.svg", "Aqua, Glycerin, Aloe Vera", false, true, "Dermaline", "Hidratantna krema", 19.99m, 1, 100 },
                    { 2, "1112223330000", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Specijalizovana krema za tretman akni i mitesera.", "https://logotyp.us/file/dm.svg", "Salicylic Acid, Tea Tree Oil", false, true, "AcneFix", "Krema za akne", 22.50m, 1, 80 },
                    { 3, "4567891234567", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Regenerišuća noćna krema protiv bora.", "https://logotyp.us/file/dm.svg", "Retinol, Hyaluronic Acid", false, true, "YouthSkin", "Noćna anti-age krema", 29.90m, 1, 60 },
                    { 4, "8887776665554", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Micelarna voda za uklanjanje šminke i nečistoća.", "https://logotyp.us/file/dm.svg", "Aqua, Micelles, Chamomile Extract", false, true, "CleanFace", "Micelarna voda", 11.99m, 1, 120 },
                    { 5, "9090901234567", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Prirodna maska sa zelenom glinom za čišćenje pora.", "https://logotyp.us/file/dm.svg", "Green Clay, Aloe Vera", false, true, "NatureBeauty", "Maska za lice - glina", 13.75m, 1, 95 },
                    { 6, "9876543210987", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Osvježavajući gel za tuširanje sa citrusima.", "https://logotyp.us/file/dm.svg", "Aqua, Sodium Laureth Sulfate, Citrus Extract", false, true, "BodyFresh", "Gel za tuširanje", 9.49m, 2, 200 },
                    { 7, "3332221114448", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Hidratantni losion za svakodnevnu njegu kože tijela.", "https://logotyp.us/file/dm.svg", "Shea Butter, Vitamin E", false, true, "SoftSkin", "Losion za tijelo", 12.30m, 2, 150 },
                    { 8, "5656565656565", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Bogata krema za njegu i zaštitu ruku.", "https://logotyp.us/file/dm.svg", "Glycerin, Panthenol", false, true, "CareHands", "Krema za ruke", 5.99m, 2, 300 },
                    { 9, "7778889991112", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Prirodno ulje za relaksirajuću masažu.", "https://logotyp.us/file/dm.svg", "Lavender Oil, Almond Oil", false, true, "RelaxTime", "Ulje za masažu", 18.00m, 2, 70 },
                    { 10, "2223334445556", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Piling sa morskom soli za glatku kožu.", "https://logotyp.us/file/dm.svg", "Sea Salt, Coconut Oil", false, true, "SeaBeauty", "Piling za tijelo", 15.90m, 2, 85 },
                    { 11, "1112223334445", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Kompleks vitamina i minerala za svakodnevnu upotrebu.", "https://logotyp.us/file/dm.svg", "Vitamin A, C, D, E, Zinc, Iron", false, true, "NutriLife", "Multivitamin kapsule", 14.99m, 3, 150 },
                    { 12, "0001112223334", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Kapsule ribljeg ulja bogate omega-3 masnim kiselinama.", "https://logotyp.us/file/dm.svg", "Fish Oil, EPA, DHA", false, true, "HeartWell", "Omega 3 kapsule", 17.49m, 3, 130 },
                    { 13, "4445556667778", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Tablete vitamina C za jačanje imuniteta.", "https://logotyp.us/file/dm.svgg", "Vitamin C, Citrus Bioflavonoids", false, true, "C-Boost", "Vitamin C tablete", 6.99m, 3, 180 },
                    { 14, "5556667778889", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Probiotici za zdravlje crijeva.", "https://logotyp.us/file/dm.svg", "Lactobacillus, Bifidobacterium", false, true, "GutHealth", "Probiotik kapsule", 16.75m, 3, 110 },
                    { 15, "6667778889990", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Tablete za podršku nervnom sistemu i mišićima.", "https://logotyp.us/file/dm.svg", "Magnesium Citrate", false, true, "VitalPower", "Magnezijum tablete", 8.20m, 3, 140 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Notes", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 1, 13, 2, 43m },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 1, 3, 2, 44m },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 1, 10, 2, 51m },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 2, 1, 2, 39m },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 2, 11, 1, 41m },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 2, 8, 1, 39m },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 2, 7, 1, 17m },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 3, 13, 1, 45m },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 3, 4, 1, 46m },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 3, 11, 2, 43m },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 4, 10, 1, 59m },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 4, 14, 2, 58m },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 4, 3, 2, 15m },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 5, 2, 2, 24m },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 5, 8, 2, 42m },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 6, 13, 2, 49m },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 6, 12, 1, 32m },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 6, 3, 2, 49m },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 7, 12, 2, 50m },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 7, 13, 2, 24m },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 8, 15, 2, 58m },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 8, 10, 1, 53m },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 9, 11, 1, 17m },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 9, 4, 1, 51m },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 9, 1, 1, 31m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserId",
                table: "Logs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PatientId",
                table: "Payments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_PublisherId",
                table: "Reports",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ClientId",
                table: "Reviews",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_EmployeeId",
                table: "Reviews",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
