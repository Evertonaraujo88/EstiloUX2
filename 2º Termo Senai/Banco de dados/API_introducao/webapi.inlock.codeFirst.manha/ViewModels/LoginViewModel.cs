using System.ComponentModel.DataAnnotations;

namespace webapi.inlock.codeFirst.manha.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email Obrigatorio!!!")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Senha obrigatoria!!!")]
        public string? Senha { get; set; }


    }
}
