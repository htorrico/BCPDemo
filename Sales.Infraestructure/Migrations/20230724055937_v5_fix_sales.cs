using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales.Infraestructure.Migrations
{
    public partial class v5_fix_sales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "BaseDomainEvent",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Targets",
                table: "Targets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Points = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sales_Users_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseDomainEvent_SaleId",
                table: "BaseDomainEvent",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SellerId",
                table: "Sales",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseDomainEvent_Sales_SaleId",
                table: "BaseDomainEvent",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");

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
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Targets_Users_SellerId",
                table: "Targets",
                column: "SellerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseDomainEvent_Sales_SaleId",
                table: "BaseDomainEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseDomainEvent_Targets_TargetId",
                table: "BaseDomainEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Targets_Users_ManagerId",
                table: "Targets");

            migrationBuilder.DropForeignKey(
                name: "FK_Targets_Users_SellerId",
                table: "Targets");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_BaseDomainEvent_SaleId",
                table: "BaseDomainEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Targets",
                table: "Targets");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "BaseDomainEvent");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Target_Users_SellerId",
                table: "Target",
                column: "SellerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
