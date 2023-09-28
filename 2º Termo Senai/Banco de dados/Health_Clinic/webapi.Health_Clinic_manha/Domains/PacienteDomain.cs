using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic_manha.Domains
{
    [Table(nameof(PacienteDomain))]
    //especifica que o campo CPF eh unico e nao pode ter outro igual
    [Index(nameof(CPF), IsUnique = true)]
    public class PacienteDomain
    {

        [Key] public Guid IdPaciente { get; set; }

        [Column(TypeName ="VARCHAR(200)")]
        [Required(ErrorMessage ="O nome do paciente é obrigatório.")]
        public string? NomePaciente { get; set; }

        [Column(TypeName ="CHAR(11)")]
        [Required(ErrorMessage ="O CPF do paciente é obrigatório.")]
        [StringLength(11)]
        public string? CPF { get; set; }

        [Column(TypeName ="DATE")]
        [Required(ErrorMessage ="Informar a data de nascimento.")]
        public DateTime DataNascimento { get; set; }

        [Column(TypeName ="CHAR(11)")]
        [Required(ErrorMessage ="Informar o telefone do paciente com DDD. ")]
        public string? Telefone { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Endereço obrigatório.")]
        public string? Endereco { get; set; }

        //ref. tabela Usuario = fk
        [Required(ErrorMessage = "Informe o Usuario.")]
        public Guid IdUsuario { get; set; }


        [ForeignKey(nameof(IdUsuario))]
        public UsuarioDomain? Usuario { get; set; }
    }
}
