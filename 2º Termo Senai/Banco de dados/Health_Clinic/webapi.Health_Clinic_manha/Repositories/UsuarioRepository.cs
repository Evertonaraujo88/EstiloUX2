using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;
using webapi.Health_Clinic_manha.Utils;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly HealthContext _healthContext;

        public UsuarioRepository()
        {
            _healthContext = new HealthContext();
        }
        public UsuarioDomain BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                UsuarioDomain usuarioBuscado = _healthContext.Usuario
                    .Select(u => new UsuarioDomain
                    {

                        IdUsuario = u.IdUsuario,
                        Email = u.Email,
                        Senha = u.Senha,
                        TiposUsuario = new TiposUsuarioDomain
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            Titulo = u.TiposUsuario.Titulo
                        }

                    }).FirstOrDefault(u => u.Email == email)!;

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
                UsuarioDomain usuarioBuscado = _healthContext.Usuario
                    .Select(u => new UsuarioDomain
                    {
                        IdUsuario = u.IdUsuario,
                        Email = u.Email,
                        Senha = u.Senha,
                        TiposUsuario = new TiposUsuarioDomain
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            Titulo = u.TiposUsuario!.Titulo
                        }

                    }).FirstOrDefault(u => u.IdUsuario == id)!;

                if (usuarioBuscado != null)
                {
                    return (usuarioBuscado);

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                //instacia um objeto na domain e faz um Find(busca) pelo id informado pelo usuario.
                UsuarioDomain usuarioBuscado = _healthContext.Usuario.Find(id)!;

                //se o usuario encontrado for diferente de nulo, remove e depois salva.
                if (usuarioBuscado != null)
                {
                    _healthContext.Usuario.Remove(usuarioBuscado);
                }

                _healthContext.SaveChanges();
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

                _healthContext.Usuario.Add(usuario);

                _healthContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<UsuarioDomain> Listar()
        {
            try
            {
                List<UsuarioDomain> ListaUsuario = new List<UsuarioDomain>();
                ListaUsuario = _healthContext.Usuario
                    .Select(u => new UsuarioDomain
                    {
                        IdUsuario = u.IdUsuario,
                        Email = u.Email,
                        Senha = u.Senha,

                        TiposUsuario = new TiposUsuarioDomain
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            Titulo = u.TiposUsuario!.Titulo
                        }

                    })
                    .ToList();

                return (ListaUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
