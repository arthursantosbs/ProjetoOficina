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
    public class FuncionarioRepository : IFuncionarioRepositry, IDisposable
    {
        private readonly ApplicationContext _context;
        public FuncionarioRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Funcionario> CreateAsync(Funcionario entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Funcionario entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Funcionario>> GetAllAsync()
        {
            var funcionarios = await _context.Funcionarios.ToListAsync();
            return funcionarios;
        }

        public async Task<Funcionario> GetById(int id)
        {
            var funcionario = await _context.Funcionarios.FirstOrDefaultAsync(f => f.Id == id);
            return funcionario;
        }

        public async Task<Funcionario> UpdateAsync(Funcionario entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
