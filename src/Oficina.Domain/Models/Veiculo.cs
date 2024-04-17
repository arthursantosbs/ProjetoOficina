
namespace Oficina.Domain.Models
{
    public class Veiculo : Entity
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Ano { get; set; }
        public string? Placa { get; set; }
        public string? Cor { get; set; }
        public string? Categoria { get; set; }
        
        public Cliente? Cliente { get; set; }
        public Guid ClienteId { get; set; }
        
    }
}