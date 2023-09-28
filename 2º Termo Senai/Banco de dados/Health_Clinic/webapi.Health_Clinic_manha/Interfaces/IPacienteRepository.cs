using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Interfaces
{
    public interface IPacienteRepository
    {

        void Cadastrar(PacienteDomain paciente);

        void Deletar(Guid id);

        List<PacienteDomain> Listar();

        PacienteDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, PacienteDomain paciente);

    }
}
