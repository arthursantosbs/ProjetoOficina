using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Infrastructure.Repositories
{
    public class OrcamentoRepositrory : IOrcamentoRepository
    {
        public Task<Orcamento> CreateAsync(Orcamento entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Orcamento entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Orcamento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Orcamento> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Orcamento> UpdateAsync(Orcamento entity)
        {
            throw new NotImplementedException();
        }
    }
}
