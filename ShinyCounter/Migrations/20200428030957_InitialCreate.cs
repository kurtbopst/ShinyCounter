using Microsoft.EntityFrameworkCore.Migrations;

namespace ShinyCounter.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    caught1 = table.Column<bool>(nullable: false),
                    caught2 = table.Column<bool>(nullable: false),
                    caught3 = table.Column<bool>(nullable: false),
                    caught4 = table.Column<bool>(nullable: false),
                    caught5 = table.Column<bool>(nullable: false),
                    caught6 = table.Column<bool>(nullable: false),
                    caught7 = table.Column<bool>(nullable: false),
                    caught8 = table.Column<bool>(nullable: false),
                    caught9 = table.Column<bool>(nullable: false),
                    caught10 = table.Column<bool>(nullable: false),
                    caught11 = table.Column<bool>(nullable: false),
                    caught12 = table.Column<bool>(nullable: false),
                    goal = table.Column<int>(nullable: false),
                    counter = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
