using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table(nameof(ComentariosEventoDomain))]
    public class ComentariosEventoDomain
    {
        [Key]
        public Guid IdComentarioEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "Text")]
        [Required(ErrorMessage ="A descricao eh obrigatoria!")]
        public string? Descricao { get; set; }

        [Column(TypeName ="BIT")]
        [Required(ErrorMessage ="A informação de exibição é obrigatória.")]
        public bool Exibe { get; set; }


        //Refenrência a tabela Usuario = FK
        [Required(ErrorMessage = "O usuario é obrigatorio!")]
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
