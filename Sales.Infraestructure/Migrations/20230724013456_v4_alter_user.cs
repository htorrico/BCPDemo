using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales.Infraestructure.Migrations
{
    public partial class v4_alter_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DNI",
                table: "Users",
                newName: "DocumentNumber");

            migrationBuilder.AddColumn<int>(
                name: "DocumentType",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "DocumentNumber",
                table: "Users",
                newName: "DNI");
        }
    }
}
