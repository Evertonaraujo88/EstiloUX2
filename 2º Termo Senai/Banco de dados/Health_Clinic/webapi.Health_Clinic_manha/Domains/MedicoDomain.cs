using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace webapi.Health_Clinic_manha.Domains
{
    [Table (nameof(MedicoDomain))]
    //especifica que o campo CRM eh unico e nao pode ter outro igual
    [Index(nameof(CRM), IsUnique = true)]
    public class MedicoDomain
    {
        [Key]
        public Guid IdMedico { get; set; }

        [Column (TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="O nome do médico é obrigatório.")]
        public string? NomeMedico { get; set; }

        [Column(TypeName = "CHAR(6)")]
        [Required(ErrorMessage = "Obrigatório informar o CRM do médico.")]
        [StringLength(6)]
        public string? CRM { get; set; }

        //ref. tabela Usuario = fk
        [Required(ErrorMessage = "Informe o Usuario.")]
        public Guid IdUsuario { get; set; }


        [ForeignKey(nameof(IdUsuario))]
        public UsuarioDomain? Usuario { get; set; }


        //ref. tabela Clinica = fk
        [Required(ErrorMessage ="Informar a Clinica que o médico será cadastrado.")]
        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public ClinicaDomain? Clinica { get; set; }


        //ref. tabela Especialidades = fk
        [Required(ErrorMessage ="Obrigatório informar a especialidade do médico.")]
        public Guid IdEspecialidade { get; set; }

        [ForeignKey(nameof(IdEspecialidade))]
        public EspecialidadesDomain? Especialidades { get; set; }


    }
}
