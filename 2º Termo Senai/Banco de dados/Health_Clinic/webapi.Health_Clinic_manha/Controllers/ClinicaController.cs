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

    public class ClinicaController : ControllerBase
    {


        private IClinicaRepository _clinicaRepository;

        public ClinicaController()
        {

            _clinicaRepository = new ClinicaRepository();

        }
        /// <summary>
        /// EndPoint que aciona o metodo de LISTAR as clinicas cadastradas.
        /// </summary>
        /// <returns>retorna alista de clinicas</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_clinicaRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de BUSCAR POR ID uma clínica
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a clinica buscada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_clinicaRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de CADASTRAR uma nova clinica
        /// </summary>
        /// <param name="clinica"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(ClinicaDomain clinica)
        {
            try
            {
                clinica.IdClinica = Guid.NewGuid();

                _clinicaRepository.Cadastrar(clinica);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// ENdPoint que aciona o metodo de ATUALIZAR uma clinica já cadastrada.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clinica"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, ClinicaDomain clinica)
        {
            try
            {
                _clinicaRepository.Atualizar(id, clinica);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de DELETAR uma clinica
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _clinicaRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



    }
}
