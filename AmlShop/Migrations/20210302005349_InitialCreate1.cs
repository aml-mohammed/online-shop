using Microsoft.EntityFrameworkCore.Migrations;

namespace AmlShop.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_memberRoles_members_MemberId",
                table: "memberRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_slideImages",
                table: "slideImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_members",
                table: "members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_memberRoles",
                table: "memberRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cartStatuses",
                table: "cartStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carts",
                table: "carts");

            migrationBuilder.RenameTable(
                name: "slideImages",
                newName: "slideImage");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "role");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "product");

            migrationBuilder.RenameTable(
                name: "members",
                newName: "member");

            migrationBuilder.RenameTable(
                name: "memberRoles",
                newName: "memberRole");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "category");

            migrationBuilder.RenameTable(
                name: "cartStatuses",
                newName: "cartStatus");

            migrationBuilder.RenameTable(
                name: "carts",
                newName: "cart");

            migrationBuilder.RenameIndex(
                name: "IX_memberRoles_MemberId",
                table: "memberRole",
                newName: "IX_memberRole_MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_slideImage",
                table: "slideImage",
                column: "SlideImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_role",
                table: "role",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_member",
                table: "member",
                column: "MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_memberRole",
                table: "memberRole",
                column: "MemberRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_category",
                table: "category",
                column: "CatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cartStatus",
                table: "cartStatus",
                column: "CartStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cart",
                table: "cart",
                column: "CatrtId");

            migrationBuilder.AddForeignKey(
                name: "FK_memberRole_member_MemberId",
                table: "memberRole",
                column: "MemberId",
                principalTable: "member",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_memberRole_member_MemberId",
                table: "memberRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_slideImage",
                table: "slideImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_role",
                table: "role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_memberRole",
                table: "memberRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_member",
                table: "member");

            migrationBuilder.DropPrimaryKey(
                name: "PK_category",
                table: "category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cartStatus",
                table: "cartStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cart",
                table: "cart");

            migrationBuilder.RenameTable(
                name: "slideImage",
                newName: "slideImages");

            migrationBuilder.RenameTable(
                name: "role",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "memberRole",
                newName: "memberRoles");

            migrationBuilder.RenameTable(
                name: "member",
                newName: "members");

            migrationBuilder.RenameTable(
                name: "category",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "cartStatus",
                newName: "cartStatuses");

            migrationBuilder.RenameTable(
                name: "cart",
                newName: "carts");

            migrationBuilder.RenameIndex(
                name: "IX_memberRole_MemberId",
                table: "memberRoles",
                newName: "IX_memberRoles_MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_slideImages",
                table: "slideImages",
                column: "SlideImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_memberRoles",
                table: "memberRoles",
                column: "MemberRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_members",
                table: "members",
                column: "MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "CatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cartStatuses",
                table: "cartStatuses",
                column: "CartStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carts",
                table: "carts",
                column: "CatrtId");

            migrationBuilder.AddForeignKey(
                name: "FK_memberRoles_members_MemberId",
                table: "memberRoles",
                column: "MemberId",
                principalTable: "members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
