using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface ITiposUsuarioRepository
    {

        void Cadastrar(TiposUsuarioDomain tipoUsuario);

        void Deletar(Guid id);

        List<TiposUsuarioDomain> Litar();

        TiposUsuarioDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposUsuarioDomain tiposUsuario);

    }
}
