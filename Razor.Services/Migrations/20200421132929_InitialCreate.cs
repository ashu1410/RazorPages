using Microsoft.EntityFrameworkCore.Migrations;

namespace Razor.Services.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "resPages",
                columns: table => new
                {
                    ID_res = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Link = table.Column<string>(nullable: false),
                    Img_path = table.Column<string>(nullable: true),
                    resCat = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resPages", x => x.ID_res);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resPages");
        }
    }
}
