using System;
using VendaDefinitiva.Data;
using VendaDefinitiva.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace VendaDefinitiva.Services
{
    public class ServicoDeRegistroDeVenda 
    {
        private readonly VendaDefinitivaContext _context;

        public ServicoDeRegistroDeVenda(VendaDefinitivaContext context)
        {
            _context = context;
        }

        


        public async Task<List<RegistroDeVenda>> EncontrarPorDataAsync(DateTime? Inicial, DateTime? Final)
        {
            var result = from obj in _context.RegistroDeVenda select obj;
            if (Inicial.HasValue)
            {
                result = result.Where(x => x.Data >= Inicial.Value);
            }
            if (Final.HasValue)
            {
                result = result.Where(x => x.Data <= Final.Value);
            }

          

            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
    

        }

        private List<T> List<T>()
        {
            throw new NotImplementedException();
        }
    }
}
