using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfoliowebsite.Migrations
{
    /// <inheritdoc />
    public partial class updateabouttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileName",
                table: "About",
                newName: "LName");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FName",
                table: "About");

            migrationBuilder.RenameColumn(
                name: "LName",
                table: "About",
                newName: "ProfileName");
        }
    }
}
