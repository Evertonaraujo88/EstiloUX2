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
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository _tiposUsuarioRepository;

        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(TiposUsuarioDomain tiposUsuario )
        {
            try
            {
                _tiposUsuarioRepository.Cadastrar(tiposUsuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

       /// <summary>
       /// EndPoint que aciona o metodo de listar todos os tipos de usuario
       /// </summary>
       /// <returns></returns>
        [HttpGet]
        public IActionResult Get() 
        {

            try
            {
                List<TiposUsuarioDomain> ListarTiposUsuario = _tiposUsuarioRepository.Listar();

                return Ok(ListarTiposUsuario);

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
