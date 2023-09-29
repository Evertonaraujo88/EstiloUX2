using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class EspecialidadesRepository : IEspecialidadesRepository
    {

        private readonly HealthContext _healthContext;

        public EspecialidadesRepository()
        {
            _healthContext = new HealthContext();
        }

        public void Atualizar(Guid id, EspecialidadesDomain especialidade)
        {
            throw new NotImplementedException();
        }

        public EspecialidadesDomain BuscarPorId(Guid id)
        {
            try
            {
                EspecialidadesDomain especialidadeBuscada = _healthContext.Especialidades
                    .Select(u => new EspecialidadesDomain
                    {
                        IdEspecialidade = u.IdEspecialidade,
                        NomeEspecialidade = u.NomeEspecialidade,
                        

                    }).FirstOrDefault(u => u.IdEspecialidade == id)!;

                if (especialidadeBuscada != null)
                {
                    return (especialidadeBuscada);

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(EspecialidadesDomain especialidade)
        {
            try
            {
                especialidade.IdEspecialidade = Guid.NewGuid();

                _healthContext.Especialidades.Add(especialidade);

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
                EspecialidadesDomain especialidadeBuscada = _healthContext.Especialidades.Find(id)!;

                //se o usuario encontrado for diferente de nulo, remove e depois salva.
                if (especialidadeBuscada != null)
                {
                    _healthContext.Especialidades.Remove(especialidadeBuscada);
                }

                _healthContext.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<EspecialidadesDomain> Listar()
        {
            try
            {
                List<EspecialidadesDomain> ListaEspecilidades = new List<EspecialidadesDomain>();
                ListaEspecilidades = _healthContext.Especialidades
                    .Select(u => new EspecialidadesDomain
                    {
                        IdEspecialidade = u.IdEspecialidade,
                        NomeEspecialidade = u.NomeEspecialidade
                        
                    })
                    .ToList();

                return (ListaEspecilidades);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
