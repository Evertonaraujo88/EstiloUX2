using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Context
{
    public class HealthContext : DbContext
    {

        public DbSet<ClinicaDomain> Clinica { get; set; }
        public DbSet<ComentariosDomain> Comentarios { get; set; }
        public DbSet<ConsultaDomain> Consulta { get; set; }
        public DbSet<EspecialidadesDomain> Especialidades { get; set; }
        public DbSet<MedicoDomain> Medico { get; set; }
        public DbSet<PacienteDomain> Paciente { get; set; }
        public DbSet<TiposUsuarioDomain> TiposUsuario { get; set; }
        public DbSet<UsuarioDomain> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer("Server=NOTE01-S14; DataBase=HealthClinic_codeFisrst_manha; User Id= sa; Pwd= Senai@134; TrustServerCertificate=true", x => x.UseDateOnlyTimeOnly());
            optionsBuilder.UseSqlServer("Server=DESKTOP-T9B12O6; DataBase=HealthClinic_codeFisrst_manha; User Id= sa; Pwd= Info@134; TrustServerCertificate=true", x => x.UseDateOnlyTimeOnly());

            base.OnConfiguring(optionsBuilder);

        }



    }
}
