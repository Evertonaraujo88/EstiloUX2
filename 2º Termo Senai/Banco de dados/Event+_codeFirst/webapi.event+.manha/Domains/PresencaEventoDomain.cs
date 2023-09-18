using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table (nameof(PresencaEventoDomain)) ]
    public class PresencaEventoDomain
    {

        [Key]
        public Guid IdPresenca { get; set; } = Guid.NewGuid();

        [Column (TypeName ="Bool")]
        [Required(ErrorMessage ="É obrigatorio confirmar presença!")]
        public bool Situacao { get; set; }

        //Refenrência a tabela Usuario = FK
        [Required(ErrorMessage ="O usuario eh obrigatorio!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public UsuarioDomain? Usuario { get; set; }

        //Ref. tabela Evento
        [Required(ErrorMessage = "É obrigatório Informar o evento!")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]
        public UsuarioDomain? Evento { get; set; }
    }


}
