using Microsoft.EntityFrameworkCore;
using ProjetoDeVendasComCQRS.Domain;
using ProjetoDeVendasComCQRS.Domain.Entidades;

namespace ProjetoDeVendasComCQRS.Infra.Context
{
    public class MainContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        public MainContext(DbContextOptions options) : base(options)
        {
        }
        public MainContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("DefaultConnection");
            }
        }
    }
}
