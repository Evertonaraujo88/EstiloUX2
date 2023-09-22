using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IPresencasEventoRepository
    {

        List<PresencasEventoDomain> ListarMinhas(Guid id);

        void Cadastrar(PresencasEventoDomain presenca);

        void Deletar(Guid id);

        PresencasEventoDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, PresencasEventoDomain presenca);

    }
}
