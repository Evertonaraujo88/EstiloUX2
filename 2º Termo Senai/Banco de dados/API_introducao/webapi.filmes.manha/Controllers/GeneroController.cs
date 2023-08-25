using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;
using webapi.filmes.manha.Repository;

namespace webapi.filmes.manha.Controllers
{
    //Define que a rita de yna requisicai sera ni seguinte formato
    // dominio/api/nomeControle
    //exemplo: http://localhost:5000/api/genero
    [Route("api/[controller]")]

    //Define que eh um controlador de API
    [ApiController]

    //Define que o tipo de resposta da API sera em formato JSON
    [Produces("application/json")]

    //Metodo controlador que herda da controller base
    //Onde serah criadoos Endpoints (rotas)
    public class GeneroController : ControllerBase
    {

        /// <summary>
        /// Objeto _generoRepository que irah receber todos os metodos definidos a interface IGeneroRepository
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }


        /// <summary>
        /// Instancia o objeto _generoRepository para que haja referencia aos metodos no repositorio
        /// </summary>
        public GeneroController()
        {
            _generoRepository = new GeneroRepository();
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
                List<GeneroDomain> ListaGeneros = _generoRepository.ListarTodos();

                //Retorna a lista no formato JSON com o status Code ok(200)
                return Ok(ListaGeneros);
            }
            catch (Exception erro)
            {
                //Retorna um status Code BadRequest(400) e a menssagem do erro
                return BadRequest(erro.Message);
            }


        }


        /// <summary>
        /// EndPoint que aciona o metodo de cadastro de genero
        /// </summary>
        /// <param name="novogenero">Objeto recebido na requisicao</param>
        /// <returns>Retorna a resposta para o usuario(Front-End)</returns>
        [HttpPost]
        public IActionResult Post(GeneroDomain novogenero)
        {


            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                _generoRepository.Cadastrar(novogenero);

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
        /// EndPoint que aciona o metodo de Deletar genero no repositorio
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna que o genero foi deletado</returns>
        [HttpDelete ("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                _generoRepository.Deletar(id);

                //Retorna um status code 204(No Content)
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                //Retorna um status Code BadRequest(400) e a menssagem do erro
                return BadRequest(erro.Message);
            }
        }



    }
}
