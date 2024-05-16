using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using Oficina.Infrastructure.Context;

namespace Oficina.Infrastructure.Repositories
{
    public class ServicoRepository : IServicoRepository, IDisposable
    {
        private readonly ApplicationContext _context;
        public ServicoRepository(ApplicationContext context) 
        {
            _context = context;
        }
        public async Task<Servico> CreateAsync(Servico entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Servico entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Servico>> GetAllAsync()
        {
            var servicos = await _context.Servicos.ToListAsync();
            return servicos;
        }

        public async Task<Servico> GetById(int id)
        {
            var servico = await _context.Servicos.FirstOrDefaultAsync(s => s.Id  == id);
            return servico;
        }

        public async Task<Servico> UpdateAsync(Servico entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
