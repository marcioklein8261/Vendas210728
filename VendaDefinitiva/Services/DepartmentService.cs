using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Data;
using VendaDefinitiva.Models;

namespace VendaDefinitiva.Services
{
    public class DepartmentService
    {
        private readonly VendaDefinitivaContext _context;

        public DepartmentService(VendaDefinitivaContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {

            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }

    }
}
