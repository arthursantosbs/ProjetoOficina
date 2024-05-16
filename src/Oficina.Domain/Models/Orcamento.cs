
namespace Oficina.Domain.Models
{
    public class Orcamento : Entity
    {
        public int NumOrcamento { get; set; }
        public Cliente? Cliente { get; set; }
        public Funcionario? Funcionario { get; set; }
        public Veiculo? Veiculo { get; set; }
        public string? DescricaoProblema { get; set; }
        public List<Peca>? Pecas { get; set; }
        public List<MaoDeObra>? MaoDeObra { get; set; }
        public decimal Desconto { get; set; }
        public decimal TotalOrcamento { get; set; }

    }
}