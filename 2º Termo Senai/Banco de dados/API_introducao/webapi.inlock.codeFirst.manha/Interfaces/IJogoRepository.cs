using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Interfaces
{
    public interface IJogoRepository
    {

        List<JogoDomain> Listar();

        JogoDomain BuscarPorId(Guid id);

        void Cadastrar(JogoDomain novoJogo);

        void Atualizar(JogoDomain novoJogo);

        void Deletar(Guid Id);



    }
}
