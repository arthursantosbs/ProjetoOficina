using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Models;

namespace Oficina.Infrastructure.Context;

public class ApplicationContext : DbContext
{

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<MaoDeObra> MaoDeObras { get; set; }
    

    public ApplicationContext(DbContextOptions<ApplicationContext> options ) : base( options )
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }



}
