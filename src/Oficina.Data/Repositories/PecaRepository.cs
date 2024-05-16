using Oficina.Domain.Interfaces;
using Oficina.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Infrastructure.Repositories
{
    public class PecaRepository : IPecaRepository
    {
        public Task<Peca> CreateAsync(Peca entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Peca entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Peca>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Peca> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Peca> UpdateAsync(Peca entity)
        {
            throw new NotImplementedException();
        }
    }
}
