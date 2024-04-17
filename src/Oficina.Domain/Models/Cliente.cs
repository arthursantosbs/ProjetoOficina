using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Domain.Models
{
    public class Cliente : Entity
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }        
        public Endereco? Endereco { get; set; }                
        
    }
}