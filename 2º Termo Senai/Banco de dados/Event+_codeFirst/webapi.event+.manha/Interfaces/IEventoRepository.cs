using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IEventoRepository
    {

        void Cadastrar(EventoDomain tipoUsuario);

        void Deletar(Guid id);

        List<EventoDomain> Listar();

        EventoDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, EventoDomain evento);

    }
}
