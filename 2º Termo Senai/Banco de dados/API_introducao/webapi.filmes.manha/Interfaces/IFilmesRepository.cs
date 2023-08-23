using webapi.filmes.manha.Domains;

namespace webapi.filmes.manha.Interfaces
{
    public interface IFilmesRepository
    {
        /// <summary>
        /// Interface responsavável pelo repositório GeneroRepository
        /// Definir os métodos que serão implementados pelo GeneroRepository
        /// </summary>
      
            //TipoRetorno NomeMetodo(TipoParamentro NomeParamentro)

            /// <summary>
            /// Cadastrar um novo genero
            /// </summary>
            /// <param name="novoFilme">Objeto que serra cadastrado</param>
            void Cadastrar(FilmeDomain novoFilme);

            /// <summary>
            /// Listar todos os objetos cadastrados
            /// </summary>
            /// <returns>Lista com os objetos</returns>
            List<FilmeDomain> ListarTodos();

            /// <summary>
            /// Atualizar objeto existente passando o seu id pelo corpo da requisicao
            /// </summary>
            /// <param name="filme">Objeto atualizado (novas informacoes)</param>
            void AtualizarIdCorpo(FilmeDomain filme);

            /// <summary>
            /// Atualiza objeto existente passando o seu id pela url
            /// </summary>
            /// <param name="id">Id do objeto que sera atualizado</param>
            /// <param name="filme">Objeto atualizado (novas informacoes)</param>
            void AtualizarIdUrl(int id, FilmeDomain filme);

            /// <summary>
            /// Deletar um objeto
            /// </summary>
            /// <param name="id">Id do objeto que sera deletado</param>
            void Deletar(int id);

            /// <summary>
            /// Busca um objeto atraves do seu ID
            /// </summary>
            /// <param name="id">Id do objeto a ser buscado</param>
            /// <returns>Objeto Buscado</returns>
            FilmeDomain BuscarPorId(int id);
        }
   
     }
