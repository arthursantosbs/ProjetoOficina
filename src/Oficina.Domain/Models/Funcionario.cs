
namespace Oficina.Domain.Models
{
    public class Funcionario : Entity
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }        
        public Endereco? Endereco { get; set; } 
        public string? Cargo { get; set; }      
        
        public int EnderecoId { get; set; }
               
    }
}