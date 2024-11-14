using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalapi.Migrations
{
    /// <inheritdoc />
    public partial class Intital_create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountriesId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    EmployeeTypesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.EmployeeTypesId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCapacity",
                columns: table => new
                {
                    VehicleCapacityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCapacity", x => x.VehicleCapacityId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleFuel",
                columns: table => new
                {
                    VehicleFuelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFuel", x => x.VehicleFuelId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleMakes",
                columns: table => new
                {
                    VehicleMakesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMakes", x => x.VehicleMakesId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    VehicleTypesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.VehicleTypesId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StatesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountriesId = table.Column<int>(type: "int", nullable: false),
                    StatesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountriesId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StatesId);
                    table.ForeignKey(
                        name: "FK_States_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "CountriesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_States_Countries_CountriesId1",
                        column: x => x.CountriesId1,
                        principalTable: "Countries",
                        principalColumn: "CountriesId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    VehicleModelsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleMakesId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.VehicleModelsId);
                    table.ForeignKey(
                        name: "FK_VehicleModels_VehicleMakes_VehicleMakesId",
                        column: x => x.VehicleMakesId,
                        principalTable: "VehicleMakes",
                        principalColumn: "VehicleMakesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CitiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatesId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CitiesId);
                    table.ForeignKey(
                        name: "FK_Cities_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "StatesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitiesId = table.Column<int>(type: "int", nullable: true),
                    StatesId = table.Column<int>(type: "int", nullable: true),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountriesId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomersId);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "CitiesId");
                    table.ForeignKey(
                        name: "FK_Customers_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "CountriesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "StatesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriversId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitiesId = table.Column<int>(type: "int", nullable: true),
                    StatesId = table.Column<int>(type: "int", nullable: true),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountriesId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriversId);
                    table.ForeignKey(
                        name: "FK_Drivers_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "CitiesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drivers_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "CountriesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drivers_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "StatesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    EmployeeTypesId = table.Column<int>(type: "int", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CitiesId = table.Column<int>(type: "int", nullable: true),
                    StatesId = table.Column<int>(type: "int", nullable: true),
                    Pincode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CountriesId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    BankAccount = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PAN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Vehicles = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VehicleMakes = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VehicleModels = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Employees = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Customers = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Owners = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Drivers = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Rentals = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DeleteStatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "CitiesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "CountriesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeTypes_EmployeeTypesId",
                        column: x => x.EmployeeTypesId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "EmployeeTypesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "StatesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CitiesId = table.Column<int>(type: "int", nullable: true),
                    StatesId = table.Column<int>(type: "int", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CountriesId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    BankAccount = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PAN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DeleteStatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnersId);
                    table.ForeignKey(
                        name: "FK_Owners_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "CitiesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Owners_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "CountriesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Owners_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "StatesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnersId = table.Column<int>(type: "int", nullable: false),
                    VehicleModelsId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Fuel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RegistrationState = table.Column<int>(type: "int", nullable: true),
                    ChaisisNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DailyRate = table.Column<int>(type: "int", nullable: false),
                    HourlyRate = table.Column<int>(type: "int", nullable: true),
                    AdditionalDailyRate = table.Column<int>(type: "int", nullable: true),
                    AdditionalHourlyRate = table.Column<int>(type: "int", nullable: true),
                    DeleteStatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CitiesId = table.Column<int>(type: "int", nullable: true),
                    CountriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehiclesId);
                    table.ForeignKey(
                        name: "FK_Vehicles_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "CitiesId");
                    table.ForeignKey(
                        name: "FK_Vehicles_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "CountriesId");
                    table.ForeignKey(
                        name: "FK_Vehicles_Owners_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Owners",
                        principalColumn: "OwnersId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_States_RegistrationState",
                        column: x => x.RegistrationState,
                        principalTable: "States",
                        principalColumn: "StatesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleModels_VehicleModelsId",
                        column: x => x.VehicleModelsId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    RentalsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false),
                    DriversId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleRate = table.Column<int>(type: "int", nullable: false),
                    NoOfDays = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfKMS = table.Column<int>(type: "int", nullable: true),
                    StartKMS = table.Column<int>(type: "int", nullable: true),
                    EndKMS = table.Column<int>(type: "int", nullable: true),
                    SourceLocation = table.Column<int>(type: "int", nullable: false),
                    DestinationLocation = table.Column<int>(type: "int", nullable: false),
                    TravelPurpose = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TransactionNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StatesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.RentalsId);
                    table.ForeignKey(
                        name: "FK_Rentals_Cities_DestinationLocation",
                        column: x => x.DestinationLocation,
                        principalTable: "Cities",
                        principalColumn: "CitiesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Cities_SourceLocation",
                        column: x => x.SourceLocation,
                        principalTable: "Cities",
                        principalColumn: "CitiesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "CustomersId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Drivers_DriversId",
                        column: x => x.DriversId,
                        principalTable: "Drivers",
                        principalColumn: "DriversId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "StatesId");
                    table.ForeignKey(
                        name: "FK_Rentals_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "VehiclesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StatesId",
                table: "Cities",
                column: "StatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CitiesId",
                table: "Customers",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountriesId",
                table: "Customers",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StatesId",
                table: "Customers",
                column: "StatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_CitiesId",
                table: "Drivers",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_CountriesId",
                table: "Drivers",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_StatesId",
                table: "Drivers",
                column: "StatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CitiesId",
                table: "Employees",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountriesId",
                table: "Employees",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmailAddress",
                table: "Employees",
                column: "EmailAddress",
                unique: true,
                filter: "[EmailAddress] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTypesId",
                table: "Employees",
                column: "EmployeeTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StatesId",
                table: "Employees",
                column: "StatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Username",
                table: "Employees",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_CitiesId",
                table: "Owners",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_CountriesId",
                table: "Owners",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_StatesId",
                table: "Owners",
                column: "StatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CustomersId",
                table: "Rentals",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_DestinationLocation",
                table: "Rentals",
                column: "DestinationLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_DriversId",
                table: "Rentals",
                column: "DriversId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_EmployeeId",
                table: "Rentals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_SourceLocation",
                table: "Rentals",
                column: "SourceLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_StatesId",
                table: "Rentals",
                column: "StatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_VehiclesId",
                table: "Rentals",
                column: "VehiclesId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountriesId",
                table: "States",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountriesId1",
                table: "States",
                column: "CountriesId1");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_VehicleMakesId",
                table: "VehicleModels",
                column: "VehicleMakesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CitiesId",
                table: "Vehicles",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CountriesId",
                table: "Vehicles",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_OwnersId",
                table: "Vehicles",
                column: "OwnersId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_RegistrationState",
                table: "Vehicles",
                column: "RegistrationState");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleModelsId",
                table: "Vehicles",
                column: "VehicleModelsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "VehicleCapacity");

            migrationBuilder.DropTable(
                name: "VehicleFuel");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "VehicleMakes");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
