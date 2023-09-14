using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace webapi.inlock.codeFirst.manha.Domains
{
    /// <summary>
    /// Classe que representa a entidade Jogo
    /// </summary>
    [Table("Jogo")]
    public class JogoDomain
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="O nome do JOgo eh obrigatorio!!!")]
        public String? Nome { get; set; }


        [Column(TypeName = "Text")]
        [Required (ErrorMessage = "A descricao do jogo eh obrigatorio")]
        public String? Descricao { get; set; }

        [Column(TypeName ="DATE")]
        [Required (ErrorMessage = "A data do lancamento do jogo eh obrigatorio")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "Decimal(4,2)")]
        [Required(ErrorMessage = "O preco do jogo eh obrigatorio")]
        public Decimal Preco { get; set; }



        //Referencia da chave estrangeira (tabela de Estudio)

        [Required(ErrorMessage = "Informe o estudio que produziu o jogo")]
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public EstudioDomain? Estudio { get; set; }
    }
}
