
using Oficina.Domain.ValueObjects;

namespace Oficina.Domain.Models
{
    public class Servico : Orcamento
    {
        public Guid OrdemServico { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public StatusReparo StatusReparo { get; set; }
        public StatusFinanceiro StatusFinanceiro { get; set; }

    }
}