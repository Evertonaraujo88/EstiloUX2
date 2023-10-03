using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Interfaces
{
    public interface IMedicoRepository
    {

        void Cadastrar(MedicoDomain medico);

        void Deletar(Guid id);

        List<MedicoDomain> Listar();

        MedicoDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, MedicoDomain medico);

        MedicoDomain BuscarPorEspecialidade(MedicoDomain especialidade);

        List<MedicoDomain> BuscarPorEspecialidade(string especialidadeDesejada);

    }
}
