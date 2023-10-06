using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfoliowebsite.Migrations
{
    /// <inheritdoc />
    public partial class aa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SocialMedia_User_Id",
                table: "SocialMedia");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_User_Id",
                table: "SocialMedia",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SocialMedia_User_Id",
                table: "SocialMedia");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_User_Id",
                table: "SocialMedia",
                column: "User_Id",
                unique: true);
        }
    }
}
