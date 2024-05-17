using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Domain.Models
{
    public class Estoque : Entity
    {
        public IEnumerable<Peca>? Pecas { get; set; }
        public IEnumerable<MaoDeObra>? MaoDeObras { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}