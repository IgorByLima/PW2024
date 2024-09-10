using EtecWebAPI.Configurations;
using EtecWebAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace EtecWebAPI.Context
{
    public class EtecContext : DbContext
    {
        public DbSet<Curso> CursoSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //const string conexao
            //    = "server=localhost;database=etec;port=3306;uid=root";

            const string conexao
                  = "server=mysql.tccnapratica.com.br;database=tccnapratica08;port=3306;uid=tccnapratica08;password=Etec2024";

            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
