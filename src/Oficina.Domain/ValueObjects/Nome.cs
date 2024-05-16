using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Domain.ValueObjects
{
    public class Nome
    {
        private string Name;
        public Nome(string nome)
        {
            Name = nome;

            ValidaNome(nome);
        }

        public string ValidaNome( string nome)
        {
            if (nome is null) throw new Exception("O Nome precisa ser preenchido");
            if (nome.Length < 3) throw new Exception("O Nome precisa ter mais de 3 caracteres.");

            return Name;
        }

        public string CaixaAlta()
        {
            return Name.ToUpper();
        }

        public string CaixaBaixa()
        {
            return Name.ToLower();
        }
      
    }
}
