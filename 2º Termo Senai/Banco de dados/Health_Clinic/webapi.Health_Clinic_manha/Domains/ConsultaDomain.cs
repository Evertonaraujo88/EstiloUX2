using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic_manha.Domains
{

    [Table(nameof(ConsultaDomain))]
    public class ConsultaDomain
    {
        [Key]
        public Guid IdConsulta { get; set; }

        [Column(TypeName ="DATE")]
        [Required(ErrorMessage ="Informe a data da Consulta.")]
        public DateTime DataConsulta { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage ="Informar o horário da Consulta.")]
        public TimeOnly HoraConsulta { get; set; }

        [Column(TypeName ="TEXT")]
        [Required(ErrorMessage ="Obrigatório descrever o atendimento da consulta do paciente.")]
        public string? Prontuario { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage ="Confirmar a consulta.")]
        public bool Confirmacao { get; set; }


        //ref. tabela Paciente = fk
        [Required(ErrorMessage = "Informe o paciente que passará em consulta.")]
        public Guid IdPaciente { get; set; }


        [ForeignKey(nameof(IdPaciente))]
        public PacienteDomain? Paciente { get; set; }



        //ref. tabela Medico = fk
        [Required(ErrorMessage = "Informe o médico que atenderá essa consulta.")]
        public Guid IdMedico { get; set; }


        [ForeignKey(nameof(IdMedico))]
        public MedicoDomain? Medico { get; set; }
    }
}
