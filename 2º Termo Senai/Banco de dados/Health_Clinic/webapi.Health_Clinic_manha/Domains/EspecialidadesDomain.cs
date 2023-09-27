using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic_manha.Domains
{
    [Table (nameof(EspecialidadesDomain))]
    public class EspecialidadesDomain
    {
        [Key]
        public Guid IdEspecialidade { get; set; }

        [Column (TypeName = "VARCHAR(100)")]
        public String? NomeEspecialidade { get; set; }

    }
}
