using Microsoft.EntityFrameworkCore.Migrations;

namespace VendaDefinitiva.Migrations
{
    public partial class VendasComProdutos2901220252 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "Produto",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produto",
                newName: "IdProduto");
        }
    }
}
