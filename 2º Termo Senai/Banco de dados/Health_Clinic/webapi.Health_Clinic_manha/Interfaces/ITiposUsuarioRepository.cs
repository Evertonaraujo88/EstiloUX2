using webapi.Health_Clinic_manha.Domains;

namespace webapi.Health_Clinic_manha.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        void Cadastrar(TiposUsuarioDomain tipoUsuario);

        void Deletar(Guid id);

        List<TiposUsuarioDomain> Listar();

        TiposUsuarioDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposUsuarioDomain tiposUsuario);
    }
}
