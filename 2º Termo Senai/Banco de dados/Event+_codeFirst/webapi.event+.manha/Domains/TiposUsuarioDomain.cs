using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table(nameof(TiposUsuarioDomain))]

    public class TiposUsuarioDomain
    {

        [Key]
        public Guid IdTiposUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="O Nome do Usuario eh obrigatorio!!")]
        public string? Titulo { get; set; }

    }
}
