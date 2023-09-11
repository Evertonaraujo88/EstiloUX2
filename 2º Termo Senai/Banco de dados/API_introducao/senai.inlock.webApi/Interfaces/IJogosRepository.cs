using senai.inlock.webApi_.Domains;

namespace senai.inlock.webApi_.Interfaces
{
    public interface IJogosRepository
    {

        //TipoRetorno NomeMetodo(TipoParamentro NomeParamentro)

        /// <summary>
        /// Cadastrar um novo Jogo
        /// </summary>
        /// <param name="novoJogo">Objeto que sera cadastrado</param>
        void Cadastrar(JogosDomain novoJogo);

        /// <summary>
        /// Listar todos os objetos cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<JogosDomain> ListarTodos();

    }
}
