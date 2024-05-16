using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Domain.ValueObjects
{
    public class Telefone
    {
        private string _telefone;
        public Telefone(string telefone)
        {
            _telefone = telefone;
        }

        public bool ValidaTelefone()
        {
            if (_telefone == null) return false;
            if(_telefone.Length == 0) return false;
            if(_telefone.Length != 11 ) return false;

            return true;
        }

        public string Format()
        {
            return String.Format("{0: (##) 9####-####}" ,int.Parse(_telefone));
        }

    }
}
