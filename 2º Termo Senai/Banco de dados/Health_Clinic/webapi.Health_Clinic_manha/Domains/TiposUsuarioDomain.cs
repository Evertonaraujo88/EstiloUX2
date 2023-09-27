using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace webapi.Health_Clinic_manha.Domains
{
    
    [Table (nameof(TiposUsuarioDomain))]
    public class TiposUsuarioDomain
    {
        [Key]
        public Guid IdTipoUsuario { get; set; }

        [Column (TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O tipo de usuario é obrigatório")]
        public string? Titulo { get; set; }


    }
}
