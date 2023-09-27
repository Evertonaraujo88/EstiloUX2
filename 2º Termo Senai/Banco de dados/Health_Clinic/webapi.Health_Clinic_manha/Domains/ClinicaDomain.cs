using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace webapi.Health_Clinic_manha.Domains
{
    [Table (nameof(ClinicaDomain))]
    public class ClinicaDomain
    {

        [Key]
        public Guid IdClinica { get; set; }

        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage ="O CNPJ é obrigatório!")]
        [StringLength(14)]
        public string? CNPJ { get; set; }

        [Column (TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Obrigatório inserir a razão social da clínica.")]
        public string? RazaoSocial { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Obrigatório inserir o nome fantasia da clínica.")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage ="Endereço obrigatório.")]
        public string? Endereco { get; set; }

        [Column(TypeName ="Time")]
        [Required(ErrorMessage ="Informar o horário de abertura da Clínica.")]
        public TimeOnly HorarioAbertura { get; set; }

        [Column(TypeName = "Time")]
        [Required(ErrorMessage = "Informar o horário de fechamento da Clínica.")]
        public TimeOnly HorarioFechamento { get; set; }



    }
}
