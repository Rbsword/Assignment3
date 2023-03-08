using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_3_Riva_Sword.Data.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "MoviePoster",
                table: "Movie",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<byte[]>(
                name: "ActorPhoto",
                table: "Actor",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "MovieId",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "Actor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MovieActor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    ActorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieActor_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MovieActor_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_MovieId1",
                table: "Actor",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActor_ActorId",
                table: "MovieActor",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActor_MovieId",
                table: "MovieActor",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_MovieId1",
                table: "Actor",
                column: "MovieId1",
                principalTable: "Movie",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_MovieId1",
                table: "Actor");

            migrationBuilder.DropTable(
                name: "MovieActor");

            migrationBuilder.DropIndex(
                name: "IX_Actor_MovieId1",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "MoviePoster",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ActorPhoto",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "Actor");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
