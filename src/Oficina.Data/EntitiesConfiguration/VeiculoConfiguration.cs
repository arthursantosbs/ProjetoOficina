using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Models;

namespace Oficina.Infrastructure.EntitiesConfiguration
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculos");
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Marca).HasMaxLength(200).IsRequired();
            builder.Property(v => v.Modelo).HasMaxLength(200).IsRequired();
            builder.Property(v => v.Placa).HasMaxLength(8).IsRequired();
            builder.Property(v => v.Ano).HasMaxLength(9).IsRequired();
            builder.Property(v => v.Cor).HasMaxLength(50);
            builder.Property(v => v.Categoria).HasConversion<string>();

            builder.HasOne(v => v.Cliente).WithMany(c => c.Veiculos).HasForeignKey(c => c.ClienteId);
            
        }
    }
}
