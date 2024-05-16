using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using Oficina.Infrastructure.Context;

namespace Oficina.Infrastructure.Repositories
{
    public class VeiculoRepository : IVeiculoRepository, IDisposable
    {
        private readonly ApplicationContext _context;
        public VeiculoRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Veiculo> CreateAsync(Veiculo entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Veiculo entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Veiculo>> GetAllAsync()
        {
            var veiculos = await _context.Veiculos.ToListAsync();
            return veiculos;
        }

        public async Task<Veiculo> GetById(int id)
        {
            var veiculo = await _context.Veiculos.FirstOrDefaultAsync(s => s.Id == id);
            return veiculo;
        }

        public async Task<Veiculo> UpdateAsync(Veiculo entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
