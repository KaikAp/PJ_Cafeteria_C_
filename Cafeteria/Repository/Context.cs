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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //mapeamento das tabelas no sql
            modelBuilder.Entity<Categoria>(
                t =>
                {
                    t.ToTable("Categorias");
                    t.Property(t => t.Id).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
                    t.Property(t => t.Nome).HasColumnType("varchar(50)").IsRequired();
                    t.HasKey(t => t.Id);
                }
                );

            modelBuilder.Entity<Alimento>(
                t =>
                {
                    t.ToTable("Alimentos");
                    t.HasKey(t => t.Id);
                    t.Property(t => t.Id).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
                    t.Property(t => t.Descricao).HasColumnType("varchar(200)").IsRequired();
                    t.Property(t => t.Nome).HasColumnType("varchar(50)").IsRequired();
                    t.Property(t => t.Valor).HasColumnType("double").IsRequired();
                }
                );
            modelBuilder.Entity<Contato>(
                t =>
                {
                    t.ToTable("Contatos");
                    t.HasKey(t => t.Id);
                    t.Property(t => t.Id).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
                    t.Property(t => t.Email).HasColumnType("varchar(100)").IsRequired();
                    t.Property(t => t.Celular).HasColumnType("varchar(20)").IsRequired();
                }
             );

            modelBuilder.Entity<Estrutura>(
                t =>
                {
                    t.ToTable("Estruturas");
                    t.HasKey(t => t.Id);
                    t.Property(t => t.Id).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
                    t.Property(t => t.Nome).HasColumnType("varchar(100)").IsRequired();
                    t.Property(t => t.Descricao).HasColumnType("varchar(200)").IsRequired();
                }
                );
            modelBuilder.Entity<Usuario>(
                t =>
                {
                    t.ToTable("Usuarios");
                    t.HasKey(t => t.Id);
                    t.Property(t => t.Id).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
                    t.Property(t => t.Nome).HasColumnType("varchar(100)").IsRequired();
                    t.Property(t => t.Login).HasColumnType("varchar(20)").IsRequired();
                    t.Property(t => t.Senha).HasColumnType("varchar(10)").IsRequired();
                }
                );

            modelBuilder.Entity<Variacao>(
                t =>
                {
                    t.ToTable("Variacoes");
                    t.HasKey(t => t.Id);
                    t.Property(t => t.Id).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
                    t.Property(t => t.Nome).HasColumnType("varchar(100)").IsRequired();
                }
                
                
                );

        }
    }
}
