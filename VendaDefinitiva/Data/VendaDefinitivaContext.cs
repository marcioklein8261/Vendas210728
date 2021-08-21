using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendaDefinitiva.Models;

namespace VendaDefinitiva.Data
{
    public class VendaDefinitivaContext : DbContext
    {
        public VendaDefinitivaContext (DbContextOptions<VendaDefinitivaContext> options)
            : base(options)
        {
        }

        public DbSet<VendaDefinitiva.Models.Departamento> Departamento { get; set; }
    }
}
