using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using Oficina.Infrastructure.Context;

namespace Oficina.Infrastructure.Repositories
{
    public class PecaRepository : IPecaRepository, IDisposable
    {
        private readonly ApplicationContext _context;
        public PecaRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Peca> CreateAsync(Peca entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Peca entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Peca>> GetAllAsync()
        {
            var pecas = await _context.Pecas.ToListAsync();
            return pecas;
        }

        public async Task<Peca> GetById(int id)
        {
            var peca = await _context.Pecas.FirstOrDefaultAsync(p => p.Id == id);
            return peca;
        }

        public async Task<Peca> UpdateAsync(Peca entity)
        {
            _context.Update(entity);
            return entity;
               
        }
    }
}
