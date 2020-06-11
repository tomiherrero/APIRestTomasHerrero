using Microsoft.EntityFrameworkCore.Migrations;

namespace APIRestTomasHerrero.Migrations
{
    public partial class StudentsDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsDB",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dni = table.Column<int>(nullable: false),
                    names = table.Column<string>(nullable: true),
                    surnames = table.Column<string>(nullable: true),
                    course = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsDB", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsDB");
        }
    }
}
