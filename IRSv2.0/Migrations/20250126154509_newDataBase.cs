using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IRSv2._0.Migrations
{
    /// <inheritdoc />
    public partial class newDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cooks_Managers_ManagersModelID",
                table: "Cooks");

            migrationBuilder.DropForeignKey(
                name: "FK_CooksModelOrdersModel_Cooks_CooksID",
                table: "CooksModelOrdersModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CooksModelOrdersModel_Orders_OrdersID",
                table: "CooksModelOrdersModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CooksModelToGoOrdersModel_Cooks_CooksID",
                table: "CooksModelToGoOrdersModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CooksModelToGoOrdersModel_ToGoOrders_ToGoOrdersID",
                table: "CooksModelToGoOrdersModel");

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
                name: "FK_Tables_Orders_OrderId",
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

            migrationBuilder.DropIndex(
                name: "IX_Tables_OrderId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_StorageItems_ProductsModelID",
                table: "StorageItems");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrdersModelID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ToGoOrdersModelID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_WaitersModelID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CooksModelToGoOrdersModel",
                table: "CooksModelToGoOrdersModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CooksModelOrdersModel",
                table: "CooksModelOrdersModel");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "ProductsModelID",
                table: "StorageItems");

            migrationBuilder.DropColumn(
                name: "OrdersModelID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ToGoOrdersModelID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WaitersModelID",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "CooksModelToGoOrdersModel",
                newName: "CooksToGoOrders");

            migrationBuilder.RenameTable(
                name: "CooksModelOrdersModel",
                newName: "CooksOrders");

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

            migrationBuilder.RenameIndex(
                name: "IX_CooksModelToGoOrdersModel_ToGoOrdersID",
                table: "CooksToGoOrders",
                newName: "IX_CooksToGoOrders_ToGoOrdersID");

            migrationBuilder.RenameIndex(
                name: "IX_CooksModelOrdersModel_OrdersID",
                table: "CooksOrders",
                newName: "IX_CooksOrders_OrdersID");

            migrationBuilder.AlterColumn<string>(
                name: "WaiterID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TableID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CooksToGoOrders",
                table: "CooksToGoOrders",
                columns: new[] { "CooksID", "ToGoOrdersID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CooksOrders",
                table: "CooksOrders",
                columns: new[] { "CooksID", "OrdersID" });

            migrationBuilder.CreateTable(
                name: "ProductsOrders",
                columns: table => new
                {
                    OrdersID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductsID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOrders", x => new { x.OrdersID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_ProductsOrders_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsOrders_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsToGoOrders",
                columns: table => new
                {
                    ProductsID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ToGoOrdersID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsToGoOrders", x => new { x.ProductsID, x.ToGoOrdersID });
                    table.ForeignKey(
                        name: "FK_ProductsToGoOrders_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsToGoOrders_ToGoOrders_ToGoOrdersID",
                        column: x => x.ToGoOrdersID,
                        principalTable: "ToGoOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageItemsProducts",
                columns: table => new
                {
                    ItemsID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductsID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageItemsProducts", x => new { x.ItemsID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_StorageItemsProducts_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StorageItemsProducts_StorageItems_ItemsID",
                        column: x => x.ItemsID,
                        principalTable: "StorageItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableID",
                table: "Orders",
                column: "TableID",
                unique: true,
                filter: "[TableID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WaiterID",
                table: "Orders",
                column: "WaiterID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrders_ProductsID",
                table: "ProductsOrders",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsToGoOrders_ToGoOrdersID",
                table: "ProductsToGoOrders",
                column: "ToGoOrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageItemsProducts_ProductsID",
                table: "StorageItemsProducts",
                column: "ProductsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cooks_Managers_ManagerID",
                table: "Cooks",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CooksOrders_Cooks_CooksID",
                table: "CooksOrders",
                column: "CooksID",
                principalTable: "Cooks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CooksOrders_Orders_OrdersID",
                table: "CooksOrders",
                column: "OrdersID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CooksToGoOrders_Cooks_CooksID",
                table: "CooksToGoOrders",
                column: "CooksID",
                principalTable: "Cooks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CooksToGoOrders_ToGoOrders_ToGoOrdersID",
                table: "CooksToGoOrders",
                column: "ToGoOrdersID",
                principalTable: "ToGoOrders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliverers_Managers_ManagerID",
                table: "Deliverers",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Managers_ManagerID",
                table: "Hosts",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableID",
                table: "Orders",
                column: "TableID",
                principalTable: "Tables",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Waiters_WaiterID",
                table: "Orders",
                column: "WaiterID",
                principalTable: "Waiters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Hosts_HostID",
                table: "Tables",
                column: "HostID",
                principalTable: "Hosts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Waiters_WaiterID",
                table: "Tables",
                column: "WaiterID",
                principalTable: "Waiters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToGoOrders_Deliverers_DelivererID",
                table: "ToGoOrders",
                column: "DelivererID",
                principalTable: "Deliverers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToGoOrders_Hosts_HostID",
                table: "ToGoOrders",
                column: "HostID",
                principalTable: "Hosts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Waiters_Managers_ManagerID",
                table: "Waiters",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cooks_Managers_ManagerID",
                table: "Cooks");

            migrationBuilder.DropForeignKey(
                name: "FK_CooksOrders_Cooks_CooksID",
                table: "CooksOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_CooksOrders_Orders_OrdersID",
                table: "CooksOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_CooksToGoOrders_Cooks_CooksID",
                table: "CooksToGoOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_CooksToGoOrders_ToGoOrders_ToGoOrdersID",
                table: "CooksToGoOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliverers_Managers_ManagerID",
                table: "Deliverers");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Managers_ManagerID",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Waiters_WaiterID",
                table: "Orders");

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
                name: "ProductsOrders");

            migrationBuilder.DropTable(
                name: "ProductsToGoOrders");

            migrationBuilder.DropTable(
                name: "StorageItemsProducts");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_WaiterID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CooksToGoOrders",
                table: "CooksToGoOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CooksOrders",
                table: "CooksOrders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "CooksToGoOrders",
                newName: "CooksModelToGoOrdersModel");

            migrationBuilder.RenameTable(
                name: "CooksOrders",
                newName: "CooksModelOrdersModel");

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

            migrationBuilder.RenameIndex(
                name: "IX_CooksToGoOrders_ToGoOrdersID",
                table: "CooksModelToGoOrdersModel",
                newName: "IX_CooksModelToGoOrdersModel_ToGoOrdersID");

            migrationBuilder.RenameIndex(
                name: "IX_CooksOrders_OrdersID",
                table: "CooksModelOrdersModel",
                newName: "IX_CooksModelOrdersModel_OrdersID");

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "Tables",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductsModelID",
                table: "StorageItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrdersModelID",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToGoOrdersModelID",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WaiterID",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TableID",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WaitersModelID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CooksModelToGoOrdersModel",
                table: "CooksModelToGoOrdersModel",
                columns: new[] { "CooksID", "ToGoOrdersID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CooksModelOrdersModel",
                table: "CooksModelOrdersModel",
                columns: new[] { "CooksID", "OrdersID" });

            migrationBuilder.CreateIndex(
                name: "IX_Tables_OrderId",
                table: "Tables",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageItems_ProductsModelID",
                table: "StorageItems",
                column: "ProductsModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrdersModelID",
                table: "Products",
                column: "OrdersModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ToGoOrdersModelID",
                table: "Products",
                column: "ToGoOrdersModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WaitersModelID",
                table: "Orders",
                column: "WaitersModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cooks_Managers_ManagersModelID",
                table: "Cooks",
                column: "ManagersModelID",
                principalTable: "Managers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CooksModelOrdersModel_Cooks_CooksID",
                table: "CooksModelOrdersModel",
                column: "CooksID",
                principalTable: "Cooks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CooksModelOrdersModel_Orders_OrdersID",
                table: "CooksModelOrdersModel",
                column: "OrdersID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CooksModelToGoOrdersModel_Cooks_CooksID",
                table: "CooksModelToGoOrdersModel",
                column: "CooksID",
                principalTable: "Cooks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CooksModelToGoOrdersModel_ToGoOrders_ToGoOrdersID",
                table: "CooksModelToGoOrdersModel",
                column: "ToGoOrdersID",
                principalTable: "ToGoOrders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Tables_Orders_OrderId",
                table: "Tables",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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
    }
}
