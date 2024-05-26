using Agenda.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Infra;

public class ClienteContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    
    public ClienteContext(DbContextOptions<ClienteContext> options)
        :base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity => 
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity
                .HasMany(e => e.Telefones)
                .WithOne(t => t.Cliente)
                .HasForeignKey(t => t.ClienteId);
            entity
                .HasOne(e => e.Endereco)
                .WithOne(e => e.Cliente);
            entity
                .HasMany(e => e.Documentos)
                .WithOne(t => t.Cliente)
                .HasForeignKey(t => t.ClienteId);
        });

        modelBuilder.Entity<Telefone>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });
        
        modelBuilder.Entity<DocumentoIdentificacao>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });
    }
}
