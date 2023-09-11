using Microsoft.AspNetCore.Authorization;
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

    public class JogosController : Controller
    {

        private IJogosRepository _jogoRepository { get; set; }

        public JogosController()
        {

            _jogoRepository = new JogosRepository();
        
        }
        /// <summary>
        /// EndPoint que aciona o metodo de cadastro de jogos
        /// </summary>
        /// <param name="novojogo">Objeto recebido na requisicao</param>
        /// <returns>Retorna a resposta para o usuario(Front-End)</returns>
        [HttpPost]
        public IActionResult Post(JogosDomain novojogo)
        {


            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                _jogoRepository.Cadastrar(novojogo);

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
        public IActionResult Get()
        {

            try
            {
                //Cria uma lista que recebe os dados da requisicao
                List<JogosDomain> ListaJogos = _jogoRepository.ListarTodos();

                //Retorna a lista no formato JSON com o status Code ok(200)
                return Ok(ListaJogos);
            }
            catch (Exception erro)
            {
                //Retorna um status Code BadRequest(400) e a menssagem do erro
                return BadRequest(erro.Message);
            }


        }
    }
}
