using Microsoft.EntityFrameworkCore;
using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Context
{
    public class EventContext : DbContext

    {

        public DbSet<TiposUsuarioDomain> TiposUsuario { get; set; }
         public DbSet<UsuarioDomain> Usuario { get; set; }
         public DbSet<TiposEventoDomain> TiposEvento { get; set; }
         public DbSet<EventoDomain> Evento { get; set; }
         public DbSet<ComentariosEventoDomain> ComentariosEventos { get; set; }
         public DbSet<InstituicaoDomain> Instituicao { get; set; }
         public DbSet<PresencasEventoDomain> PresencasEventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=NOTE01-S14; DataBase=event+_codeFisrst_manha; User Id= sa; Pwd= Senai@134; TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);

        }

    }
}
