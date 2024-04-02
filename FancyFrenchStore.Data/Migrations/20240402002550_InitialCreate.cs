using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FancyFrenchStore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryAddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandID = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProdPkgLength = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProdPkgWidth = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProdPkgHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProdPkgWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discontinued = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "CreatedDate", "Description", "LogoURL", "Name", "UpdatedDate", "Website" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 1, 20, 25, 49, 621, DateTimeKind.Local).AddTicks(3727), "Great Taste is a family tradition.", "https://www.furmanos.com/sites/all/themes/bootstrap/furmanos/logo.png", "Furmano's", new DateTime(2024, 4, 1, 20, 25, 49, 621, DateTimeKind.Local).AddTicks(3746), "https://www.furmanos.com/" },
                    { 2, new DateTime(2024, 4, 1, 20, 25, 49, 621, DateTimeKind.Local).AddTicks(3840), "Infinite possibilities.  One Family.", "https://www.richsusa.com/wp-content/uploads/2020/02/logo.png", "Rich's", new DateTime(2024, 4, 1, 20, 25, 49, 621, DateTimeKind.Local).AddTicks(3842), "https://www.richsusa.com/business-solutions/foodservice/" },
                    { 3, new DateTime(2024, 4, 1, 20, 25, 49, 621, DateTimeKind.Local).AddTicks(3865), "Together We Make Food Extraordinary", "https://www.venturafoods.ca/wp-content/uploads/sites/2/2023/04/ventura_foods_CANADA_logo_white-2.png", "Ventura Foods Products", new DateTime(2024, 4, 1, 20, 25, 49, 621, DateTimeKind.Local).AddTicks(3867), "https://www.venturafoods.ca/" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandID", "CreatedDate", "Description", "Discontinued", "Model", "Name", "Price", "ProdPkgHeight", "ProdPkgLength", "ProdPkgWeight", "ProdPkgWidth", "SKU", "UPC", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("04772cb6-5c29-4f45-a6fd-3c835bb96207"), 1, new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8322), "Furmano's #10 Can Home Style Spaghetti Sauce - 6/Case", false, "F10377", "#10 Can Home Style Spaghetti Sauce - 6/Case", 27.99m, 8m, 19m, 45m, 13m, "99910378", "41188109338", new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8324) },
                    { new Guid("108b250a-4eb7-4447-8c10-47e47efa138d"), 1, new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8199), "Furmano's #10 Can Tomato Sauce - 6/Case", false, "F12265", "#10 Can Tomato Sauce - 6/Case", 29.99m, 8m, 19m, 45m, 13m, "10610464", "411880416384", new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8201) },
                    { new Guid("26d04719-aca9-4a7f-b69b-ec47534d6972"), 2, new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8445), "Rich's 7 inch Fresh N Ready Freezer-to-Oven Sheeted Pizza Crust Dough - 72/Case", false, "876RICH07386", "7 inch Sheeted Pizza Crust Dough - 72/Case", 86.99m, 13m, 22m, 16m, 15m, "876RICH07386", "49800073869", new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8446) },
                    { new Guid("42ca0d01-facf-476e-b418-fd3e6b5bf125"), 3, new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8483), "Grandioso by Ventura Foods 1.5 oz. Garlic Sauce Dipping Cup - 96/Case", false, "125VF480GND", "1.5 oz. Garlic Sauce Dipping Cup - 96/Case", 49.99m, 6m, 12m, 8m, 8m, "125VF480GND", "10026700160544", new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8484) },
                    { new Guid("4c177d0c-a8d7-433c-bd6a-487a029a80da"), 2, new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8363), "Rich's 12 inch Fresh N Ready Freezer-to-Oven Sheeted Pizza Crust Dough - 24/Case", false, "876RICH07366", "12 inch Sheeted Pizza Crust Dough - 24/Case", 67.99m, 13m, 25m, 14m, 13m, "876RICH07366", "49800073661", new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8365) },
                    { new Guid("9b80187b-ae56-415e-8d86-a4fcb4de2c09"), 1, new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8270), "Furmano's #10 Can Home Style Spaghetti Sauce", false, "F10377", "#10 Can Home Style Spaghetti Sauce", 5.19m, 8m, 6m, 8m, 6m, "99910377", "41188109338", new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("e7087157-4ecb-4898-850b-b8e3a2757980"), 1, new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(7932), "Furmano's #10 Can Tomato Sauce", false, "F12265", "#10 Can Tomato Sauce", 5.49m, 8m, 6m, 8m, 6m, "10610463", "411880416384", new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(7974) },
                    { new Guid("ec523528-3b8d-4d95-be94-cc2f77ed04c9"), 2, new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8406), "Rich's 16 inch Fresh N Ready Freezer-to-Oven Sheeted Pizza Crust Dough - 20/Case", false, "876RICH03604", "16 inch Sheeted Pizza Crust Dough - 20/Case", 94.49m, 11m, 33m, 20m, 17m, "876RICH03604", "400013729873", new DateTime(2024, 4, 1, 20, 25, 49, 620, DateTimeKind.Local).AddTicks(8408) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
