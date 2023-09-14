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

            Estudio estudioBuscado = ctx.Estudios.Find(id);

            if (estudioBuscado != null)
            {
                estudioBuscado.Nome = estudio.Nome;
            }

            ctx.Estudios.Update(estudioBuscado!);

            ctx.SaveChanges();

        }

        public Estudio BuscarPorId(Guid id)
        {
            //acessa o contexto a tabela estudios e busca no banco de dados o id informado pelo usuario
            return ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id)!;

        }

        public void Cadastrar(Estudio estudio)
        {
            //antes de cadastrar um novo estudio, esse comando cria um novo Guid(id)
            estudio.IdEstudio = Guid.NewGuid();

            ctx.Estudios.Add(estudio);

            ctx.SaveChanges();

        }

        public void Deletar(Guid id)
        {
            Estudio estudioBuscado = ctx.Estudios.Find(id);

            ctx.Estudios.Remove(estudioBuscado);

            ctx.SaveChanges();
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
