namespace webapi.Health_Clinic_manha.Utils
{
    public class Criptografia
    {
        //metodo de gerar hash e criptografar a senha do usuario, enviando para o banco de dados a senha ja codificada.
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        //compara se a senha informada eh igual a cadastrada no banco de dados
        public static bool CompararHAsh(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }


    }
}
