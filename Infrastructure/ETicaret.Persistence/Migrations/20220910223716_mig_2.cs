using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAPI.Persistence.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Products",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Products",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Orders",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Orders",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Files",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Customers",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Customers",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Baskets",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Baskets",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "BasketItems",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "BasketItems",
                newName: "CreatedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Products",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Products",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Orders",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Orders",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Files",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Customers",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Customers",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Baskets",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Baskets",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "BasketItems",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "BasketItems",
                newName: "CreateDate");
        }
    }
}
