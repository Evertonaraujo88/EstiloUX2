using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface ITiposUsuarioRepository
    {

        void Cadastrar(TiposUsuarioDomain tipoUsuario);

        void Deletar(Guid id);

        List<TiposUsuarioDomain> Listar();

        TiposUsuarioDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposUsuarioDomain tiposUsuario);

    }
}
