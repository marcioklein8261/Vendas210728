using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Data;
using VendaDefinitiva.Models;
using Microsoft.EntityFrameworkCore;
using VendaDefinitiva.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
namespace VendaDefinitiva.Services

{
    public class VendedorServico
    {

        private readonly VendaDefinitivaContext _context;

        public VendedorServico(VendaDefinitivaContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Vendedor obj)
        {

            _context.Add(obj);
           await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> EncontrarPeloIdAsync(int Id)
        {
            return await _context.Vendedor.Include(obj=>obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == Id);   
        }

        public async Task RemoveAsync(int id)
        {
            var obj =await _context.Vendedor.FindAsync(id);
            _context.Vendedor.Remove(obj);
           await  _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Vendedor obj)
        {
            bool temAlguma = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!temAlguma)
            {
                throw new NotFoundExceptions("Id não encontrada!");
            }

            try { 
            _context.Update(obj);
           await _context.SaveChangesAsync();
            
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }




    }
}
