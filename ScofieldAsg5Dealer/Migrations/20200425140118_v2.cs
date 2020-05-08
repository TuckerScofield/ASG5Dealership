using Microsoft.EntityFrameworkCore.Migrations;

namespace ScofieldAsg10Cars.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakeModel = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "ID", "Color", "MakeModel", "Mileage", "Price", "Year" },
                values: new object[,]
                {
                    { 1, "Silver", "Plymouth Horizon Hatch", 65124, 300, 1983 },
                    { 2, "Burnt Orange", "Chevrolet Chevette", 75894, 450, 1976 },
                    { 3, "Red/White", "Ford F-150", 74358, 1200, 1987 },
                    { 4, "Forest Green", "Saab 900S", 64124, 2100, 1994 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
