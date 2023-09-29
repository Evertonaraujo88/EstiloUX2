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
    public class EspecialidadesController : ControllerBase
    {

        private IEspecialidadesRepository _especialidadesRepository;

        public EspecialidadesController()
        {

            _especialidadesRepository = new EspecialidadesRepository();

        }
        /// <summary>
        /// EndPoint que aciona o metodo de LISTAR as especilidades cadastradas.
        /// </summary>
        /// <returns>retorna alista de especialidades</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_especialidadesRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de BUSCAR POR ID uma especialidade
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a especialidade buscada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_especialidadesRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de CADASTRAR uma nova especialidade
        /// </summary>
        /// <param name="clinica"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(EspecialidadesDomain especialidade)
        {
            try
            {
                especialidade.IdEspecialidade = Guid.NewGuid();

               _especialidadesRepository.Cadastrar(especialidade);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de DELETAR uma especialidade
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _especialidadesRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
