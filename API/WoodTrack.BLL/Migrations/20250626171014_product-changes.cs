using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WoodTrack.BLL.Migrations
{
    /// <inheritdoc />
    public partial class productchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "Products",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Length",
                table: "Products",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Width",
                table: "Products",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "246cbdbf-f8c2-4b99-b8df-7a41f2f40b53");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8db108c8-00f0-434f-b858-10ffab888f4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6265cfc0-8c3c-4828-bc61-e44d6372b280");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2b08266c-8a5a-4501-88bc-9c5dea1bc5db");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c87cf5fc-ca45-4453-bc2a-0c060016a6f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "84451964-8ed4-405c-b973-1df688ade7ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "57de1ece-fe09-45cc-a723-39bed5ff96f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4139a0e8-1460-401f-bcaa-313f4a298b67");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Dekorativni predmeti");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Kuhinjski pribor");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Namještaj");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "Width" },
                values: new object[] { "Ručno izrađena kutija od oraha s rezbarijama.", 10m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 20m, "WoodArt", "Drvena kutija za nakit", 49.99m, 15m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "ProductCategoryId", "Width" },
                values: new object[] { "1234567890124", "Set od 3 kašike od bukovog drveta, ručno izrađene.", 2m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 30m, "HandyCraft", "Set drvenih kašika", 24.50m, 2, 6m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "ProductCategoryId", "Width" },
                values: new object[] { "1234567890125", "Ručno izrađena stolica od hrastovine sa dekorativnim detaljima.", 90m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 45m, "CarveMasters", "Stolica od hrasta", 120.00m, 3, 45m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "Width" },
                values: new object[] { "1234567890126", "Elegantni zidni sat od bukve.", 5m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 35m, "WoodClock", "Drveni sat", 55.00m, 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "ProductCategoryId", "Width" },
                values: new object[] { "1234567890127", "Ručni rad od trešnjinog drveta.", 3m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 40m, "TrayMasters", "Drveni poslužavnik", 35.99m, 2, 30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "ProductCategoryId", "Width" },
                values: new object[] { "1234567890128", "Dekorativna zidna vješalica.", 10m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 50m, "HookWood", "Drvena vješalica", 22.50m, 1, 5m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "Width" },
                values: new object[] { "1234567890129", "Kvalitetna daska od bambusa.", 2m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 45m, "KitchenPro", "Daska za rezanje", 18.00m, 30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "ProductCategoryId", "Width" },
                values: new object[] { "1234567890130", "Masivni krevet od borovine.", 50m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 200m, "SolidSleep", "Drveni krevet", 350.00m, 3, 160m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "ProductCategoryId", "Width" },
                values: new object[] { "1234567890131", "Elegantna polica od hrastovine.", 180m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 80m, "ShelfCraft", "Polica za knjige", 80.00m, 3, 25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Barcode", "Description", "Height", "ImageUrl", "Length", "Manufacturer", "Name", "Price", "Width" },
                values: new object[] { "1234567890132", "Ručno izrađen tanjir od oraha.", 2m, "https://images.vexels.com/media/users/3/145231/isolated/lists/1a16851a4d591d118fab747af0f38b84-chair-furniture-icon.png", 25m, "PlateWood", "Drveni tanjir", 15.00m, 25m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "56103a24-16e1-4609-85a3-cc6f465516c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6770931e-5b70-4611-970d-4c52f3c2ae87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "675d434e-5d92-40b4-b063-1ee43ce666aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b1bb1b25-894e-4e25-bd6e-01eefb1aff9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f1e11ec2-1d38-4d0b-aa38-ac662ae1cf03");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3e9727dd-184d-4152-84d8-8833a6aa383f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ffdc56fa-aa46-4b08-9828-f66c711d15ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a6b03ffa-142d-4a8b-8c67-9752bda08128");

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

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Njega lica");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Njega tijela");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Dodaci prehrani");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "Stock" },
                values: new object[] { "Krema za dubinsku hidrataciju suhe kože.", "https://logotyp.us/file/dm.svg", "Aqua, Glycerin, Aloe Vera", "Dermaline", "Hidratantna krema", 19.99m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { "1112223330000", "Specijalizovana krema za tretman akni i mitesera.", "https://logotyp.us/file/dm.svg", "Salicylic Acid, Tea Tree Oil", "AcneFix", "Krema za akne", 22.50m, 1, 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { "4567891234567", "Regenerišuća noćna krema protiv bora.", "https://logotyp.us/file/dm.svg", "Retinol, Hyaluronic Acid", "YouthSkin", "Noćna anti-age krema", 29.90m, 1, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "Stock" },
                values: new object[] { "8887776665554", "Micelarna voda za uklanjanje šminke i nečistoća.", "https://logotyp.us/file/dm.svg", "Aqua, Micelles, Chamomile Extract", "CleanFace", "Micelarna voda", 11.99m, 120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { "9090901234567", "Prirodna maska sa zelenom glinom za čišćenje pora.", "https://logotyp.us/file/dm.svg", "Green Clay, Aloe Vera", "NatureBeauty", "Maska za lice - glina", 13.75m, 1, 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { "9876543210987", "Osvježavajući gel za tuširanje sa citrusima.", "https://logotyp.us/file/dm.svg", "Aqua, Sodium Laureth Sulfate, Citrus Extract", "BodyFresh", "Gel za tuširanje", 9.49m, 2, 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "Stock" },
                values: new object[] { "3332221114448", "Hidratantni losion za svakodnevnu njegu kože tijela.", "https://logotyp.us/file/dm.svg", "Shea Butter, Vitamin E", "SoftSkin", "Losion za tijelo", 12.30m, 150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { "5656565656565", "Bogata krema za njegu i zaštitu ruku.", "https://logotyp.us/file/dm.svg", "Glycerin, Panthenol", "CareHands", "Krema za ruke", 5.99m, 2, 300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { "7778889991112", "Prirodno ulje za relaksirajuću masažu.", "https://logotyp.us/file/dm.svg", "Lavender Oil, Almond Oil", "RelaxTime", "Ulje za masažu", 18.00m, 2, 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Barcode", "Description", "ImageUrl", "Ingredients", "Manufacturer", "Name", "Price", "Stock" },
                values: new object[] { "2223334445556", "Piling sa morskom soli za glatku kožu.", "https://logotyp.us/file/dm.svg", "Sea Salt, Coconut Oil", "SeaBeauty", "Piling za tijelo", 15.90m, 85 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "DateCreated", "DateUpdated", "Description", "ImageUrl", "Ingredients", "IsDeleted", "IsEnable", "Manufacturer", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[,]
                {
                    { 11, "1112223334445", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Kompleks vitamina i minerala za svakodnevnu upotrebu.", "https://logotyp.us/file/dm.svg", "Vitamin A, C, D, E, Zinc, Iron", false, true, "NutriLife", "Multivitamin kapsule", 14.99m, 3, 150 },
                    { 12, "0001112223334", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Kapsule ribljeg ulja bogate omega-3 masnim kiselinama.", "https://logotyp.us/file/dm.svg", "Fish Oil, EPA, DHA", false, true, "HeartWell", "Omega 3 kapsule", 17.49m, 3, 130 },
                    { 13, "4445556667778", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Tablete vitamina C za jačanje imuniteta.", "https://logotyp.us/file/dm.svgg", "Vitamin C, Citrus Bioflavonoids", false, true, "C-Boost", "Vitamin C tablete", 6.99m, 3, 180 },
                    { 14, "5556667778889", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Probiotici za zdravlje crijeva.", "https://logotyp.us/file/dm.svg", "Lactobacillus, Bifidobacterium", false, true, "GutHealth", "Probiotik kapsule", 16.75m, 3, 110 },
                    { 15, "6667778889990", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Tablete za podršku nervnom sistemu i mišićima.", "https://logotyp.us/file/dm.svg", "Magnesium Citrate", false, true, "VitalPower", "Magnezijum tablete", 8.20m, 3, 140 }
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
        }
    }
}
