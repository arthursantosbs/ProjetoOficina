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
        throw new NotImplementedException();
    }
}
