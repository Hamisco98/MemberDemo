using Microsoft.EntityFrameworkCore.Migrations;

namespace MemberDemo.Migrations
{
    public partial class MemberDemoThird : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Members");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminID", "AdminEmail", "FirstName", "LastName", "Password" },
                values: new object[] { 1, "hamis@gmail.com", "Mohamed", "Hamis", "M:a:2737417" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { 1, "US" },
                    { 2, "UK" },
                    { 3, "Egypt" },
                    { 4, "Saudi Arabia" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId" },
                values: new object[,]
                {
                    { 9, "NewYourk", 1 },
                    { 2, "Maddinh", 4 },
                    { 1, "Makka", 4 },
                    { 8, "Alex", 3 },
                    { 7, "Mahala", 3 },
                    { 6, "Cairo", 3 },
                    { 5, "Mansoura", 3 },
                    { 19, "Belfast", 2 },
                    { 3, "Riyadh", 4 },
                    { 18, "Cardiff", 2 },
                    { 16, "Birmingham", 2 },
                    { 15, "Edinburgh", 2 },
                    { 14, "Manchester", 2 },
                    { 13, "London", 2 },
                    { 12, "Maiamy", 1 },
                    { 11, "Vigase", 1 },
                    { 10, "LA", 1 },
                    { 17, "Glasgow", 2 },
                    { 4, "Damam", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_CityId",
                table: "Members",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_CountryId",
                table: "Members",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Cities_CityId",
                table: "Members",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Countries_CountryId",
                table: "Members",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Cities_CityId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Countries_CountryId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Members_CityId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_CountryId",
                table: "Members");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Members");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
