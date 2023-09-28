using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Interfaces
{
    public interface IEspecialidadesRepository
    {

        void Cadastrar(EspecialidadesDomain especialidade);

        void Deletar(Guid id);

        List<EspecialidadesDomain> Listar();

        EspecialidadesDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, EspecialidadesDomain especialidade);

    }
}
