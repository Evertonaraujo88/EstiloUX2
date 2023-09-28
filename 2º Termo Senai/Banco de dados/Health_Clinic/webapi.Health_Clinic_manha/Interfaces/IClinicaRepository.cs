using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Interfaces
{
    public interface IClinicaRepository
    {

        void Cadastrar(ClinicaDomain clinica);

        void Deletar(Guid id);

        List<ClinicaDomain> Listar();

        ClinicaDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, ClinicaDomain Clinica);

    }
}
