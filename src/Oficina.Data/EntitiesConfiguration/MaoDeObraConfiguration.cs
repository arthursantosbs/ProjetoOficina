using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Infrastructure.EntitiesConfiguration;

public class MaoDeObraConfiguration : IEntityTypeConfiguration<MaoDeObra>
{
    public void Configure(EntityTypeBuilder<MaoDeObra> builder)
    {
        builder.ToTable("MaoDeObras");
        builder.HasKey(x => x.Id);

        builder.Property(m => m.Codigo).HasColumnType("int");
        builder.Property(m => m.TipoServico).HasMaxLength(200);
        builder.Property(m => m.Valor).HasPrecision(10, 2).IsRequired();

        builder.HasOne(m => m.Servico).WithMany(s => s.MaoDeObra).HasForeignKey(m => m.ServicoId);

    }
}
