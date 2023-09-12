using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi_.Repositories
{
    public class EstudioRepository : IEstudioRepository

    {

        // String de Conexao com o bando de dados qe recebe os seguintess parametros
        // Data Source: Nome do servidor
        // Initial Catalog: Nome do banco de dados
        // Autenticacao:
        //     - Windows: Integrate Security = true;
        //     - SqlServer: User Id= sa; Pwd = Senha;

        private string stringConexao = "Data Source = NOTE01-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";
        //Integrated Security = true (para conexao integrada com windows)

        /// <summary>
        /// Cadastra um novo Estudio
        /// </summary>
        /// <param name="novoEstudio"></param>
        public void Cadastrar(EstudioDomain novoEstudio)
        {

            //Declera conexao passando a string conexao como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a query que sera executada
                string queryInsert = "INSERT INTO Estudio(Nome) values (@Nome)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con)) 
                {

                    //passa o valor do parametro @Nome
                    cmd.Parameters.AddWithValue("@Nome", novoEstudio.NomeEstudio);

                    //Abre a conexao com o banco de dados
                    con.Open();

                    //executar a query (queryInsert)
                    cmd.ExecuteNonQuery();
                }

            }

        }

        ///<summary>
        ///Listar todos objetos (Estudios)
        ///</summary>
        ///<returns>Lista de Objetos (Estudios)</returns>
        public List<EstudioDomain> ListarTodos()
        {
       
                //Cria uma lista de objetos do tipo estudio
                List<EstudioDomain> ListaEstudios = new List<EstudioDomain>();

                //Declaro a SqlConnetion passando a string de conexao como parametro
                using (SqlConnection con = new SqlConnection(stringConexao))
                {
                    //Declara a instrucao a ser executada
                    string querySelectAll = "SELECT * FROM Estudio";

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
                            EstudioDomain estudio = new EstudioDomain()
                            {
                                //Atribui a propriedade IdEstudio o valor reebido no rdr
                                IdEstudio = Convert.ToInt32(rdr[0]),
                                //Atribui a propridade Nome o valor recebido no rdr
                                NomeEstudio = rdr["Nome"].ToString()
                            };


                            //Adiciona cada objeto dentro da lista
                            ListaEstudios.Add(estudio);
                        }


                    }
                }

                return ListaEstudios;

            }
        }
}
