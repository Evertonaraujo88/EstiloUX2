using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domains
{
    //informa que estudio sera uma tabela
    [ Table ("Estudio")]
    public class EstudioDomain
    {
        [Key]
        public Guid IdEstudio { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do estudio eh obrigatorio!!")]
        public string? Nome { get; set; }

        public List<JogoDomain>? Jogo { get; set; }

    }
}
