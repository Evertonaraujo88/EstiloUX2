using System.Data.SqlClient;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;

namespace webapi.filmes.manha.Repository
{
    public class GeneroRepository : IGeneroRepository
    {

        // String de Conexao com o bando de dados qe recebe os seguintess parametros
        // Data Source: Nome do servidor
        // Initial Catalog: Nome do banco de dados
        // Autenticacao:
        //     - Windows: Integrate Security = true;
        //     - SqlServer: User Id= sa; Pwd = Senha;

        private string stringConexao = "DataSource = NOTE01-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";
        //Integrated Security = true (para conexao integrada com windows)


        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain novoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        ///<summary>
        ///Listar todos objetos (generos)
        ///</summary>
        ///<returns>Lista de Objetos (generos)</returns>

        public List<GeneroDomain> ListarTodos()
        {
            //Cria uma lista de objetos do tipo genero 
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();

            //Declaro a SqlConnetion passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a instrucao a ser executada
                string querySelectAll = "SELECT IdGenero, Nome FROM Genero";

                //Abre a conexao com o banco de dados
                con.Open();

                //Declara 0 sqlDataReader para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                //Declara p SqlCommand passando a query que sera executada e a conexao com o banco de dados
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            //Atribui a propriedade IdGenero o valor reebido no rdr
                            IdGenero = Convert.ToInt32(rdr[0]),
                            //Atribui a propridade Nome o valor recebido no rdr
                            Nome = rdr["Nome"].ToString()
                        };


                        //Adiciona cada objeto dentro da lista
                        listaGeneros.Add(genero);
                    }
                    

                }
            }


        }

                return ListaGeneros;
        }
}
}
