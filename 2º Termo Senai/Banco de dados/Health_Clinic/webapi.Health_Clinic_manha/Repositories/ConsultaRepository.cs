using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext _healthContext;

        public ConsultaRepository()
        {
            _healthContext = new HealthContext();
        }

        public void Atualizar(Guid id, ConsultaDomain consulta)
        {
            throw new NotImplementedException();
        }

        public ConsultaDomain BuscarPorId(Guid id)
         {
            throw new NotImplementedException();


            //try
            //{
            //    ConsultaDomain consultaBuscada = _healthContext.Consulta
            //        .Select(u => new ConsultaDomain
            //        {
            //            IdConsulta = u.IdConsulta,
            //            IdMedico = u.IdMedico,
            //            IdPaciente = u.IdPaciente,



            //        }).FirstOrDefault(u => u.IdEspecialidade == id)!;

            //    if (especialidadeBuscada != null)
            //    {
            //        return (especialidadeBuscada);

            //    }
            //    return null!;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        public void Cadastrar(ConsultaDomain consulta)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ConsultaDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
