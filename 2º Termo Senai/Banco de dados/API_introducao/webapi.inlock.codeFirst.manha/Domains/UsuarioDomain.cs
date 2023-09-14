using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)] //Cria um índice único para
    public class UsuarioDomain
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email eh obrigatorio!!!!")]
        public String? Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha Obrigatoria")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "A senha deve ter de 6 a 20 caracteres.")]
        public string? Senha { get; set; }


        //Referencia da chave estrangeira (tabela de TiposUsuario)

        [Required(ErrorMessage = "Informe o tipo de Usuario")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuarioDomain? TipoUsuario { get; set; }
    }
}
