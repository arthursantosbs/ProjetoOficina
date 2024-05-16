using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Infrastructure.Repositories
{
    public class ServicoRepository : IServicoRepository, IDisposable
    {
        public Task<Servico> CreateAsync(Servico entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Servico entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Servico>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Servico> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Servico> UpdateAsync(Servico entity)
        {
            throw new NotImplementedException();
        }
    }
}
