using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCrudiMat.Server.Migrations
{
    public partial class InitialAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osobas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Grad = table.Column<string>(nullable: true),
                    PObox = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    Broj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobas", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Osobas",
                columns: new[] { "ID", "Broj", "Grad", "Ime", "PObox", "Prezime", "Ulica" },
                values: new object[] { -1, "356", "asd", "Pera", "234", "Peric", "zklj" });

            migrationBuilder.InsertData(
                table: "Osobas",
                columns: new[] { "ID", "Broj", "Grad", "Ime", "PObox", "Prezime", "Ulica" },
                values: new object[] { -2, "87", "zxc", "Neko", "567", "Nekic", "kjhg" });

            migrationBuilder.InsertData(
                table: "Osobas",
                columns: new[] { "ID", "Broj", "Grad", "Ime", "PObox", "Prezime", "Ulica" },
                values: new object[] { -3, "Neki tamo", "aefesf", "Zkljjj", "233000", "Blabla", "Neka tamo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osobas");
        }
    }
}
