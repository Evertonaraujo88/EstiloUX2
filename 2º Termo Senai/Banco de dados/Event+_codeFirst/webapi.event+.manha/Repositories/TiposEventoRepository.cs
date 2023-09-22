using webapi.event_.manha.Context;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    public class TiposEventoRepository : ITiposEventoRepository
    {


        private readonly EventContext _eventContext;

        public TiposEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, TiposEventoDomain tiposUsuario)
        {
            throw new NotImplementedException();
        }

        public TiposEventoDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposEventoDomain tipoEvento)
        {
            try
            {
                _eventContext.TiposEvento.Add(tipoEvento);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposEventoDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
