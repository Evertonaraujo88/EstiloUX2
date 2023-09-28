using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Interfaces
{
    public interface IComentariosRepository
    {

        void Cadastrar(ComentariosDomain comentario);

        void Deletar(Guid id);

        List<ComentariosDomain> Listar();

        ComentariosDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, ComentariosDomain comentario);

    }
}
