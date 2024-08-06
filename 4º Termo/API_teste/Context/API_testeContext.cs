using API_teste.Domains;
using Microsoft.EntityFrameworkCore;

namespace API_teste.Context
{
    public class API_testeContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=NOTE01-SALA19; DataBase=API_teste; User Id= sa; Pwd= Senai@134; TrustServerCertificate=true;");

            base.OnConfiguring(optionsBuilder);

        }

    }

   
}
