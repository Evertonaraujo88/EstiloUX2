using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Interface responsável pelo repositório UsuarioRepository
        /// Definir os métodos que serão implementados pelo UsuarioRepository
        /// </summary>
        UsuarioDomain Login(string email, string senha);
    }
}