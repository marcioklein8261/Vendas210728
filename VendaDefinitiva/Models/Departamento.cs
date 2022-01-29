using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaDefinitiva.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();


        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor (Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double VendaTotalDoDepto(DateTime Inicial, DateTime Final)
        {
            return Vendedores.Sum(Vendedor => Vendedor.VendaTotal(Inicial, Final));
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
    
}
