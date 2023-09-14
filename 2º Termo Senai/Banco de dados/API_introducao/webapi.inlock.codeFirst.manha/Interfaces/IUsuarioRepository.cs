using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Interfaces
{
    public interface IUsuarioRepository
    {

        List<UsuarioDomain> Listar();

        UsuarioDomain BuscarUsuario (string email, string senha);

        void Cadastrar(UsuarioDomain usuario);

        void Atualizar(UsuarioDomain usuario);

        void Deletar(Guid id);



    }
}
