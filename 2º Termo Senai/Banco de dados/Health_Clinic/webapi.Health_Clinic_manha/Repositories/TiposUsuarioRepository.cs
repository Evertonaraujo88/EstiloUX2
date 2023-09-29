using Microsoft.EntityFrameworkCore;
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
            _healthContext = new HealthContext();
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
            try
            {
                _healthContext.TiposUsuario.Add(tipoUsuario);

                _healthContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Deletar(Guid id)
        {
            try
            {
                //instacia um objeto na domain e faz um Find(busca) pelo id informado pelo usuario.
                TiposUsuarioDomain tipoUsuarioBuscado = _healthContext.TiposUsuario.Find(id)!;

                //se o usuario encontrado for diferente de nulo, remove e depois salva.
                if (tipoUsuarioBuscado != null)
                {
                    _healthContext.TiposUsuario.Remove(tipoUsuarioBuscado);
                }

                _healthContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TiposUsuarioDomain> Listar()
        {
            try
            {
                List<TiposUsuarioDomain> ListaTiposUsuario = new List<TiposUsuarioDomain>();
                ListaTiposUsuario = _healthContext.TiposUsuario.ToList();

                return (ListaTiposUsuario);
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
