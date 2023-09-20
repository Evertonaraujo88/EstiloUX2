using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.inlock.codeFirst.manha.Domains;
using webapi.inlock.codeFirst.manha.Interfaces;
using webapi.inlock.codeFirst.manha.Repositories;
using webapi.inlock.codeFirst.manha.ViewModels;

namespace webapi.inlock.codeFirst.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                UsuarioDomain usuarioEncontrado = _usuarioRepository.BuscarUsuario(usuario.Email, usuario.Senha);

                if (usuarioEncontrado == null)
                {
                    return NotFound("Email ou senha inválidos");
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioEncontrado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioEncontrado.IdTipoUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioEncontrado.Email),
                    new Claim(ClaimTypes.Role, usuarioEncontrado.TipoUsuario.Titulo)
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("senai-inlock-chave-autenticacao-webapi-dev"));

                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                    (
                        issuer: "webapi.inlock.codeFirst.manha",

                        audience: "webapi.inlock.codeFirst.manha",

                        claims: claims,

                        expires: DateTime
                    );

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}