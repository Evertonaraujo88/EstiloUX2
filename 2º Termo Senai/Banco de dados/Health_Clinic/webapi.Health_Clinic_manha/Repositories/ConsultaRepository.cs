using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext _healthContext;
        private readonly IComentariosRepository _comentarioRepository;

        public ConsultaRepository()
        {
            _healthContext = new HealthContext();
            _comentarioRepository = new ComentariosRepository();
        }

        public void Atualizar(Guid id, ConsultaDomain consulta)
        {
            try
            {
                ConsultaDomain consultaBuscada = BuscarPorId(id);

                consultaBuscada.DataConsulta = consulta.DataConsulta;
                consultaBuscada.HoraConsulta = consulta.HoraConsulta;

                _healthContext.Consulta.Update(consultaBuscada);

                _healthContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ConsultaDomain BuscarPorId(Guid id)
        {
            try
            {
                ConsultaDomain consultaBuscada = _healthContext.Consulta.FirstOrDefault(u => u.IdConsulta == id)!;

                if (consultaBuscada != null)
                {
                    return (consultaBuscada);

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(ConsultaDomain consulta)
        {
            try
            {
                consulta.IdConsulta = Guid.NewGuid();

                _healthContext.Consulta.Add(consulta);

                _healthContext.SaveChanges();

                ComentariosDomain comentario = new ComentariosDomain()
                {
                    IdComentario = Guid.NewGuid(),
                    Exibe = true,
                    IdPaciente = consulta.IdPaciente,
                    IdConsulta = consulta.IdConsulta
                };

                _comentarioRepository.Cadastrar(comentario);
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
                ConsultaDomain consultaBuscada = _healthContext.Consulta.Find(id)!;

                //se o usuario encontrado for diferente de nulo, remove e depois salva.
                if (consultaBuscada != null)
                {
                    _healthContext.Consulta.Remove(consultaBuscada);
                }

                _healthContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ConsultaDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
