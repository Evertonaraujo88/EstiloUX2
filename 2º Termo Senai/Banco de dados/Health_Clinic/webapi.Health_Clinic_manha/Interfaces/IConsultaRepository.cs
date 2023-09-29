using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Interfaces
{
    public interface IConsultaRepository
    {

        void Cadastrar(ConsultaDomain consulta);

        void Deletar(Guid id);

        List<ConsultaDomain> Listar();

        ConsultaDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, ConsultaDomain consulta);

       

    }
}
