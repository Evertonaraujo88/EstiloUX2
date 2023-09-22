using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface ITiposEventoRepository
    {
        void Cadastrar(TiposEventoDomain tipoEvento);

        void Deletar(Guid id);

        List<TiposEventoDomain> Listar();

        TiposEventoDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposEventoDomain tiposUsuario);
    }
}
