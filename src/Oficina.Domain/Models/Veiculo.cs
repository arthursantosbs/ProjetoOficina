
using Oficina.Domain.ValueObjects;

namespace Oficina.Domain.Models
{
    public class Veiculo : Entity
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Ano { get; set; }
        public string? Placa { get; set; }
        public string? Cor { get; set; }
        public Categoria Categoria { get; set; }
        
        /* EF Core */
        public Cliente? Cliente { get; set; } // Propriedade de Navega��o
        public Guid ClienteId { get; set; } // FK
        
    }
}