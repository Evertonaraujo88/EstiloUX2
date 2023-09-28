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

    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository _tiposUsuarioRepository;

        public TiposUsuarioController() 
        {
        
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        
        }
        /// <summary>
        /// EndPoint que aciona o metodo de Listar tipos de usuarios cadastrados
        /// </summary>
        /// <returns> retorna a lista de tipos de usuario</returns>
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

        /// <summary>
        /// EndPoint que aciona o metodo de CADASTRAR um novo tipo de Usuario.
        /// </summary>
        /// <param name="tiposUsuario"></param>
        /// <returns>o tipo cadastrado</returns>
        [HttpPost]
        public IActionResult Post(TiposUsuarioDomain tiposUsuario) 
        {

            try
            {
                tiposUsuario.IdTipoUsuario = Guid.NewGuid();
           
                _tiposUsuarioRepository.Cadastrar(tiposUsuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return (BadRequest(e.Message));
            }
        
        }


    }
}
