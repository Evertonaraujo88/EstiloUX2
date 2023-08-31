using System.Data.SqlClient;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;

namespace webapi.filmes.manha.Repositories
{
    public class FilmeRepository : IFilmesRepository
    {

        private string stringConexao = "data source = NOTE01-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";
        //Integrated Security = true (para conexao integrada com windows)
        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, FilmeDomain filme)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string stringUpdateUrl = "UPDATE Filme SET  Titulo = @filmeNome, IdGenero = @filmeGenero WHERE IdFilme = @idFilme";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(stringUpdateUrl, con))
                {
                    cmd.Parameters.AddWithValue("@filmeNome", filme.Titulo);
                  
                }
            }

        }

        public FilmeDomain BuscarPorId(int id)
        {
            //Declera conexao passando a string conexao como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a query que sera executada
                string querySelectById = "SELECT Genero.Nome, Filme.Titulo, Filme.IdFilme, Filme.IdGenero FROM Filme LEFT JOIN Genero ON Genero.IdGenero = Filme.IdGenero WHERE IdFilme = @idFilme";

                //Abre a conexao com o banco de dados
                con.Open();

                //Declara 0 sqlDataReader para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                //Declara o SqlCommand passando a query que sera executada e a conexao com o banco de dados
                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    //Passando o valor para o paramentro @IdGenero
                    cmd.Parameters.AddWithValue("@IdFilme", id);



                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    //Verifica se o resultado da query retornou algum registro
                    if (rdr.Read())
                    {
                        //se sim, instacia um novo objeto generoBuscado do tipo GeneroDomain
                        FilmeDomain filmeBuscado = new FilmeDomain
                        {
                            //Atribui a propriedade IdGenero o valor da coluna "IdGenero" da tabela do banco de dados
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),

                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),

                            Titulo = rdr["Titulo"].ToString(),

                            Genero = new GeneroDomain
                            {
                                Nome = rdr["Nome"].ToString(),
                                IdGenero = Convert.ToInt32(rdr["IdGenero"])
                            }
                        };

                        //Retorna o generoBuscado com os dados obtidos
                        return filmeBuscado;
                    }
                    //se nao, retorna null
                    return null;

                }
            }
        }

        public void Cadastrar(FilmeDomain novoFilme)
        {
            //Declera conexao passando a string conexao como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a query que sera executada
                string queryInsert = "INSERT INTO Filme(IdGenero, Titulo) VALUES (@IdGenero, @FilmeTitulo)";

                //Declara o SqlCommand passando a query que sera executada e a conexao com o banco de dados
                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {

                    //passa o valor do parametro @Nome
                    cmd.Parameters.AddWithValue("@IdGenero", novoFilme.IdGenero);

                    cmd.Parameters.AddWithValue("@FilmeTitulo", novoFilme.Titulo);

                    //Abre a conexao com o banco de dados
                    con.Open();

                    //executar a query (queryInsert)
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Deletar(int id)
        {
            //Declera conexao passando a string conexao como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Filme WHERE IdFilme = @IdDeletado";

                //Declara o SqlCommand passando a query que sera executada e a conexao com o banco de dados
                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {

                    //passa o valor do parametro @Nome
                    cmd.Parameters.AddWithValue("@IdDeletado", id);

                    //Abre a conexao com o banco de dados
                    con.Open();

                    //executar a query (queryInsert)
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public List<FilmeDomain> ListarTodos()
        {
            //Cria uma lista de objetos do tipo Filme
            List<FilmeDomain> ListaFilmes = new List<FilmeDomain>();

            //Declaro a SqlConnetion passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                //Declara a instrucao a ser executada
                string querySelectAll = "SELECT Filme.IdFilme, Filme.IdGenero, Filme.Titulo, Genero.Nome FROM Filme INNER JOIN Genero ON Filme.IdGenero = Genero.IdGenero";

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
                        FilmeDomain filme = new FilmeDomain()
                        {
                            //Atribui a propriedade IdGenero o valor reebido no rdr
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),

                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),

                            //Atribui a propridade Nome o valor recebido no rdr
                            Titulo = rdr["Titulo"].ToString(),

                            Genero = new GeneroDomain()
                            {
                                IdGenero = Convert.ToInt32(rdr["IdGenero"]),

                                Nome = rdr["Nome"].ToString()
                            }
                        };


                        //Adiciona cada objeto dentro da lista
                        ListaFilmes.Add(filme);
                    }

                }
            }
            return ListaFilmes;
        }

    }
}

