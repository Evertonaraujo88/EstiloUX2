using webapi.filmes.manha.Domains;

namespace webapi.filmes.manha.Interfaces
{

    /// <summary>
    /// Interface responsavável pelo repositório GeneroRepository
    /// Definir os métodos que serão implementados pelo GeneroRepository
    /// </summary>
    public interface IGeneroRepository
    {
        //TipoRetorno NomeMetodo(TipoParamentro NomeParamentro)

        /// <summary>
        /// Cadastrar um novo genero
        /// </summary>
        /// <param name="novoGenero">Objeto que serra cadastrado</param>
        void Cadastrar(GeneroDomain novoGenero);

        /// <summary>
        /// Listar todos os objetos cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Atualizar objeto existente passando o seu id pelo corpo da requisicao
        /// </summary>
        /// <param name="genero">Objeto atualizado (novas informacoes)</param>
        void AtualizarIdCorpo(GeneroDomain genero);

        /// <summary>
        /// Atualiza objeto existente passando o seu id pela url
        /// </summary>
        /// <param name="id">Id do objeto que sera atualizado</param>
        /// <param name="genero">Objeto atualizado (novas informacoes)</param>
        void AtualizarIdUrl(int id, GeneroDomain genero);

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
        GeneroDomain BuscarPorId(int id);
    }
}
