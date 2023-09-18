using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table (nameof(EventoDomain))]
    public class EventoDomain
    {

        [Key]
        public Guid IdEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName ="Date")]
        [Required(ErrorMessage ="A data eh obrigatoria!!!")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do evento eh obrigatorio")]
        public string? NomeEvento { get; set; }

        [Column (TypeName = "text")]
        [Required(ErrorMessage = "A descricao do evento eh obrigatoria")]
        public string? Descricao { get; set; }



        //ref. tabela TiposEvento = FK
        [Required(ErrorMessage ="O tipo do evento eh obrigatorio!!!")]
        public Guid? IdTipoEvento { get; set; }

        [ForeignKey(nameof(IdTipoEvento))]
        public TiposEventoDomain? TiposEvento { get; set; }



        //ref. tabela Instituicao
        [Required(ErrorMessage ="Instituicao eh obrigatoria")]
        public Guid IdIntituicao { get; set; }

        [ForeignKey(nameof(IdIntituicao))]
        public InstituicaoDomain? Instituicao { get; set; }
    }
}
