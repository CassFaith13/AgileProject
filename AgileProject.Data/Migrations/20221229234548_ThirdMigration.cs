using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgileProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentRating",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeasons",
                table: "Shows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseYear",
                table: "Shows",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ShowId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShowsShowId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContentRating",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ShowsShowId",
                table: "Ratings",
                column: "ShowsShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Shows_ShowsShowId",
                table: "Ratings",
                column: "ShowsShowId",
                principalTable: "Shows",
                principalColumn: "ShowId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Shows_ShowsShowId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_ShowsShowId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ContentRating",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "NumberOfSeasons",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "ShowId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ShowsShowId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ContentRating",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");
        }
    }
}
