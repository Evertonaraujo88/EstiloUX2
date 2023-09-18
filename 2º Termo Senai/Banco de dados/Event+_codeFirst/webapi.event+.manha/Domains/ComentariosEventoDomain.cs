using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table(nameof(ComentariosEventoDomain))]
    public class ComentariosEventoDomain
    {
        [Key]
        public Guid IdComentarioEvento { get; set; } = Guid.NewGuid();
    }
}
