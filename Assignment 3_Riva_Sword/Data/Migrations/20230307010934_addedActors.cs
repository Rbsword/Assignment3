using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_3_Riva_Sword.Data.Migrations
{
    public partial class addedActors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IMBDLink",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMBDLink",
                table: "Actor");
        }
    }
}
