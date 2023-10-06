using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfoliowebsite.Migrations
{
    /// <inheritdoc />
    public partial class abouttableremoveidcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_About",
                table: "About");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "About");

            migrationBuilder.AddPrimaryKey(
                name: "PK_About",
                table: "About",
                column: "Aboutid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_About",
                table: "About");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "About",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_About",
                table: "About",
                column: "Id");
        }
    }
}
