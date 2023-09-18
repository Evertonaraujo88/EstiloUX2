using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace webapi.event_.manha.Domains
{

    [Table (nameof(InstituicaoDomain))]
    [Index(nameof(CNPJ), IsUnique = true)]

    public class InstituicaoDomain
    {
        [Key]
        public Guid IdInstituicao { get; set; } = Guid.NewGuid();


        [Column (TypeName = "CHAR(14)")]
        [Required (ErrorMessage = "O CNPJ eh obrigatorio!!!!")]
        [StringLength(14)]
        public string? CNPJ { get; set; }

        [Column (TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage ="O Endereco eh obrigatorio!!")]
        public string? Endereco { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome Fantasia eh obrigatorio!!")]
        public string? NomeFantasia { get; set; }

    }
}
