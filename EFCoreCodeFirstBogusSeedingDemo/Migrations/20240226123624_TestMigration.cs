using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreCodeFirstBogusSeedingDemo.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addressess",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suburb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addressess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addressess_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "ContactNumber", "Email", "FirstName", "IsDeleted", "LastName" },
                values: new object[,]
                {
                    { new Guid("1d4ae7c8-e92e-300f-b259-40487b719964"), "0134523521", "Janice_Homenick28@gmail.com", "Janice", false, "Homenick" },
                    { new Guid("249819db-3c54-6d1f-00fd-a72d62fb3422"), "0376375104", "Myrtle.Hudson16@yahoo.com", "Myrtle", false, "Hudson" },
                    { new Guid("271c07b4-9e29-23cc-d0d7-201ffdb5b823"), "0940632890", "Greg.Frami@gmail.com", "Greg", false, "Frami" },
                    { new Guid("45dad974-2b4d-c26f-a6c3-6c0ebc31c3e3"), "0559451688", "Myrtle_Runolfsson@hotmail.com", "Myrtle", false, "Runolfsson" },
                    { new Guid("86be9f18-14a9-2172-2063-de168d905f72"), "0373167737", "Jeff_Lemke@yahoo.com", "Jeff", false, "Lemke" },
                    { new Guid("8e1d5c9e-f6b0-00f1-d05d-ac374b014d4c"), "0110591873", "Glenn11@yahoo.com", "Glenn", false, "Schiller" },
                    { new Guid("912e6e43-7ec6-052b-9dd0-f88ede967de8"), "0050937983", "Perry59@gmail.com", "Perry", false, "Wiegand" },
                    { new Guid("c80201d5-18d9-6549-6074-d1f25030273a"), "0729739345", "Irene.Harris@yahoo.com", "Irene", false, "Harris" },
                    { new Guid("dc9e9f52-a627-d5a7-10e2-0046e72830d4"), "0476225643", "Judy.Kihn88@yahoo.com", "Judy", false, "Kihn" },
                    { new Guid("f8b44a4d-8a3a-f77b-1bb6-c06fc235670a"), "0225566141", "Frederick.Daugherty60@gmail.com", "Frederick", false, "Daugherty" }
                });

            migrationBuilder.InsertData(
                table: "Addressess",
                columns: new[] { "Id", "Country", "HouseNumber", "IsDeleted", "PersonId", "PostalCode", "Province", "Street", "Suburb" },
                values: new object[,]
                {
                    { new Guid("1973214f-2304-e920-1820-4b283810918e"), "Sweden", null, false, new Guid("271c07b4-9e29-23cc-d0d7-201ffdb5b823"), "47546-2747", "Wisconsin", null, null },
                    { new Guid("34ef5ad7-21ad-ccb5-07a9-9bcd731c6a7e"), "Argentina", "883", false, new Guid("1d4ae7c8-e92e-300f-b259-40487b719964"), "57776", "New Jersey", "Rudolph Route", "Port Sidville" },
                    { new Guid("510c5782-5b43-14e8-52b9-b7c6e78a964c"), "Cuba", null, false, new Guid("8e1d5c9e-f6b0-00f1-d05d-ac374b014d4c"), "43610", "Alaska", "Nicolas Landing", "Nikkoside" },
                    { new Guid("53c98e15-ce14-cd23-4a01-ec1e02c07e4d"), "Martinique", "9006", false, new Guid("dc9e9f52-a627-d5a7-10e2-0046e72830d4"), "83879", "Alaska", "Mueller Cove", "East Melissa" },
                    { new Guid("6957d7de-35b7-3028-1715-0a1b92ecf517"), "Andorra", "63880", false, new Guid("912e6e43-7ec6-052b-9dd0-f88ede967de8"), "98479-5981", "Hawaii", "Harold View", "Westonberg" },
                    { new Guid("81d90631-7565-9016-4ddb-87d4729571a7"), "Bahrain", "202", false, new Guid("249819db-3c54-6d1f-00fd-a72d62fb3422"), "17434", "New Hampshire", "Carolyn Skyway", "West Vernershire" },
                    { new Guid("9f4c944e-7a57-e41b-038a-83ed06bece81"), "Switzerland", "9991", false, new Guid("c80201d5-18d9-6549-6074-d1f25030273a"), "35150-4248", "West Virginia", "Braun Ramp", "Lake Nathaniel" },
                    { new Guid("bc69e0bc-c69e-b701-4886-741dfda4fdbf"), "Somalia", "5205", false, new Guid("f8b44a4d-8a3a-f77b-1bb6-c06fc235670a"), "92147-0114", "Montana", "Dooley Drives", "Cheyenneview" },
                    { new Guid("e3e3ff97-23e1-aa86-8ca9-a70806611ee0"), "Gibraltar", "9015", false, new Guid("45dad974-2b4d-c26f-a6c3-6c0ebc31c3e3"), "51728", "Mississippi", "Satterfield Drive", null },
                    { new Guid("e5609d80-1aa1-9454-9846-2c4ee0c9749b"), "Falkland Islands (Malvinas)", "99465", false, new Guid("86be9f18-14a9-2172-2063-de168d905f72"), null, "Alabama", null, "Predovicmouth" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addressess_PersonId",
                table: "Addressess",
                column: "PersonId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addressess");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
