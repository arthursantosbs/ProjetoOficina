using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using Oficina.Infrastructure.Context;

namespace Oficina.Infrastructure.Repositories
{
    public class EnderecoRepository : IEnderecoRepository, IDisposable
    {
        private readonly ApplicationContext _dbContext;
        public EnderecoRepository(ApplicationContext context)
        {
            _dbContext = context;
        }

        public async Task<Endereco> CreateAsync(Endereco entity)
        {
            await _dbContext.AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(Endereco entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

        public async Task<IEnumerable<Endereco>> GetAllAsync()
        {
            var enderecos =  await _dbContext.Enderecos.ToListAsync();
            return enderecos;
        }

        public async Task<Endereco> GetById(int id)
        {
            var endereco = await _dbContext.Enderecos.FirstOrDefaultAsync(e => e.Id == id);
            return endereco;
        }

        public async Task<Endereco> UpdateAsync(Endereco entity)
        {
             _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
