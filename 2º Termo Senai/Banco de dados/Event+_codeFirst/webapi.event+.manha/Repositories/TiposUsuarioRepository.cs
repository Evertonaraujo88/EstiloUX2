using webapi.event_.manha.Context;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly EventContext _eventContext;

        public TiposUsuarioRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, TiposUsuarioDomain tiposUsuario)
        {
            throw new NotImplementedException();
        }

        public TiposUsuarioDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposUsuarioDomain tipoUsuario)
        {
            
            _eventContext.TiposUsuario.Add(tipoUsuario);

            _eventContext.SaveChanges();


        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposUsuarioDomain> Litar()
        {
            throw new NotImplementedException();
        }
    }
}
