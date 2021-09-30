using Microsoft.EntityFrameworkCore.Migrations;

namespace VendaDefinitiva.Migrations
{
    public partial class migracao30021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroDeVendas_Vendedor_VendedorId",
                table: "RegistroDeVendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistroDeVendas",
                table: "RegistroDeVendas");

            migrationBuilder.RenameTable(
                name: "RegistroDeVendas",
                newName: "RegistroDeVenda");

            migrationBuilder.RenameIndex(
                name: "IX_RegistroDeVendas_VendedorId",
                table: "RegistroDeVenda",
                newName: "IX_RegistroDeVenda_VendedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistroDeVenda",
                table: "RegistroDeVenda",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroDeVenda_Vendedor_VendedorId",
                table: "RegistroDeVenda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroDeVenda_Vendedor_VendedorId",
                table: "RegistroDeVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistroDeVenda",
                table: "RegistroDeVenda");

            migrationBuilder.RenameTable(
                name: "RegistroDeVenda",
                newName: "RegistroDeVendas");

            migrationBuilder.RenameIndex(
                name: "IX_RegistroDeVenda_VendedorId",
                table: "RegistroDeVendas",
                newName: "IX_RegistroDeVendas_VendedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistroDeVendas",
                table: "RegistroDeVendas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroDeVendas_Vendedor_VendedorId",
                table: "RegistroDeVendas",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
