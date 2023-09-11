using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using senai.inlock.webApi_.Repositories;
using System.Data;

namespace senai.inlock.webApi_.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    //Define que o tipo de resposta da API sera em formato JSON
    [Produces("application/json")]


    public class EstudioController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController() 
        {
        
            _estudioRepository= new EstudioRepository();

        }

        /// <summary>
        /// EndPoint que aciona o metodo de cadastro de Estudio
        /// </summary>
        /// <param name="novoestudio">Objeto recebido na requisicao</param>
        /// <returns>Retorna a resposta para o usuario(Front-End)</returns>
        [HttpPost]
        [Authorize(Roles = "2")]
        public IActionResult Post(EstudioDomain novoestudio)
        {


            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                _estudioRepository.Cadastrar(novoestudio);

                //Retorna um status code 201(Created)
                return StatusCode(201);
            }
            catch (Exception erro)
            {
                //Retorna um status Code BadRequest(400) e a menssagem do erro
                return BadRequest(erro.Message);
            }
        }


        /// <summary>
        /// EndPoint que aciona o metodo ListarTodos no repositorio
        /// </summary>
        /// <returns>Retorna a resposta para o usuario(Front-End)</returns>
        [HttpGet]
        [Authorize(Roles = "1,2")]///autorização para acessar o metodo get
        public IActionResult Get()
        {

            try
            {
                //Cria uma lista que recebe os dados da requisicao
                List<EstudioDomain> ListaEstudios = _estudioRepository.ListarTodos();

                //Retorna a lista no formato JSON com o status Code ok(200)
                return Ok(ListaEstudios);
            }
            catch (Exception erro)
            {
                //Retorna um status Code BadRequest(400) e a menssagem do erro
                return BadRequest(erro.Message);
            }


        }

    }
}
