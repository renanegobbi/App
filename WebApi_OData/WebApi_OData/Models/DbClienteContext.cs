using Microsoft.EntityFrameworkCore;

namespace WebApi_OData.Models
{
    public class DbClienteContext: DbContext
    {
        public DbSet<CLIENTE> Cliente { get; set; }
        public DbSet<CLIENTEPEDIDO> ClientePedido { get; set; }
        public DbSet<PEDIDO> Pedido { get; set; }
        //public DbSet<PEDIDOPRODUTO> PedidoProduto { get; set; }
        //public DbSet<PRODUTO> Produto { get; set; }

        public DbClienteContext(DbContextOptions<DbClienteContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTE>()
                .HasKey(p => p.ID);

            modelBuilder.Entity<CLIENTE>()
                .Property(p => p.NOME);

            modelBuilder.Entity<CLIENTEPEDIDO>()
                .HasKey(p => p.ID);

            modelBuilder.Entity<CLIENTEPEDIDO>()
                .Property(p => p.CLIENTE);

            modelBuilder.Entity<CLIENTEPEDIDO>()
                .Property(p => p.PEDIDO);

            modelBuilder.Entity<PEDIDO>()
                .HasKey(p => p.ID);

            modelBuilder.Entity<PEDIDO>()
                .Property(p => p.DATAPEDIDO);

            modelBuilder.Entity<PEDIDO>()
                .Property(p => p.TOTAL);

            //modelBuilder.Entity<PEDIDOPRODUTO>()
            //    .HasKey(p => p.ID);

            //modelBuilder.Entity<PEDIDOPRODUTO>()
            //    .Property(p => p.PEDIDO);

            //modelBuilder.Entity<PEDIDOPRODUTO>()
            //    .Property(p => p.PRODUTO);

            //modelBuilder.Entity<PRODUTO>()
            //    .HasKey(p => p.ID);

            //modelBuilder.Entity<PRODUTO>()
            //    .Property(p => p.NOME);

        }
    }
}
