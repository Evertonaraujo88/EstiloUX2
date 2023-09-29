using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;
using webapi.Health_Clinic_manha.Repositories;

namespace webapi.Health_Clinic_manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("Application/Json")]

    public class UsuarioController : ControllerBase
    {

        private IUsuarioRepository _usuarioRepository;

        public UsuarioController() 
        {

            _usuarioRepository = new UsuarioRepository();
        
        }

        /// <summary>
        /// EndPoint que aciona o metodo de CADASTRAR um novo Usuario.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>o usuario cadastrado</returns>
        [HttpPost]
        public IActionResult Post(UsuarioDomain usuario)
        {

            try
            {
                usuario.IdUsuario = Guid.NewGuid();

                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return (BadRequest(e.Message));
            }

        }
        /// <summary>
        /// EndPoint que aciona o método de LISTAR todos os usuarios cadastrados
        /// </summary>
        /// <returns>retorna a lista</returns>
        [HttpGet]
        public IActionResult Get() 
        {

            try
            {
                List<UsuarioDomain> ListarUsuario = _usuarioRepository.Listar();

                return Ok(ListarUsuario);

            }
            catch (Exception e)
            {

                return (BadRequest($"{e.Message}"));
            }
        
        }
        /// <summary>
        /// EndPoint que aciona o metodo de DELETAR um usuario cadastrado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete( Guid id) 
        {

            try
            {
                _usuarioRepository.Deletar(id);

                return Ok(StatusCode(204));
            }
            catch (Exception e)
            {

                return(BadRequest(e.Message));
            }
        
        }

        /// <summary>
        /// EndPoint que aciona o metodo de BUSCAR POR ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>retorna o usuario buscado pelo id</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_usuarioRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
