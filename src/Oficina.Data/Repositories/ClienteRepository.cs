using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using Oficina.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository, IDisposable
    {
        private readonly ApplicationContext _dbContext;

        public ClienteRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Cliente> CreateAsync(Cliente entity)
        {
            _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Cliente entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();            
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var clientes = await _dbContext.Clientes.ToListAsync();
            return clientes;
        }

        public async Task<Cliente> GetById(int id)
        {
            var cliente = await _dbContext.Clientes.FirstOrDefaultAsync(c => c.Id == id);
            return cliente;
        }

        public async Task<Cliente> UpdateAsync(Cliente entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }


    }
}
