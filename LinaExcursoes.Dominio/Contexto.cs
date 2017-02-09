using LinaExcursoes.Dominio.Tables;
using System.Data.Entity;

namespace LinaExcursoes.Dominio
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
            Database.SetInitializer<Contexto>(null);
        }

        public DbSet<Parametro> Parametro { get; set; }

        public DbSet<Viagem> Viagem { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Carousel> Carousel { get; set; }

        public DbSet<Imagem> Imagem { get; set; }

        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}