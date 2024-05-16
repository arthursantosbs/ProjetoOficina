using Oficina.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Domain.Models
{
    public sealed class Cliente : Entity
    {
        public Nome Nome { get; private set; }
        public Telefone Telefone { get; private set; }
        public string? Email { get; private set; }        
        public Endereco? Endereco { get; private set; }

        public Cliente(Nome nome, Telefone telefone, string email, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}