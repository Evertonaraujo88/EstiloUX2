using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domains
{

    [Table ("TiposUsuario")]
    public class TiposUsuarioDomain
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage ="O titulo do usuario eh obrigatorio!!! ")]
        public string? Titulo { get; set; }

        public List<UsuarioDomain>? Usuario { get; set; }

    }
}
