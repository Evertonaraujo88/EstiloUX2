using Microsoft.EntityFrameworkCore;
using webapi.event_.manha.Context;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Utils;

namespace webapi.event_.manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventContext _eventContext;

        public UsuarioRepository()
        {
            _eventContext = new EventContext();
        }


        public UsuarioDomain BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                UsuarioDomain usuarioBuscado = _eventContext.Usuario.FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHAsh(senha, usuarioBuscado.Senha!);
                    
                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                                      
                }

                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public UsuarioDomain BuscarPorId(Guid id)
        {
            try
            {

                UsuarioDomain usuario = _eventContext.Usuario
                    .Select(u => new UsuarioDomain
                    {

                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        TiposUsuario = new TiposUsuarioDomain
                        {
                            Titulo = u.TiposUsuario!.Titulo
                        }

                    }).FirstOrDefault(u => u.IdUsuario == id)!;

                if (usuario != null)
                {
                    return usuario;
                }
                return null!;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(UsuarioDomain usuario)
        {

            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                _eventContext.Usuario.Add(usuario);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
