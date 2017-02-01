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

        public DbSet<Parametros> Parametros { get; set; }

        public DbSet<Viagens> Viagens { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}