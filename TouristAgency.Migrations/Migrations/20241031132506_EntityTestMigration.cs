using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TouristAgency.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class EntityTestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    fileName = table.Column<string>(type: "varchar(260)", maxLength: 260, nullable: false),
                    original = table.Column<string>(type: "varchar(260)", maxLength: 260, nullable: false),
                    mime = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    ext = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SocialNetworks",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialNetworks", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "banks",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    mfo = table.Column<uint>(type: "int unsigned", nullable: false),
                    city = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banks", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    firstName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tourTypes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tourTypes", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "touristProfiles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    firstName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    lastName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    middleName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    comment = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: false),
                    email = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    noSendStatus = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    noSendNews = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    city = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    address = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_touristProfiles", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tours",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tours", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "compaties",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    address = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    BankId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compaties", x => x.id);
                    table.ForeignKey(
                        name: "FK_compaties_banks_BankId",
                        column: x => x.BankId,
                        principalTable: "banks",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IndividualPeople",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    firstName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    lastName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    middleName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    passportSerial = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false),
                    passportNumber = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false),
                    passportDistributor = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false),
                    passportMakeDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    passportExpiredDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualPeople", x => x.id);
                    table.ForeignKey(
                        name: "FK_IndividualPeople_touristProfiles_id",
                        column: x => x.id,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LegalPerson",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    edrpou = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    bossName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    bossFunction = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    paymentAccount = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    bankId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalPerson", x => x.id);
                    table.ForeignKey(
                        name: "FK_LegalPerson_banks_bankId",
                        column: x => x.bankId,
                        principalTable: "banks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LegalPerson_touristProfiles_id",
                        column: x => x.id,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "touristPhones",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    phone = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    sendSMS = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    touristId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_touristPhones", x => x.id);
                    table.ForeignKey(
                        name: "FK_touristPhones_touristProfiles_touristId",
                        column: x => x.touristId,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tourists_tags",
                columns: table => new
                {
                    touristId = table.Column<Guid>(type: "char(36)", nullable: false),
                    tagId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tourists_tags", x => new { x.tagId, x.touristId });
                    table.ForeignKey(
                        name: "FK_tourists_tags_tags_tagId",
                        column: x => x.tagId,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tourists_tags_touristProfiles_touristId",
                        column: x => x.touristId,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tours_ tourTypes",
                columns: table => new
                {
                    tourTypeId = table.Column<Guid>(type: "char(36)", nullable: false),
                    tourId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tours_ tourTypes", x => new { x.tourId, x.tourTypeId });
                    table.ForeignKey(
                        name: "FK_tours_ tourTypes_tourTypes_tourTypeId",
                        column: x => x.tourTypeId,
                        principalTable: "tourTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tours_ tourTypes_tours_tourId",
                        column: x => x.tourId,
                        principalTable: "tours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tours_countries",
                columns: table => new
                {
                    countryId = table.Column<Guid>(type: "char(36)", nullable: false),
                    tourId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tours_countries", x => new { x.tourId, x.countryId });
                    table.ForeignKey(
                        name: "FK_tours_countries_countries_countryId",
                        column: x => x.countryId,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tours_countries_tours_tourId",
                        column: x => x.tourId,
                        principalTable: "tours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    firstName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    lastName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    middleName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    companyId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_compaties_companyId",
                        column: x => x.companyId,
                        principalTable: "compaties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TPS",
                columns: table => new
                {
                    PhoneId = table.Column<Guid>(type: "char(36)", nullable: false),
                    SocialId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TPS", x => new { x.PhoneId, x.SocialId });
                    table.ForeignKey(
                        name: "FK_TPS_SocialNetworks_SocialId",
                        column: x => x.SocialId,
                        principalTable: "SocialNetworks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TPS_touristPhones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "touristPhones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false),
                    beginDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: false),
                    touristId = table.Column<Guid>(type: "char(36)", nullable: false),
                    agentId = table.Column<Guid>(type: "char(36)", nullable: false),
                    tourId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.id);
                    table.ForeignKey(
                        name: "FK_sales_Employees_agentId",
                        column: x => x.agentId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sales_touristProfiles_touristId",
                        column: x => x.touristId,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sales_tours_tourId",
                        column: x => x.tourId,
                        principalTable: "tours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_companyId",
                table: "Employees",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalPerson_bankId",
                table: "LegalPerson",
                column: "bankId");

            migrationBuilder.CreateIndex(
                name: "IX_TPS_SocialId",
                table: "TPS",
                column: "SocialId");

            migrationBuilder.CreateIndex(
                name: "IX_compaties_BankId",
                table: "compaties",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_agentId",
                table: "sales",
                column: "agentId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_tourId",
                table: "sales",
                column: "tourId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_touristId",
                table: "sales",
                column: "touristId");

            migrationBuilder.CreateIndex(
                name: "IX_touristPhones_touristId",
                table: "touristPhones",
                column: "touristId");

            migrationBuilder.CreateIndex(
                name: "IX_tourists_tags_touristId",
                table: "tourists_tags",
                column: "touristId");

            migrationBuilder.CreateIndex(
                name: "IX_tours_ tourTypes_tourTypeId",
                table: "tours_ tourTypes",
                column: "tourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tours_countries_countryId",
                table: "tours_countries",
                column: "countryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "IndividualPeople");

            migrationBuilder.DropTable(
                name: "LegalPerson");

            migrationBuilder.DropTable(
                name: "TPS");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "tourists_tags");

            migrationBuilder.DropTable(
                name: "tours_ tourTypes");

            migrationBuilder.DropTable(
                name: "tours_countries");

            migrationBuilder.DropTable(
                name: "SocialNetworks");

            migrationBuilder.DropTable(
                name: "touristPhones");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "tourTypes");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "tours");

            migrationBuilder.DropTable(
                name: "touristProfiles");

            migrationBuilder.DropTable(
                name: "compaties");

            migrationBuilder.DropTable(
                name: "banks");
        }
    }
}
