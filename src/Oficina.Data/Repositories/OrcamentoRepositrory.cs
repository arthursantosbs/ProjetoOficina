using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using Oficina.Infrastructure.Context;

namespace Oficina.Infrastructure.Repositories
{
    public class OrcamentoRepositrory : IOrcamentoRepository, IDisposable
    {
        private readonly ApplicationContext _context;
        public OrcamentoRepositrory(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Orcamento> CreateAsync(Orcamento entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Orcamento entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Orcamento>> GetAllAsync()
        {
            var orcamentos = await _context.Orcamentos.ToListAsync();
            return orcamentos;
        }

        public async Task<Orcamento> GetById(int id)
        {
            var orcamento = await _context.Orcamentos.FirstOrDefaultAsync(o => o.Id == id);
            return orcamento;
        }

        public async Task<Orcamento> UpdateAsync(Orcamento entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
