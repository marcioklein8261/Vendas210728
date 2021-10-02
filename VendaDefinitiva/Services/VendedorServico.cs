using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Data;
using VendaDefinitiva.Models;

namespace VendaDefinitiva.Services
{
    public class VendedorServico
    {

        private readonly VendaDefinitivaContext _context;

        public VendedorServico(VendaDefinitivaContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}
