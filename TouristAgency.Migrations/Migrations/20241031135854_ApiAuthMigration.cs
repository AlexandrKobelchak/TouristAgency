using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TouristAgency.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ApiAuthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Data = table.Column<string>(type: "longtext", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Data = table.Column<string>(type: "longtext", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "SocialNetworks",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { new Guid("2fa0ce9c-8b07-4b41-85a7-82a60517a10a"), "Viber" },
                    { new Guid("b6e69357-1782-461d-b0b9-9d6efd52a7f4"), "Telegram" }
                });

            migrationBuilder.InsertData(
                table: "tags",
                columns: new[] { "id", "firstName" },
                values: new object[,]
                {
                    { new Guid("11de133d-9f34-441c-8c1a-6bfc50cb51fa"), "Семья" },
                    { new Guid("5bbd4cf5-28d6-4627-8413-ec8dca5ad0e5"), "Экскурсионный отдых" },
                    { new Guid("5fa72c14-5554-44b7-a5f0-f606b40d170c"), "Ездит один" },
                    { new Guid("7bc484f5-fbce-4542-a504-7d004076b4b0"), "Горнолыжный отдых" },
                    { new Guid("a75d66c4-b4cc-45d1-bac4-39c992537b06"), "Эконом" },
                    { new Guid("b07828a0-9ed4-4108-a3e1-aefeaa9e3a45"), "Постоянный клиент" },
                    { new Guid("f1315c23-42f2-4f87-9e59-f62a3a87d17d"), "Активный отдых" },
                    { new Guid("fa107d07-cfb3-4667-9a27-68d4bade0efe"), "VIP" }
                });

            migrationBuilder.InsertData(
                table: "touristProfiles",
                columns: new[] { "id", "address", "birthday", "city", "comment", "email", "firstName", "lastName", "middleName", "noSendNews", "noSendStatus" },
                values: new object[,]
                {
                    { new Guid("055b8af1-4aa9-45a9-a953-fe237731396a"), "Живет где-то в Киеве", new DateTime(1988, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Киев", "Очень хороший человек", null, "Владимир", "Тестовый", "Иванович", false, false },
                    { new Guid("c18ddec9-0af4-4017-9e30-96651267ac99"), "Живет где-то в Днепре", new DateTime(1978, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Днепр", "Просто хороший человек", null, "Иван", "Тестовый", "Иванович", false, false },
                    { new Guid("c6880bd9-0d27-409f-87c9-7ccc940b19a6"), "Живет где-то в Сухачевке", new DateTime(1973, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сухачевка", "Просто хороший человек", null, "Тест", "Иванов", "Тестович", false, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("2fa0ce9c-8b07-4b41-85a7-82a60517a10a"));

            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("b6e69357-1782-461d-b0b9-9d6efd52a7f4"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("11de133d-9f34-441c-8c1a-6bfc50cb51fa"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("5bbd4cf5-28d6-4627-8413-ec8dca5ad0e5"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("5fa72c14-5554-44b7-a5f0-f606b40d170c"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("7bc484f5-fbce-4542-a504-7d004076b4b0"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("a75d66c4-b4cc-45d1-bac4-39c992537b06"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("b07828a0-9ed4-4108-a3e1-aefeaa9e3a45"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("f1315c23-42f2-4f87-9e59-f62a3a87d17d"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("fa107d07-cfb3-4667-9a27-68d4bade0efe"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("055b8af1-4aa9-45a9-a953-fe237731396a"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("c18ddec9-0af4-4017-9e30-96651267ac99"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("c6880bd9-0d27-409f-87c9-7ccc940b19a6"));

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
    }
}
