using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgileProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MoviesMovieId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MoviesMovieId",
                table: "Ratings",
                column: "MoviesMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_MoviesMovieId",
                table: "Ratings",
                column: "MoviesMovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_MoviesMovieId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_MoviesMovieId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "MoviesMovieId",
                table: "Ratings");
        }
    }
}
