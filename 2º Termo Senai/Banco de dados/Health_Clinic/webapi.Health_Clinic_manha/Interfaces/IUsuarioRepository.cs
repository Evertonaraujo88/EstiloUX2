using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Interfaces
{
    public interface IUsuarioRepository
    {

        void Cadastrar(UsuarioDomain usuario);

        UsuarioDomain BuscarPorId(Guid id);

        UsuarioDomain BuscarPorEmailESenha(string email, string senha);

        List<UsuarioDomain> Listar();

        void Deletar(Guid id);

    }
}
