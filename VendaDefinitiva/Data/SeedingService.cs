using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Models;
using VendaDefinitiva.Models.Enums;
namespace VendaDefinitiva.Data
{
    public class SeedingService
    {
        private VendaDefinitivaContext _context;
        public SeedingService(VendaDefinitivaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any()||
                _context.Vendedor.Any()||
                _context.RegistroDeVenda.Any()||
                _context.Produto.Any())
            {
                return; //O banco de dados já foi populado
            }

            Departamento d1 = new Departamento(1,"Informátcia");
            Departamento d2 = new Departamento(2, "Modas");
            Departamento d3 = new Departamento(3, "Livraria");

            Vendedor v1 = new Vendedor(1, "Marcio Klein", "eu@gmail",new DateTime(1954, 11, 03), 20001.00, d1);
            Vendedor v2 = new Vendedor(2, "Roberto Klein", "Roberto@gmail", new DateTime(1988, 11, 03), 20002.00, d2);
            Vendedor v3 = new Vendedor(3, "André Klein", "De@gmail", new DateTime(1985, 11, 03), 200103.00, d3);
            Vendedor v4 = new Vendedor(4, "Davi Klein", "nene@gmail", new DateTime(2019, 11, 03), 20004.00, d1);
            Vendedor v5 = new Vendedor(5, "Marcio Klein", "eu@gmail", new DateTime(1954, 11, 03), 20005.00, d1);

            RegistroDeVenda r1 = new RegistroDeVenda(1, new DateTime(2018, 09, 25), 11000, StatusDaVenda.Faturado, v1);
        
        RegistroDeVenda r2 = new RegistroDeVenda(2, new DateTime(2018, 06, 06), 5000.0, StatusDaVenda.Faturado, v2);
            RegistroDeVenda r3 = new RegistroDeVenda(12, new DateTime(2016, 01, 29), 1000.0, StatusDaVenda.Faturado, v3);
            RegistroDeVenda r12 = new RegistroDeVenda(3, new DateTime(2019, 11, 06), 1200.0, StatusDaVenda.Faturado, v2);
            RegistroDeVenda r4 = new RegistroDeVenda(4, new DateTime(2020, 06, 06), 19900.0, StatusDaVenda.Faturado, v3);
            RegistroDeVenda r5 = new RegistroDeVenda(5, new DateTime(2020, 01, 22), 17799.0, StatusDaVenda.Faturado, v4);
            RegistroDeVenda r6 = new RegistroDeVenda(6, new DateTime(2020, 04, 07), 50.0, StatusDaVenda.Faturado, v5);
            RegistroDeVenda r7 = new RegistroDeVenda(7, new DateTime(2020, 06, 05), 5190.0, StatusDaVenda.Faturado, v5);
            RegistroDeVenda r8 = new RegistroDeVenda(8, new DateTime(2021, 01, 31), 890.0, StatusDaVenda.Faturado, v1);
            RegistroDeVenda r9 = new RegistroDeVenda(9, new DateTime(2021, 04, 06), 12789.0, StatusDaVenda.Faturado, v5);
            RegistroDeVenda r10 = new RegistroDeVenda(10, new DateTime(2021, 04, 06), 115000.0, StatusDaVenda.Faturado, v3);
            RegistroDeVenda r11 = new RegistroDeVenda(11, new DateTime(2021, 04, 07), 5789.0, StatusDaVenda.Faturado, v1);

            Produto p1 = new Produto(1, "Computador", "peça", d1);
            Produto p2 = new Produto(2, "Mouse", "peça", d1);
            Produto p3 = new Produto(3, "Havaiana", "par", d2);
            Produto p4 = new Produto(4, "1984", "volume", d3);

            _context.Departamento.AddRange(d1, d2, d3);
            _context.Vendedor.AddRange(v1, v2, v3, v4, v5);
            _context.RegistroDeVenda.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12);
            _context.Produto.AddRange(p1, p2, p3, p4);

            _context.SaveChanges();

        }
    }
}
