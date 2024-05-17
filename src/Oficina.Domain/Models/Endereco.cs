using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Domain.Models
{
    public class Endereco : Entity
    {        
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cep { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        /* EF Core */
        public int ClienteId { get; set; } // FK
        public int FuncionarioId { get; set; } // FK
        public Cliente? Cliente { get; set; } // Propriedade de Navegação
        public Funcionario? Funcionario { get; set; }

    }
}