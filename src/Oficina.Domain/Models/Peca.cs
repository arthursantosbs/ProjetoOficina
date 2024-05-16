using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Domain.Models
{
    public class Peca : Entity
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }   
        public decimal Valor { get; set; }     
        
    }
}