using Microsoft.EntityFrameworkCore;
using webapi.inlock.dbFirst.manha.Contexts;
using webapi.inlock.dbFirst.manha.Domains;
using webapi.inlock.dbFirst.manha.Interfaces;

namespace webapi.inlock.dbFirst.manha.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        //instanciando uma classe context
        InLockContext ctx = new InLockContext();

        public void Atualizar(Guid id, Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public Estudio BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Estudio> Listar()
        {

            //acessa o context a tabela estudios e traz a lista de estudios cadastrados
            return ctx.Estudios.ToList();
        }

        public List<Estudio> ListarComJogos()
        {
            //acessa o context a tabela de estudio, incluindo a tabela de jogo e lista tudo que esta relacionado
            return ctx.Estudios.Include(e => e.Jogos).ToList();
        }
    }
}
