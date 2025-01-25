using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IRSv2._0.Migrations
{
    /// <inheritdoc />
    public partial class switchToAdi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cooks_Managers_ManagerID",
                table: "Cooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliverers_Managers_ManagerID",
                table: "Deliverers");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Managers_ManagerID",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Waiters_WaiterID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ToGoOrders_ToGoOrderID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageItems_Products_ProductID",
                table: "StorageItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Hosts_HostID",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Waiters_WaiterID",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_ToGoOrders_Deliverers_DelivererID",
                table: "ToGoOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ToGoOrders_Hosts_HostID",
                table: "ToGoOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Waiters_Managers_ManagerID",
                table: "Waiters");

            migrationBuilder.DropTable(
                name: "CookOrder");

            migrationBuilder.DropTable(
                name: "CookToGoOrder");

            migrationBuilder.DropIndex(
                name: "IX_Orders_WaiterID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Waiters",
                newName: "ManagersModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Waiters_ManagerID",
                table: "Waiters",
                newName: "IX_Waiters_ManagersModelID");

            migrationBuilder.RenameColumn(
                name: "HostID",
                table: "ToGoOrders",
                newName: "HostsModelID");

            migrationBuilder.RenameColumn(
                name: "DelivererID",
                table: "ToGoOrders",
                newName: "DeliverersModelID");

            migrationBuilder.RenameIndex(
                name: "IX_ToGoOrders_HostID",
                table: "ToGoOrders",
                newName: "IX_ToGoOrders_HostsModelID");

            migrationBuilder.RenameIndex(
                name: "IX_ToGoOrders_DelivererID",
                table: "ToGoOrders",
                newName: "IX_ToGoOrders_DeliverersModelID");

            migrationBuilder.RenameColumn(
                name: "WaiterID",
                table: "Tables",
                newName: "WaitersModelID");

            migrationBuilder.RenameColumn(
                name: "HostID",
                table: "Tables",
                newName: "HostsModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_WaiterID",
                table: "Tables",
                newName: "IX_Tables_WaitersModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_HostID",
                table: "Tables",
                newName: "IX_Tables_HostsModelID");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "StorageItems",
                newName: "ProductsModelID");

            migrationBuilder.RenameIndex(
                name: "IX_StorageItems_ProductID",
                table: "StorageItems",
                newName: "IX_StorageItems_ProductsModelID");

            migrationBuilder.RenameColumn(
                name: "ToGoOrderID",
                table: "Products",
                newName: "ToGoOrdersModelID");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Products",
                newName: "OrdersModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ToGoOrderID",
                table: "Products",
                newName: "IX_Products_ToGoOrdersModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_OrderID",
                table: "Products",
                newName: "IX_Products_OrdersModelID");

            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Hosts",
                newName: "ManagersModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Hosts_ManagerID",
                table: "Hosts",
                newName: "IX_Hosts_ManagersModelID");

            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Deliverers",
                newName: "ManagersModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Deliverers_ManagerID",
                table: "Deliverers",
                newName: "IX_Deliverers_ManagersModelID");

            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Cooks",
                newName: "ManagersModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Cooks_ManagerID",
                table: "Cooks",
                newName: "IX_Cooks_ManagersModelID");

            migrationBuilder.AlterColumn<string>(
                name: "WaiterID",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "WaitersModelID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CooksModelOrdersModel",
                columns: table => new
                {
                    CooksID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrdersID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CooksModelOrdersModel", x => new { x.CooksID, x.OrdersID });
                    table.ForeignKey(
                        name: "FK_CooksModelOrdersModel_Cooks_CooksID",
                        column: x => x.CooksID,
                        principalTable: "Cooks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CooksModelOrdersModel_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CooksModelToGoOrdersModel",
                columns: table => new
                {
                    CooksID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ToGoOrdersID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CooksModelToGoOrdersModel", x => new { x.CooksID, x.ToGoOrdersID });
                    table.ForeignKey(
                        name: "FK_CooksModelToGoOrdersModel_Cooks_CooksID",
                        column: x => x.CooksID,
                        principalTable: "Cooks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CooksModelToGoOrdersModel_ToGoOrders_ToGoOrdersID",
                        column: x => x.ToGoOrdersID,
                        principalTable: "ToGoOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WaitersModelID",
                table: "Orders",
                column: "WaitersModelID");

            migrationBuilder.CreateIndex(
                name: "IX_CooksModelOrdersModel_OrdersID",
                table: "CooksModelOrdersModel",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_CooksModelToGoOrdersModel_ToGoOrdersID",
                table: "CooksModelToGoOrdersModel",
                column: "ToGoOrdersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cooks_Managers_ManagersModelID",
                table: "Cooks",
                column: "ManagersModelID",
                principalTable: "Managers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliverers_Managers_ManagersModelID",
                table: "Deliverers",
                column: "ManagersModelID",
                principalTable: "Managers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Managers_ManagersModelID",
                table: "Hosts",
                column: "ManagersModelID",
                principalTable: "Managers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Waiters_WaitersModelID",
                table: "Orders",
                column: "WaitersModelID",
                principalTable: "Waiters",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrdersModelID",
                table: "Products",
                column: "OrdersModelID",
                principalTable: "Orders",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ToGoOrders_ToGoOrdersModelID",
                table: "Products",
                column: "ToGoOrdersModelID",
                principalTable: "ToGoOrders",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageItems_Products_ProductsModelID",
                table: "StorageItems",
                column: "ProductsModelID",
                principalTable: "Products",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Hosts_HostsModelID",
                table: "Tables",
                column: "HostsModelID",
                principalTable: "Hosts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Waiters_WaitersModelID",
                table: "Tables",
                column: "WaitersModelID",
                principalTable: "Waiters",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToGoOrders_Deliverers_DeliverersModelID",
                table: "ToGoOrders",
                column: "DeliverersModelID",
                principalTable: "Deliverers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToGoOrders_Hosts_HostsModelID",
                table: "ToGoOrders",
                column: "HostsModelID",
                principalTable: "Hosts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Waiters_Managers_ManagersModelID",
                table: "Waiters",
                column: "ManagersModelID",
                principalTable: "Managers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cooks_Managers_ManagersModelID",
                table: "Cooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliverers_Managers_ManagersModelID",
                table: "Deliverers");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Managers_ManagersModelID",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Waiters_WaitersModelID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrdersModelID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ToGoOrders_ToGoOrdersModelID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageItems_Products_ProductsModelID",
                table: "StorageItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Hosts_HostsModelID",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Waiters_WaitersModelID",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_ToGoOrders_Deliverers_DeliverersModelID",
                table: "ToGoOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ToGoOrders_Hosts_HostsModelID",
                table: "ToGoOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Waiters_Managers_ManagersModelID",
                table: "Waiters");

            migrationBuilder.DropTable(
                name: "CooksModelOrdersModel");

            migrationBuilder.DropTable(
                name: "CooksModelToGoOrdersModel");

            migrationBuilder.DropIndex(
                name: "IX_Orders_WaitersModelID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "WaitersModelID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ManagersModelID",
                table: "Waiters",
                newName: "ManagerID");

            migrationBuilder.RenameIndex(
                name: "IX_Waiters_ManagersModelID",
                table: "Waiters",
                newName: "IX_Waiters_ManagerID");

            migrationBuilder.RenameColumn(
                name: "HostsModelID",
                table: "ToGoOrders",
                newName: "HostID");

            migrationBuilder.RenameColumn(
                name: "DeliverersModelID",
                table: "ToGoOrders",
                newName: "DelivererID");

            migrationBuilder.RenameIndex(
                name: "IX_ToGoOrders_HostsModelID",
                table: "ToGoOrders",
                newName: "IX_ToGoOrders_HostID");

            migrationBuilder.RenameIndex(
                name: "IX_ToGoOrders_DeliverersModelID",
                table: "ToGoOrders",
                newName: "IX_ToGoOrders_DelivererID");

            migrationBuilder.RenameColumn(
                name: "WaitersModelID",
                table: "Tables",
                newName: "WaiterID");

            migrationBuilder.RenameColumn(
                name: "HostsModelID",
                table: "Tables",
                newName: "HostID");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_WaitersModelID",
                table: "Tables",
                newName: "IX_Tables_WaiterID");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_HostsModelID",
                table: "Tables",
                newName: "IX_Tables_HostID");

            migrationBuilder.RenameColumn(
                name: "ProductsModelID",
                table: "StorageItems",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_StorageItems_ProductsModelID",
                table: "StorageItems",
                newName: "IX_StorageItems_ProductID");

            migrationBuilder.RenameColumn(
                name: "ToGoOrdersModelID",
                table: "Products",
                newName: "ToGoOrderID");

            migrationBuilder.RenameColumn(
                name: "OrdersModelID",
                table: "Products",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ToGoOrdersModelID",
                table: "Products",
                newName: "IX_Products_ToGoOrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_OrdersModelID",
                table: "Products",
                newName: "IX_Products_OrderID");

            migrationBuilder.RenameColumn(
                name: "ManagersModelID",
                table: "Hosts",
                newName: "ManagerID");

            migrationBuilder.RenameIndex(
                name: "IX_Hosts_ManagersModelID",
                table: "Hosts",
                newName: "IX_Hosts_ManagerID");

            migrationBuilder.RenameColumn(
                name: "ManagersModelID",
                table: "Deliverers",
                newName: "ManagerID");

            migrationBuilder.RenameIndex(
                name: "IX_Deliverers_ManagersModelID",
                table: "Deliverers",
                newName: "IX_Deliverers_ManagerID");

            migrationBuilder.RenameColumn(
                name: "ManagersModelID",
                table: "Cooks",
                newName: "ManagerID");

            migrationBuilder.RenameIndex(
                name: "IX_Cooks_ManagersModelID",
                table: "Cooks",
                newName: "IX_Cooks_ManagerID");

            migrationBuilder.AlterColumn<string>(
                name: "WaiterID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "CookOrder",
                columns: table => new
                {
                    CooksID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrdersID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookOrder", x => new { x.CooksID, x.OrdersID });
                    table.ForeignKey(
                        name: "FK_CookOrder_Cooks_CooksID",
                        column: x => x.CooksID,
                        principalTable: "Cooks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookOrder_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CookToGoOrder",
                columns: table => new
                {
                    CooksID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ToGoOrdersID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookToGoOrder", x => new { x.CooksID, x.ToGoOrdersID });
                    table.ForeignKey(
                        name: "FK_CookToGoOrder_Cooks_CooksID",
                        column: x => x.CooksID,
                        principalTable: "Cooks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookToGoOrder_ToGoOrders_ToGoOrdersID",
                        column: x => x.ToGoOrdersID,
                        principalTable: "ToGoOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WaiterID",
                table: "Orders",
                column: "WaiterID");

            migrationBuilder.CreateIndex(
                name: "IX_CookOrder_OrdersID",
                table: "CookOrder",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_CookToGoOrder_ToGoOrdersID",
                table: "CookToGoOrder",
                column: "ToGoOrdersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cooks_Managers_ManagerID",
                table: "Cooks",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliverers_Managers_ManagerID",
                table: "Deliverers",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Managers_ManagerID",
                table: "Hosts",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Waiters_WaiterID",
                table: "Orders",
                column: "WaiterID",
                principalTable: "Waiters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderID",
                table: "Products",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ToGoOrders_ToGoOrderID",
                table: "Products",
                column: "ToGoOrderID",
                principalTable: "ToGoOrders",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageItems_Products_ProductID",
                table: "StorageItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Hosts_HostID",
                table: "Tables",
                column: "HostID",
                principalTable: "Hosts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Waiters_WaiterID",
                table: "Tables",
                column: "WaiterID",
                principalTable: "Waiters",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToGoOrders_Deliverers_DelivererID",
                table: "ToGoOrders",
                column: "DelivererID",
                principalTable: "Deliverers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToGoOrders_Hosts_HostID",
                table: "ToGoOrders",
                column: "HostID",
                principalTable: "Hosts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Waiters_Managers_ManagerID",
                table: "Waiters",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID");
        }
    }
}
