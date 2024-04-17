
namespace Oficina.Domain.Models
{
    public class Orcamento : Entity
    {
        public Cliente? Cliente { get; set; }
        public Funcionario? Funcionario { get; set; }
        public Veiculo? Veiculo { get; set; }
        public string? Problema { get; set; }
        public List<Pecas>? Pecas { get; set; }
        public List<MaoDeObra>? MaoDeObra { get; set; }

    }
}