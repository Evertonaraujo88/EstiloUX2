using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;
using webapi.filmes.manha.Repositories;

namespace webapi.filmes.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(UsuarioDomain usuario)
        {

            try
            {
                UsuarioDomain usuarioBuscado = _usuarioRepository.Login(usuario.Email, usuario.Senha);

                if (usuarioBuscado == null)
                {
                    return NotFound("Email ou Senha Inválidos!!");
                }

                //Caso encontre o usuario, prossegue oara a criação do token

                //1º definir as informaçãoes(claims) que serão forncedodas no token (PAYLOAD)

                var claims = new[]
                {
                    //formato da Claim 
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(ClaimTypes.Role, usuarioBuscado.Permissao),

                    //existe a possibilidade de criar uma Claim personalizada
                    new Claim("Claim Personalizada", "Valor da Claim Personaizada")

                };

                //2º Definira a chave de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi-dev"));

                //3º Definir as credencias do token (HEADER)
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //4º Gerar token
                var token = new JwtSecurityToken
                    (
                        //emissor do token
                        issuer: "webapi.filmes.manha",

                        //destinatário do token
                        audience: "webapi.filmes.manha",

                        //dados definidos nas Claims(informações)
                        claims: claims,

                        //tempo de expiração do token
                        expires: DateTime.Now.AddMinutes(5),

                        //Credenciais do Token
                        signingCredentials: creds
                    ) ;



                    //5º retornar o token criado

                return Ok(new{

                    token = new JwtSecurityTokenHandler().WriteToken(token)

                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            }


    }
}
