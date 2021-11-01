using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Data;
using VendaDefinitiva.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendaDefinitiva.Services
{
    public class DepartmentService
    {
        private readonly VendaDefinitivaContext _context;

        public DepartmentService(VendaDefinitivaContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento> >FindAllAsync()
        {

            return await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }

    }
}
