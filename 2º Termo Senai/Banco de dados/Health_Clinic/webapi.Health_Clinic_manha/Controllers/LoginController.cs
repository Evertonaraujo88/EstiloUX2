using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;
using webapi.Health_Clinic_manha.Repositories;
using webapi.Health_Clinic_manha.ViewModels;

namespace webapi.Health_Clinic_manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("Application/Json")]
    public class LoginController : ControllerBase
    {

       
            private readonly IUsuarioRepository _usuarioRepository;

            public LoginController()
            {
                _usuarioRepository = new UsuarioRepository();
            }

            [HttpPost]
            public IActionResult Post(LoginViewModel usuario)
            {

                try
                {

                    UsuarioDomain usuarioEncontrado = _usuarioRepository.BuscarPorEmailESenha(usuario.Email!, usuario.Senha!);

                    if (usuarioEncontrado == null)
                    {
                        return StatusCode(401, "Email ou senha inválidos");

                    }

                    //Logica do token

                    var claims = new[]
                    {

                    new Claim(JwtRegisteredClaimNames.Email, usuarioEncontrado.Email!),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioEncontrado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioEncontrado.TiposUsuario.Titulo!)

                };

                    var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("senai-healthClinicCodefirst-chave-autenticacao-webapi-dev"));

                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var Token = new JwtSecurityToken
                        (
                            issuer: "webapi.healthClinic.manha",

                            audience: "webapi.healthClinic.manha",

                            claims: claims,

                            expires: DateTime.Now.AddMinutes(5),

                            signingCredentials: creds
                        );

                    return Ok(new
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(Token),
                    });


                }
                catch (Exception e)
                {

                    return BadRequest(e.Message);
                }

            }
        }

    
}
