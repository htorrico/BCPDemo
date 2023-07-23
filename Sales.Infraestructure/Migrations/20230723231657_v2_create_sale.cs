using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales.Infraestructure.Migrations
{
    public partial class v2_create_sale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseDomainEvent_Targets_TargetId",
                table: "BaseDomainEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Targets_Users_ManagerId",
                table: "Targets");

            migrationBuilder.DropForeignKey(
                name: "FK_Targets_Users_SellerId",
                table: "Targets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Targets",
                table: "Targets");

            migrationBuilder.RenameTable(
                name: "Targets",
                newName: "Target");

            migrationBuilder.RenameIndex(
                name: "IX_Targets_SellerId",
                table: "Target",
                newName: "IX_Target_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Targets_ManagerId",
                table: "Target",
                newName: "IX_Target_ManagerId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Target",
                table: "Target",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseDomainEvent_Target_TargetId",
                table: "BaseDomainEvent",
                column: "TargetId",
                principalTable: "Target",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Target_Users_ManagerId",
                table: "Target",
                column: "ManagerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Target_Users_SellerId",
                table: "Target",
                column: "SellerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseDomainEvent_Target_TargetId",
                table: "BaseDomainEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Target_Users_ManagerId",
                table: "Target");

            migrationBuilder.DropForeignKey(
                name: "FK_Target_Users_SellerId",
                table: "Target");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Target",
                table: "Target");

            migrationBuilder.RenameTable(
                name: "Target",
                newName: "Targets");

            migrationBuilder.RenameIndex(
                name: "IX_Target_SellerId",
                table: "Targets",
                newName: "IX_Targets_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Target_ManagerId",
                table: "Targets",
                newName: "IX_Targets_ManagerId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Targets",
                table: "Targets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseDomainEvent_Targets_TargetId",
                table: "BaseDomainEvent",
                column: "TargetId",
                principalTable: "Targets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Targets_Users_ManagerId",
                table: "Targets",
                column: "ManagerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Targets_Users_SellerId",
                table: "Targets",
                column: "SellerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
