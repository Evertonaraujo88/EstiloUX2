using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;

namespace senai.inlock.webApi_.Repositories
{
    public class JogosRepository : IJogosRepository
    {
        // criado string de conexao com o banco de dados
        private string stringConexao = "Data Source = NOTE01-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";

        /// <summary>
        /// Cadastra um novo Jogo
        /// </summary>
        /// <param name="novoJogo"></param>
        public void Cadastrar(JogosDomain novoJogo)
        {

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryInsert = "INSERT INTO Jogo(IdEstudio, Nome, Descricao, DataLancamento, Valor) VALUES (@IdEstudio, @Nome, @Descricao, @DataLancamento, @Valor)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {

                    //passa o valor do parametro @IdEstudio
                    cmd.Parameters.AddWithValue("@IdEstudio", novoJogo.IdEstudio);

                    //passa o valor do parametro @JogosNome
                    cmd.Parameters.AddWithValue("@Nome", novoJogo.Nome);

                    //passa o valor do parametro @JogosDescricao
                    cmd.Parameters.AddWithValue("@Descricao", novoJogo.Descricao);

                    //passa o valor do parametro @DataLancamento
                    cmd.Parameters.AddWithValue("@DataLancamento", novoJogo.DataLancamento);

                    //passa o valor do parametro @JogosValor
                    cmd.Parameters.AddWithValue("@Valor", novoJogo.Valor);

                    //Abre a conexao com o banco de dados
                    con.Open();

                    //executar a query (queryInsert)
                    cmd.ExecuteNonQuery();
                }
            }
        }

            public List<JogosDomain> ListarTodos()
        {
            
            //Criar uma lista do tipo Jogos
            List<JogosDomain> ListaJogos = new List<JogosDomain>();

            //Declaro a SqlConnetion passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(stringConexao)) 
            {

                //Declara a instrucao a ser executada
                string querySelectAll = "SELECT Jogo.IdJogo, Jogo.IdEstudio, Jogo.Nome, Jogo.Descricao, Jogo.DataLancamento, Jogo.Valor, Estudio.IdEstudio, Estudio.Nome FROM Jogo INNER JOIN Estudio ON Jogo.IdEstudio = Estudio.IdEstudio";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con)) 
                {

                    rdr = cmd.ExecuteReader();


                   
                    while (rdr.Read()) 
                    {
                        JogosDomain jogo = new JogosDomain()
                        {
                            IdJogo = Convert.ToInt32(rdr[0]),
                            IdEstudio = Convert.ToInt32(rdr[1]),
                            Nome = rdr["Nome"].ToString(),
                            Descricao = rdr["Descricao"].ToString(),
                            DataLancamento = Convert.ToDateTime(rdr["DataLancamento"]),

                            //O método Convert.ToSingle é usado para converter um valor do seu tipo de dados atual para o tipo de dados float;
                            Valor = Convert.ToSingle(rdr["Valor"], CultureInfo.InvariantCulture),

                            Estudio = new EstudioDomain()
                            {
                                IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),
                                NomeEstudio = rdr["Nome"].ToString()
                            }

                        };
                        
                        ListaJogos.Add(jogo);
                    }

                }

            }

            return ListaJogos;

        }
    }

}
