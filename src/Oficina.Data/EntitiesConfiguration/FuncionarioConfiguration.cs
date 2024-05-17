using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Infrastructure.EntitiesConfiguration;

public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
{
    public void Configure(EntityTypeBuilder<Funcionario> builder)
    {
        builder.ToTable("Funcionarios");
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Nome).HasMaxLength(100).IsRequired();
        builder.Property(f => f.Telefone).HasMaxLength(11).IsRequired();
        builder.Property(f => f.Email).HasMaxLength(255);
        builder.Property(f => f.Cargo).HasMaxLength(255);

        builder.HasOne(f => f.Endereco).WithOne(e => e.Funcionario);
    }
}
