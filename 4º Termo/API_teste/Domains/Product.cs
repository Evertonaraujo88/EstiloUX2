using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_teste.Domains
{
    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdProduct { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "O nome do produto é obrigatório!!!")]
        public string Name { get; set; }


        [Column(TypeName = "DECIMAL")]
        [Required(ErrorMessage = "O valor do produto é obrigatório!!!")]
        public decimal Price { get; set; }

    }
}
