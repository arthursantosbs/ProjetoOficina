using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Domain.Models
{
    public class Estoque : Entity
    {
        public List<Pecas>? Pecas { get; set; }

    }
}