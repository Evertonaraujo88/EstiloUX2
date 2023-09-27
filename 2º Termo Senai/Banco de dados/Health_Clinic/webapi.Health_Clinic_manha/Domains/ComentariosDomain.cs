using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace webapi.Health_Clinic_manha.Domains
{
    [Table (nameof(ComentariosDomain))]
    public class ComentariosDomain
    {
        [Key]
        public Guid IdComentario { get; set; }

        [Column(TypeName ="TEXT")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "obrigatório informar se será exibido.")]
        public bool Exibe { get; set; }


        //ref. tabela Paciente = fk
        [Required(ErrorMessage = "Informe o paciente que passará em consulta.")]
        public Guid IdPaciente { get; set; }


        [ForeignKey(nameof(IdPaciente))]
        public PacienteDomain? Paciente { get; set; }


        //ref. tabela Consulta = fk
        [Required(ErrorMessage = "Informe a consulta que receberá o comentário.")]
        public Guid IdConsulta { get; set; }


        [ForeignKey(nameof(IdConsulta))]
        public ConsultaDomain? Consulta { get; set; }

    }
}
