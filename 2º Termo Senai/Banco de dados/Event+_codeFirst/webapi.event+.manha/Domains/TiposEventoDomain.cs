using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table (nameof(TiposEventoDomain))]
    public class TiposEventoDomain
    {

        [Key]
        public Guid IdTiposEvento { get; set; } = Guid.NewGuid();

        [Column (TypeName = "VARCHAR(100)")]
        [Required (ErrorMessage ="Titullo do evento obrigamtorio!!") ]
        public string? Titulo { get; set; }

    }
}
