using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Infrastructure.Repositories
{
    public class VeiculoRepository : IVeiculoRepository, IDisposable
    {
        public Task<Veiculo> CreateAsync(Veiculo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Veiculo entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Veiculo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Veiculo> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Veiculo> UpdateAsync(Veiculo entity)
        {
            throw new NotImplementedException();
        }
    }
}
