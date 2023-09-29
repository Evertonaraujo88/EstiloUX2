using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IUsuarioRepository
    {

        void Cadastrar(UsuarioDomain usuario);

        UsuarioDomain BuscarPorId(Guid id);

        UsuarioDomain BuscarPorEmailESenha(string email, string senha);

        List<UsuarioDomain> Listar();

    }
}
