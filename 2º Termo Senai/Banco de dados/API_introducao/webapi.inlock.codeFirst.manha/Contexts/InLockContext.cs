using Microsoft.EntityFrameworkCore;
using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Contexts
{
    public class InLockContext : DbContext
    {

        //Define as entidades do  banco de dados

        public DbSet<EstudioDomain> Estudio { get; set; }

        public DbSet<JogoDomain> Jogo { get; set; }

        public DbSet<TiposUsuarioDomain> TiposUsuario { get; set; }

        public DbSet<UsuarioDomain> Usuario { get; set; }

        /// <summary>
        /// Define as opções de construção do banco(String de Conexão)
        /// </summary>
        /// <param name="optionsBuilder">Objeto com as configurações definidas</param>        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=NOTE01-S14; DataBase=inlock_games_codeFisrst_manha; User Id= sa; Pwd= Senai@134; TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);

        }
    }
}
