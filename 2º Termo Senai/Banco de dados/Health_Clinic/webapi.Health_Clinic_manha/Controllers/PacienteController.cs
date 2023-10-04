using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;
using webapi.Health_Clinic_manha.Repositories;

namespace webapi.Health_Clinic_manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {

        private IPacienteRepository _pacienteRepository;

        public PacienteController()
        {

            _pacienteRepository = new PacienteRepository();

        }

        /// <summary>
        /// EndPoint que aciona o metodo de LISTAR os pacientes cadastrados.
        /// </summary>
        /// <returns>retorna alista de pacientes</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_pacienteRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de BUSCAR POR ID um paciente
        /// </summary>
        /// <param name="id"></param>
        /// <returns>o paciente buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_pacienteRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de CADASTRAR um nova paciente
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(PacienteDomain paciente)
        {
            try
            {
                paciente.IdPaciente = Guid.NewGuid();

                _pacienteRepository.Cadastrar(paciente);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        /// <summary>
        /// EndPoint que aciona o metodo de DELETAR um paciente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _pacienteRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        /// <summary>
        /// EndPoint que aciona o metodo de BUSCAR POR DataNascimento um paciente
        /// </summary>
        /// <param name="dataNascimento"></param>
        /// <returns>o paciente buscado</returns>
        //[HttpGet("{id}")]
        //public IActionResult GetByNascimento(DateTime nascimento)
        //{
        //    try
        //    {
        //        return Ok(_pacienteRepository.BuscarDataDeNascimento(nascimento));
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}
    }
}
