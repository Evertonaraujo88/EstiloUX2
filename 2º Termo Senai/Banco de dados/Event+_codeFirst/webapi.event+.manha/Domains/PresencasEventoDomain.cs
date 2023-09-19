using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table (nameof(PresencasEventoDomain)) ]
    public class PresencasEventoDomain
    {

        [Key]
        public Guid IdPresencaEvento { get; set; } = Guid.NewGuid();

        [Column (TypeName ="BIT")]
        [Required(ErrorMessage ="É obrigatorio confirmar ou não a presença!")]
        public bool Situacao { get; set; }

        //Refenrência a tabela Usuario = FK
        [Required(ErrorMessage ="O usuario é obrigatorio!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public UsuarioDomain? Usuario { get; set; }

        //Ref. tabela Evento = Fk
        [Required(ErrorMessage = "É obrigatório Informar o evento!")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]
        public EventoDomain? Evento { get; set; }
    }


}
