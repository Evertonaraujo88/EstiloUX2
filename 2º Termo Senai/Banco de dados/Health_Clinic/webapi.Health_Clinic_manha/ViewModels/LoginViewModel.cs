using System.ComponentModel.DataAnnotations;

namespace webapi.Health_Clinic_manha.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Email eh obrigatorio!!!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha eh obrigatoria!!!")]
        public string? Senha { get; set; }

    }
}
