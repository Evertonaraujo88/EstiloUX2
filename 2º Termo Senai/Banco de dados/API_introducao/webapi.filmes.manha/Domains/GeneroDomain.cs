using System.ComponentModel.DataAnnotations;

namespace webapi.filmes.manha.Domains
{

    /// <summary>
    /// CLasse que representa a entidade (tabela) Genero
    /// </summary>
    public class GeneroDomain
    {
        public int IdGenero { get; set; }

        [Required(ErrorMessage = "O nome do genero eh  obrigatorio!")]
        public string Nome { get; set; }
    }

    
}
