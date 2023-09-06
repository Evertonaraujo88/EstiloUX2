

using senai.inlock.webApi_.Domains;

namespace senai.inlock.webApi_.Interfaces
{
    /// <summary>
    /// Interface responsavável pelo repositório EstudioRepository
    /// Definir os métodos que serão implementados pelo EstudioRepository
    /// </summary>
    public interface IEstudioRepository
    {

        //TipoRetorno NomeMetodo(TipoParamentro NomeParamentro)

        /// <summary>
        /// Cadastrar um novo Estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto que sera cadastrado</param>
        void Cadastrar(EstudioDomain novoEstudio);

        /// <summary>
        /// Listar todos os objetos cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<EstudioDomain> ListarTodos();

    }
}
