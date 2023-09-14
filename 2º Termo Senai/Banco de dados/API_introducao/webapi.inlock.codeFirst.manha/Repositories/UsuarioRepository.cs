using Microsoft.AspNetCore.Http.HttpResults;
using webapi.inlock.codeFirst.manha.Contexts;
using webapi.inlock.codeFirst.manha.Domains;
using webapi.inlock.codeFirst.manha.Interfaces;
using webapi.inlock.codeFirst.manha.Utils;

namespace webapi.inlock.codeFirst.manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        /// <summary>
        /// Variavel privada e somente leitura para armazenar os dados do contexto
        /// </summary>
        private readonly InLockContext ctx;

        /// <summary>
        /// Construtor do repositorio
        /// Todo vez que o repositorio for instancioado
        /// Ele tera acesso aps dados fornecidos pelo contexto
        /// </summary>
        public UsuarioRepository()
        {
            ctx = new InLockContext();
        }


        public void Atualizar(UsuarioDomain usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioDomain BuscarUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(UsuarioDomain usuario)
        {
            try
            {
                //pega a senha informada pelo usuario, criptografa e salva novamente.
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Usuario.Add(usuario);

                ctx.SaveChanges();
            }
            catch (Exception e)
            {

                
            }

        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDomain> Listar()
        {
            throw new NotImplementedException();
        }


    }
}
