using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Models;

namespace Oficina.Infrastructure.EntitiesConfiguration;

public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.ToTable("Enderecos");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Logradouro).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Numero).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Bairro).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Cep).HasMaxLength(8).IsFixedLength(true).IsRequired();
        builder.Property(e => e.Cidade).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Estado).HasMaxLength(100).IsRequired();

        
        builder.HasOne<Cliente>().WithOne(e => e.Endereco);
    }
}
