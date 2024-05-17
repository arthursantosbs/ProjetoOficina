using Oficina.Domain.ValueObjects;

namespace Oficina.Domain.Models
{
    public sealed class Cliente : Entity
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string? Email { get; private set; }        
        public Endereco? Endereco { get; private set; }
        public IEnumerable<Veiculo> Veiculos { get; private set; }

        public int EnderecoId { get; set; }
        public int VeiculoId {  get; set; }

        public Cliente() 
        {
            Veiculos = new List<Veiculo>();
        }    

    }
}