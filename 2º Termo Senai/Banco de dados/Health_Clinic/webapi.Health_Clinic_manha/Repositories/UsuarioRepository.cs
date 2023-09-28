using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioDomain BuscarPorEmailESenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public UsuarioDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(UsuarioDomain usuario)
        {
            throw new NotImplementedException();
        }

        List<UsuarioDomain> IUsuarioRepository.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
