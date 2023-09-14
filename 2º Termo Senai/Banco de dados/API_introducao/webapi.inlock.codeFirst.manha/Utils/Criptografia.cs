namespace webapi.inlock.codeFirst.manha.Utils
{

    //adicionando STATIC a classe para que possa ser usada na solução como um todo
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma hash a partir de uma senha
        /// </summary>
        /// <param name="senha">Senha que recebera a hash</param>
        /// <returns>Senha criptografada com a hash</returns>
        public static string GerarHash(string senha) 
        {

            return BCrypt.Net.BCrypt.HashPassword(senha);

        }

        /// <summary>
        /// Verifica se a hash da senha informada eh igual a hash salva no banco
        /// </summary>
        /// <param name="senhaForm">Senha informada pelo usuario</param>
        /// <param name="senhaBanco">Senha cadastrada no banco</param>
        /// <returns>true ou false (senha é verdadeira?)</returns>
        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }

    }
}
