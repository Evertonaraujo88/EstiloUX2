using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace webapi.filmes.manha.Domains
{
    public class FilmeDomain
    {
        public int IdFilme { get; set; }

        public int IdGenero { get; set; }


        public string Titulo { get; set; }
        [Required(ErrorMessage ="O titulo do filme eh obrigatorio!")]



        //referencia para a classe genero
        public GeneroDomain Genero { get; set; }
    }
}
