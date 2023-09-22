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

    public class TiposEventoController : ControllerBase
    {


        private ITiposEventoRepository _tiposEventoRepository;

        public TiposEventoController()
        {
            _tiposEventoRepository = new TiposEventoRepository();
        }

        [HttpPost]
        public IActionResult Post(TiposEventoDomain tiposEvento) 
        {

            try
            {
                _tiposEventoRepository.Cadastrar(tiposEvento);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        
        }

    }
}
