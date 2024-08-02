using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoEmail
{
    public static class Validador
    {

        //Método para validar um email
        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            //Verifica se o email contém "@" e "."
            return email.Contains("@") && email.Contains(".");
        }

    }
}
