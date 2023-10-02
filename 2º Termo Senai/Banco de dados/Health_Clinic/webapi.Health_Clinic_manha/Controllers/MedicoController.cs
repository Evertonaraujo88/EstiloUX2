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

    public class MedicoController : ControllerBase
    {


        private IMedicoRepository _medicoRepository;

        public MedicoController()
        {

            _medicoRepository = new MedicoRepository();

        }
        /// <summary>
        /// EndPoint que aciona o metodo de LISTAR os medicos cadastrados.
        /// </summary>
        /// <returns>retorna alista de medicos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_medicoRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de BUSCAR POR ID um medico
        /// </summary>
        /// <param name="id"></param>
        /// <returns>o medico buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_medicoRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de CADASTRAR um novo medico
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(MedicoDomain medico)
        {
            try
            {
                medico.IdMedico = Guid.NewGuid();

                _medicoRepository.Cadastrar(medico);

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
                _medicoRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de BUSCAR POR ESPECIALIDADE um medico
        /// </summary>
        /// <param name="especialidade"></param>
        /// <returns>o medico buscado</returns>
        [HttpGet("{especialidade}")]
        public IActionResult GetByEspecialidade(MedicoDomain especialidade)
        {
            try
            {
                MedicoDomain medicoBuscado = _medicoRepository.BuscarPorEspecialidade(especialidade);

                return Ok(medicoBuscado);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
