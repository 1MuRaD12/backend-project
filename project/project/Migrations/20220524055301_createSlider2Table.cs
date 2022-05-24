using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class createSlider2Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sliders2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    subtitle = table.Column<string>(nullable: true),
                    about = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sliders2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sliders2");
        }
    }
}
