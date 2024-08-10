using Business;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options) {}

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Estrutura> Estruturas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Alimento> Alimentos  { get; set; }

        public DbSet<Variacao> Variacaos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
