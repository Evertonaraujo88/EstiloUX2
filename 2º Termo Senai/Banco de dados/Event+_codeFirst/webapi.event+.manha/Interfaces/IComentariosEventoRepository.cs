using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IComentariosEventoRepository
    {


        void Cadastrar(ComentariosEventoDomain comentario);

        void Deletar(Guid id);

        List<ComentariosEventoDomain> Listar();

        ComentariosEventoDomain BuscarPorId(Guid id);

       
    }
}
