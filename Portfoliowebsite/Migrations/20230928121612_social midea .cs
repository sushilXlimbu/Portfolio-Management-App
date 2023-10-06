using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfoliowebsite.Migrations
{
    /// <inheritdoc />
    public partial class socialmidea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SocialMedia_User_Id",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "SocialMediaName",
                table: "SocialMedia");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_User_Id",
                table: "SocialMedia",
                column: "User_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SocialMedia_User_Id",
                table: "SocialMedia");

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaName",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_User_Id",
                table: "SocialMedia",
                column: "User_Id");
        }
    }
}
