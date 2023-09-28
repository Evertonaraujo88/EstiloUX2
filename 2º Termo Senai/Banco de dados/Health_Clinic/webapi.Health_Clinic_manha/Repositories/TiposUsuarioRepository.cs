using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly HealthContext _healthContext;

        public TiposUsuarioRepository()
        {
            _healthContext= new HealthContext();
        }
        public void Atualizar(Guid id, TiposUsuarioDomain tiposUsuario)
        {
            throw new NotImplementedException();
        }

        public TiposUsuarioDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposUsuarioDomain tipoUsuario)
        {
            _healthContext.TiposUsuario.Add(tipoUsuario);
            
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposUsuarioDomain> Listar()
        {
            List<TiposUsuarioDomain> ListaTiposUsuario = new List<TiposUsuarioDomain>();
            ListaTiposUsuario = _healthContext.TiposUsuario.ToList();

            return (ListaTiposUsuario);

        }
    }
}
