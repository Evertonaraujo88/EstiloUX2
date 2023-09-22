using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Repositories;

namespace webapi.event_.manha.Controllers
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


        /// <summary>
        /// EndPoint que aciona o metodo de cadastrar um novo usuaria
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(UsuarioDomain usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de Buscar um usuario pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
