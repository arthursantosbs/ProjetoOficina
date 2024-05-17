
using Oficina.Domain.ValueObjects;

namespace Oficina.Domain.Models
{
    public class Servico : Entity
    {
        public int NumeroOrcamento { get; set; }
        public Cliente? Cliente { get; set; }
        public Funcionario? Funcionario { get; set; }
        public Veiculo? Veiculo { get; set; }
        public string? DescricaoProblema { get; set; }
        public List<Peca>? Pecas { get; set; }
        public List<MaoDeObra>? MaoDeObra { get; set; }
        public decimal Desconto { get; set; }
        public decimal TotalOrcamento { get; set; }
        public bool OrcamentoAprovado { get; set; }
        public int NumeroOrdemServico { get; set; }
        public DateTime InicioServico { get; set; }
        public DateTime FimServico { get; set; }
        public StatusReparo StatusReparo { get; set; }
        public StatusFinanceiro StatusFinanceiro { get; set; }

        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public int VeiculoId { get; set; }


    }
}