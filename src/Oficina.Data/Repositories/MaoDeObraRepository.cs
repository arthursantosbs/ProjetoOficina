using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using Oficina.Infrastructure.Context;

namespace Oficina.Infrastructure.Repositories
{
    public class MaoDeObraRepository : IMaoDeObraRepository, IDisposable
    {
        private readonly ApplicationContext _context;
        public MaoDeObraRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<MaoDeObra> CreateAsync(MaoDeObra entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(MaoDeObra entity)
        {
             _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<MaoDeObra>> GetAllAsync()
        {
            var maoDeObras = await _context.MaoDeObras.ToListAsync();
            return maoDeObras;
        }

        public async Task<MaoDeObra> GetById(int id)
        {
            var maoDeObra = await _context.MaoDeObras.FirstOrDefaultAsync(x => x.Id == id);
            return maoDeObra;
        }

        public async Task<MaoDeObra> UpdateAsync(MaoDeObra entity)
        {
             _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
