using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Movie_Customers_CustomerId",
                table: "Customer_Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Movie_Movies_MovieId",
                table: "Customer_Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Movie",
                table: "Customer_Movie");

            migrationBuilder.RenameTable(
                name: "Customer_Movie",
                newName: "Customer_Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Movie_MovieId",
                table: "Customer_Movies",
                newName: "IX_Customer_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Movies",
                table: "Customer_Movies",
                columns: new[] { "CustomerId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Movies_Customers_CustomerId",
                table: "Customer_Movies",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Movies_Movies_MovieId",
                table: "Customer_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Movies_Customers_CustomerId",
                table: "Customer_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Movies_Movies_MovieId",
                table: "Customer_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Movies",
                table: "Customer_Movies");

            migrationBuilder.RenameTable(
                name: "Customer_Movies",
                newName: "Customer_Movie");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Movies_MovieId",
                table: "Customer_Movie",
                newName: "IX_Customer_Movie_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Movie",
                table: "Customer_Movie",
                columns: new[] { "CustomerId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Movie_Customers_CustomerId",
                table: "Customer_Movie",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Movie_Movies_MovieId",
                table: "Customer_Movie",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
