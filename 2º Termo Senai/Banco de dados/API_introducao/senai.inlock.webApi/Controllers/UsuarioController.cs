using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace senai.inlock.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //Define que o tipo de resposta da API será em formato JSON
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        /// <summary>
        /// Endpoint que aciona o método Login.
        /// </summary>
        /// <param name="usuario">Usuario recebido na requisição.</param>
        /// <returns>A resposta para o usuario(front-end)</returns>
        [HttpPost]
        public IActionResult Login(UsuarioDomain usuario)
        {

            try
            {
                UsuarioDomain usuarioBuscado = _usuarioRepository.Login(usuario.Email, usuario.Senha);
                if (usuarioBuscado == null)
                {
                    return NotFound("Email ou senha inválidos!");
                }

                //Caso encontre o usuario, prossegue para a criação do token

                //1º- Definir as informações (claims) que serão fornecidos no token (PAYLOAD)
                var claims = new[]
                {
                    //Formato da Claim
                    //JTI serve para a identificação de ID (identificador)
                    new Claim(JwtRegisteredClaimNames.Jti,usuarioBuscado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email,usuarioBuscado.Email),
                    new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString()),

                    //Existe a possibilidade de criar uma claim personalizada
                    new Claim("Claim Personalizada", "Valor da Claim Personalizada")
                };

                //2º- Definir a chave de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("inlock-chave-autenticacao-webapi-dev"));

                //3º- Definir as credenciais do token (HEADER)
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //4º- Gerar o token 
                var token = new JwtSecurityToken
                (
                    //emissor do token (ver em program)
                    issuer: "senai.inlock.webApi",

                    //Destinatario do token
                    audience: "senai.inlock.webApi",

                    //Dados definidos nas claims(informações)
                    claims: claims,

                    //tempo de expiração
                    expires: DateTime.Now.AddMinutes(10),

                    //credenciais token
                    signingCredentials: creds


                );

                //5º - Retornar o token criado
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
    }
}