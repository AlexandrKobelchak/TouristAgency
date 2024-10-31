using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TouristAgency.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class EntityNoWarningMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("48ac638f-9f2d-4a34-b168-3d0a54c8a01d"));

            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("a8fd6dd7-570d-45af-a9f0-836d6b71d5b9"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("2200995c-8108-4a5d-b62b-41e9778997f2"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("6ebb08f5-3c40-4784-993f-0dbe4c0aae3f"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("abbf7fe1-d6a8-480e-8249-f5f8df7cb2bd"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("af9abb19-eaf5-43fb-86c7-51f937839343"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("d1e91018-e7ea-4e81-9552-d748d0fe9aeb"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("d54bdd70-1b7a-49a8-8980-df4887f39747"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("d5889e39-5a43-45ea-b974-2ab8cb78afaa"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("fdfc01e1-c8ad-4538-bb84-c1a6f02daa36"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("b8162992-3ad7-41d7-bf3a-7f73bdd670b9"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("cbd34d7b-d56f-41ab-8f1b-9dd070fda512"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("e177e5bd-68f7-472a-b00d-d91cd6cb1d80"));

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "sales",
                type: "varchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "passportSerial",
                table: "IndividualPeople",
                type: "varchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "passportNumber",
                table: "IndividualPeople",
                type: "varchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "passportDistributor",
                table: "IndividualPeople",
                type: "varchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "middleName",
                table: "IndividualPeople",
                type: "varchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "middleName",
                table: "Employees",
                type: "varchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "SocialNetworks",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { new Guid("53ee61aa-fde7-4fb6-9860-ab16e22a96bc"), "Telegram" },
                    { new Guid("f5cf9b10-14a4-4f55-bfb4-2cea568b646a"), "Viber" }
                });

            migrationBuilder.InsertData(
                table: "tags",
                columns: new[] { "id", "firstName" },
                values: new object[,]
                {
                    { new Guid("05322c9d-e7b7-449a-a4b1-9f0cfb96ab7d"), "Эконом" },
                    { new Guid("18555408-13ea-4e37-a873-f071dd8deec6"), "Ездит один" },
                    { new Guid("2463ee39-cf47-4008-b02b-f989d3600309"), "Горнолыжный отдых" },
                    { new Guid("4d194891-14fb-4bd5-9343-c94392d537dc"), "VIP" },
                    { new Guid("8f2a2a8c-792b-4d56-ab8d-b967bd128534"), "Экскурсионный отдых" },
                    { new Guid("a7d43b13-3a95-4861-9b41-57a57ef75c8e"), "Активный отдых" },
                    { new Guid("e8962f58-6d03-4b60-be7c-bbeb5b5acc74"), "Постоянный клиент" },
                    { new Guid("fe4e5eb1-03e6-4ab8-9980-396a2319a229"), "Семья" }
                });

            migrationBuilder.InsertData(
                table: "touristProfiles",
                columns: new[] { "id", "address", "birthday", "city", "comment", "email", "firstName", "lastName", "middleName", "noSendNews", "noSendStatus" },
                values: new object[,]
                {
                    { new Guid("b80e65bd-54a4-4841-841f-8bce50326f4f"), "Живет где-то в Днепре", new DateTime(1978, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Днепр", "Просто хороший человек", null, "Иван", "Тестовый", "Иванович", false, false },
                    { new Guid("c0219f11-9b24-4a98-8361-3e0c990f29c1"), "Живет где-то в Сухачевке", new DateTime(1973, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сухачевка", "Просто хороший человек", null, "Тест", "Иванов", "Тестович", false, false },
                    { new Guid("f221d86a-92d8-47f5-86cb-6c15d6351297"), "Живет где-то в Киеве", new DateTime(1988, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Киев", "Очень хороший человек", null, "Владимир", "Тестовый", "Иванович", false, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("53ee61aa-fde7-4fb6-9860-ab16e22a96bc"));

            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("f5cf9b10-14a4-4f55-bfb4-2cea568b646a"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("05322c9d-e7b7-449a-a4b1-9f0cfb96ab7d"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("18555408-13ea-4e37-a873-f071dd8deec6"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("2463ee39-cf47-4008-b02b-f989d3600309"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("4d194891-14fb-4bd5-9343-c94392d537dc"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("8f2a2a8c-792b-4d56-ab8d-b967bd128534"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("a7d43b13-3a95-4861-9b41-57a57ef75c8e"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("e8962f58-6d03-4b60-be7c-bbeb5b5acc74"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("fe4e5eb1-03e6-4ab8-9980-396a2319a229"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("b80e65bd-54a4-4841-841f-8bce50326f4f"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("c0219f11-9b24-4a98-8361-3e0c990f29c1"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("f221d86a-92d8-47f5-86cb-6c15d6351297"));

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "sales",
                type: "varchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "passportSerial",
                table: "IndividualPeople",
                type: "varchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "passportNumber",
                table: "IndividualPeople",
                type: "varchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "passportDistributor",
                table: "IndividualPeople",
                type: "varchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "middleName",
                table: "IndividualPeople",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "middleName",
                table: "Employees",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "SocialNetworks",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { new Guid("48ac638f-9f2d-4a34-b168-3d0a54c8a01d"), "Viber" },
                    { new Guid("a8fd6dd7-570d-45af-a9f0-836d6b71d5b9"), "Telegram" }
                });

            migrationBuilder.InsertData(
                table: "tags",
                columns: new[] { "id", "firstName" },
                values: new object[,]
                {
                    { new Guid("2200995c-8108-4a5d-b62b-41e9778997f2"), "Активный отдых" },
                    { new Guid("6ebb08f5-3c40-4784-993f-0dbe4c0aae3f"), "Экскурсионный отдых" },
                    { new Guid("abbf7fe1-d6a8-480e-8249-f5f8df7cb2bd"), "Горнолыжный отдых" },
                    { new Guid("af9abb19-eaf5-43fb-86c7-51f937839343"), "Постоянный клиент" },
                    { new Guid("d1e91018-e7ea-4e81-9552-d748d0fe9aeb"), "Семья" },
                    { new Guid("d54bdd70-1b7a-49a8-8980-df4887f39747"), "Ездит один" },
                    { new Guid("d5889e39-5a43-45ea-b974-2ab8cb78afaa"), "Эконом" },
                    { new Guid("fdfc01e1-c8ad-4538-bb84-c1a6f02daa36"), "VIP" }
                });

            migrationBuilder.InsertData(
                table: "touristProfiles",
                columns: new[] { "id", "address", "birthday", "city", "comment", "email", "firstName", "lastName", "middleName", "noSendNews", "noSendStatus" },
                values: new object[,]
                {
                    { new Guid("b8162992-3ad7-41d7-bf3a-7f73bdd670b9"), "Живет где-то в Сухачевке", new DateTime(1973, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сухачевка", "Просто хороший человек", null, "Тест", "Иванов", "Тестович", false, false },
                    { new Guid("cbd34d7b-d56f-41ab-8f1b-9dd070fda512"), "Живет где-то в Днепре", new DateTime(1978, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Днепр", "Просто хороший человек", null, "Иван", "Тестовый", "Иванович", false, false },
                    { new Guid("e177e5bd-68f7-472a-b00d-d91cd6cb1d80"), "Живет где-то в Киеве", new DateTime(1988, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Киев", "Очень хороший человек", null, "Владимир", "Тестовый", "Иванович", false, false }
                });
        }
    }
}
