using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Domain.Models
{
    public class MaoDeObra : Entity
    {
        public string? TipoServico { get; set; }
        public decimal Valor { get; set; }        
        
    }
}