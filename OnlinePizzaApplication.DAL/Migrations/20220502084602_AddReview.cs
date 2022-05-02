using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePizzaApplication.DAL.Migrations
{
    public partial class AddReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "user",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "user",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "Pizza_Id1",
                table: "toppings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId1",
                table: "orderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pizza_Id1",
                table: "orderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pizza_Id1",
                table: "cartItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_reviews_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_toppings_Pizza_Id1",
                table: "toppings",
                column: "Pizza_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_payment_CartId",
                table: "payment",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_PaymentId",
                table: "orders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_orderItem_OrderId1",
                table: "orderItem",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_orderItem_Pizza_Id1",
                table: "orderItem",
                column: "Pizza_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_orderItem_ToppingsId",
                table: "orderItem",
                column: "ToppingsId");

            migrationBuilder.CreateIndex(
                name: "IX_carts_UserId",
                table: "carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_cartItem_CartId",
                table: "cartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_cartItem_Pizza_Id1",
                table: "cartItem",
                column: "Pizza_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_cartItem_ToppingsId",
                table: "cartItem",
                column: "ToppingsId");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_UserId",
                table: "reviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_cartItem_carts_CartId",
                table: "cartItem",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cartItem_pizza_Pizza_Id1",
                table: "cartItem",
                column: "Pizza_Id1",
                principalTable: "pizza",
                principalColumn: "Pizza_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cartItem_toppings_ToppingsId",
                table: "cartItem",
                column: "ToppingsId",
                principalTable: "toppings",
                principalColumn: "ToppingsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_carts_user_UserId",
                table: "carts",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderItem_orders_OrderId1",
                table: "orderItem",
                column: "OrderId1",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_orderItem_pizza_Pizza_Id1",
                table: "orderItem",
                column: "Pizza_Id1",
                principalTable: "pizza",
                principalColumn: "Pizza_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_orderItem_toppings_ToppingsId",
                table: "orderItem",
                column: "ToppingsId",
                principalTable: "toppings",
                principalColumn: "ToppingsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_payment_PaymentId",
                table: "orders",
                column: "PaymentId",
                principalTable: "payment",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_user_UserId",
                table: "orders",
                column: "UserId",
                principalTable: "user",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payment_carts_CartId",
                table: "payment",
                column: "CartId",
                principalTable: "carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_toppings_pizza_Pizza_Id1",
                table: "toppings",
                column: "Pizza_Id1",
                principalTable: "pizza",
                principalColumn: "Pizza_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartItem_carts_CartId",
                table: "cartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_cartItem_pizza_Pizza_Id1",
                table: "cartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_cartItem_toppings_ToppingsId",
                table: "cartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_user_UserId",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_orderItem_orders_OrderId1",
                table: "orderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_orderItem_pizza_Pizza_Id1",
                table: "orderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_orderItem_toppings_ToppingsId",
                table: "orderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_payment_PaymentId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_user_UserId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_payment_carts_CartId",
                table: "payment");

            migrationBuilder.DropForeignKey(
                name: "FK_toppings_pizza_Pizza_Id1",
                table: "toppings");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropIndex(
                name: "IX_toppings_Pizza_Id1",
                table: "toppings");

            migrationBuilder.DropIndex(
                name: "IX_payment_CartId",
                table: "payment");

            migrationBuilder.DropIndex(
                name: "IX_orders_PaymentId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_UserId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orderItem_OrderId1",
                table: "orderItem");

            migrationBuilder.DropIndex(
                name: "IX_orderItem_Pizza_Id1",
                table: "orderItem");

            migrationBuilder.DropIndex(
                name: "IX_orderItem_ToppingsId",
                table: "orderItem");

            migrationBuilder.DropIndex(
                name: "IX_carts_UserId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_cartItem_CartId",
                table: "cartItem");

            migrationBuilder.DropIndex(
                name: "IX_cartItem_Pizza_Id1",
                table: "cartItem");

            migrationBuilder.DropIndex(
                name: "IX_cartItem_ToppingsId",
                table: "cartItem");

            migrationBuilder.DropColumn(
                name: "Pizza_Id1",
                table: "toppings");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "orderItem");

            migrationBuilder.DropColumn(
                name: "Pizza_Id1",
                table: "orderItem");

            migrationBuilder.DropColumn(
                name: "Pizza_Id1",
                table: "cartItem");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "user",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "user",
                newName: "email");
        }
    }
}
