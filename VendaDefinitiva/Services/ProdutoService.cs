using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Data;
using VendaDefinitiva.Models;

namespace VendaDefinitiva.Services
{
    public class ProdutoService
    {
        private readonly VendaDefinitivaContext _context;

        public ProdutoService(VendaDefinitivaContext context)
        {
            _context = context;
        }

        public List<Produto> EncontreTodo()
        {
            return _context.Produto.ToList();
        }
    }


}
