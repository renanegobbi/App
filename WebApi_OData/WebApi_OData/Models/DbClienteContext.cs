using Microsoft.EntityFrameworkCore;

namespace WebApi_OData.Models
{
    public class DbClienteContext: DbContext
    {
        public DbSet<CLIENTE> Cliente { get; set; }
        public DbSet<PEDIDO> Pedido { get; set; }
        public DbSet<PRODUTO> Produto { get; set; }

        public DbClienteContext(DbContextOptions<DbClienteContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTE>()
                .HasKey(p => p.ID);

            modelBuilder.Entity<CLIENTE>()
                .Property(p => p.NOME);

            modelBuilder.Entity<PEDIDO>()
                .HasKey(p => p.ID);

            modelBuilder.Entity<PEDIDO>()
                .Property(p => p.DATAPEDIDO);

            modelBuilder.Entity<PEDIDO>()
                .Property(p => p.TOTAL);

            modelBuilder.Entity<PRODUTO>()
                .HasKey(p => p.ID);

            modelBuilder.Entity<PRODUTO>()
                .Property(p => p.NOME);

        }
    }
}
