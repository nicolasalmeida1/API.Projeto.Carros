using Microsoft.EntityFrameworkCore;
using Projeto.Avanade.Domain;
using Pomelo.EntityFrameworkCore.MySql;

namespace Projeto.Avanade.Repositorio
{
    //ADO.NET
    //Dapper
    //EF
    public class CarroContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>()
                .HasKey(p => p.Id);
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=localhost;Database=avanade;Uid=root;Pwd=Mysql2022@;";
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
