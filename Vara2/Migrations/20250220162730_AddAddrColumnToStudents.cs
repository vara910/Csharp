using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vara2.Migrations
{
    /// <inheritdoc />
    public partial class AddAddrColumnToStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Addr",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addr",
                table: "Students");
        }
    }
}
