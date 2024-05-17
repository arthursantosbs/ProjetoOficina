using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Infrastructure.EntitiesConfiguration;

public class PecaConfiguration : IEntityTypeConfiguration<Peca>
{
    public void Configure(EntityTypeBuilder<Peca> builder)
    {
        builder.ToTable("Pecas");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Codigo).HasColumnType("int");
        builder.Property(p => p.Nome).HasMaxLength(200).IsRequired();
        builder.Property(p => p.Quantidade).HasColumnType("int").HasDefaultValue(1);
        builder.Property(p => p.Valor).HasPrecision(10,2).IsRequired();

        builder.HasOne(p => p.Servico).WithMany(s => s.Pecas).HasForeignKey(s => s.ServicoId);
    }
}
