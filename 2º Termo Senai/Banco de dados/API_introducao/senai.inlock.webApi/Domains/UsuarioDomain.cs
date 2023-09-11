using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade do banco de dados Inlock tabela Usuario
    /// </summary>
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }
        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O campo de email é obrigatorio!")]
        public string? Email { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo deve ter de 5 a 20 caracteres!")]
        [Required(ErrorMessage = "O campo senha é obrigatorio!")]
        public string? Senha { get; set; }

        //Refenrecia para a classe TiposUsuario
        public TiposUsuarioDomain TiposUsuario { get; set; }

    }
}