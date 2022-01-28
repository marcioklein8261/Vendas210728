

namespace VendaDefinitiva.Models
{
    public class Produto
    {
        public int IdProduto{ get; set; }
        public int ChaveExternaProdutoDepartamento { get; set; }
        public string NomeProduto { get; set; }
        public string UnidadeProduto { get; set; }
    }
}
