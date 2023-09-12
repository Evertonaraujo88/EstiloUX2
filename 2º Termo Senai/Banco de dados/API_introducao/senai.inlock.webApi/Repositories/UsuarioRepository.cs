using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace senai.inlock.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os seguintes parâmetros:
        /// Data Source: Nome do servidor 
        /// Initial Catalog: Nome do banco de dados
        /// Autentificação:
        ///     -Windows: Integrated Security = true
        ///     -SqlServer: User Id = sa; Pwd = Senha
        /// </summary>
        private string StringConexao = "Data Source = NOTE01-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";

        /// <summary>
        /// Autenticar um usuário com base em seu email e senha, usando login do objeto usuario.
        /// </summary>
        /// <param name="email">Um string representando o email do usuário.</param>
        /// <param name="senha">Um string representando a senha do usuário</param>
        /// <returns></returns>
        public UsuarioDomain Login(string email, string senha)
        {
            //instanciando string de conexão
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryLogin = "SELECT IdUsuario, IdTipoUsuario, Email FROM Usuario WHERE Email = @Email AND Senha = @Senha";
                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryLogin, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain
                        {
                            IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),

                            IdTipoUsuario = Convert.ToInt32(rdr["IdTipoUsuario"]),

                            Email = rdr["Email"].ToString()
                        };
                        return usuario;

                    }
                    return null;
                }
            }
        }
    }
}