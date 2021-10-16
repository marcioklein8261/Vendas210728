using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Data;
using VendaDefinitiva.Models;
using Microsoft.EntityFrameworkCore;
using VendaDefinitiva.Services.Exceptions;
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

        public void Insert(Vendedor obj)
        {

            _context.Add(obj);
            _context.SaveChanges();
        }

        public Vendedor EncontrarPeloId(int Id)
        {
            return _context.Vendedor.Include(obj=>obj.Departamento).FirstOrDefault(obj => obj.Id == Id);   
        }

        public void Remove(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }

        public void Atualizar(Vendedor obj)
        {
            if (!_context.Vendedor.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundExceptions("Id não encontrada!");
            }

            try { 
            _context.Update(obj);
            _context.SaveChanges();
            
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }
    }
}
