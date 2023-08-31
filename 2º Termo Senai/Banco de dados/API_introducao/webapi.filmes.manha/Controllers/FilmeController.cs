using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.filmes.manha.Domains;
using webapi.filmes.manha.Interfaces;
using webapi.filmes.manha.Repositories;
using webapi.filmes.manha.Repository;

namespace webapi.filmes.manha.Controllers
{
    //Define que a rita de yna requisicai sera ni seguinte formato
    // dominio/api/nomeControle
    //exemplo: http://localhost:5000/api/filme
    [Route("api/[controller]")]

    //Define que eh um controlador de API
    [ApiController]

    //Define que o tipo de resposta da API sera em formato JSON
    [Produces("application/json")]

    //Metodo controlador que herda da controller base
    //Onde serah criadoos Endpoints (rotas)
    public class FilmeController : ControllerBase
    {
        /// <summary>
        /// Objeto _filmeRepository que irah receber todos os metodos definidos a interface IFilmeRepository
        /// </summary>
        private IFilmesRepository _filmeRepository { get; set; }


        /// <summary>
        /// Instancia o objeto _filmeRepository para que haja referencia aos metodos no repositorio
        /// </summary>
        public FilmeController()
        {
            _filmeRepository = new FilmeRepository();
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
                List<FilmeDomain> ListaFilmes = _filmeRepository.ListarTodos();

                //Retorna a lista no formato JSON com o status Code ok(200)
                return Ok(ListaFilmes);
            }
            catch (Exception erro)
            {
                //Retorna um status Code BadRequest(400) e a menssagem do erro
                return BadRequest(erro.Message);
            }


        }

        /// <summary>
        /// EndPoint que aciona o metodo de cadastro de filmes
        /// </summary>
        /// <param name="novofilme">Objeto recebido na requisicao</param>
        /// <returns>Retorna a resposta para o usuario(Front-End)</returns>
        [HttpPost]
        public IActionResult Post(FilmeDomain novofilme)
        {


            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                _filmeRepository.Cadastrar(novofilme);

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
        /// EndPoint que aciona o metodo de Deletar filme no repositorio
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna que o filme foi deletado</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                _filmeRepository.Deletar(id);

                //Retorna um status code 204(No Content)
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                //Retorna um status Code BadRequest(400) e a menssagem do erro
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// EndPoint que aciona o metodo de buscar filme por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna o genero que foi encontrado</returns>
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {

            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(id);

                if (filmeBuscado == null)
                {
                    return NotFound("Nenhum filme foi encontrado!!");
                }

                //Retorna um status code 204(No Content)

                return Ok(filmeBuscado); 
            }
            catch (Exception erro)
            {
                //Retorna um status Code BadRequest(400) e a menssagem do erro
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo AtualizarPorUrl
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novofilme"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult PutIdURL(int id, FilmeDomain filme)
        {

            try
            {
                FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(id);

                if (filmeBuscado == null)
                {
                    return NotFound("Nenhum Filme foi encontrado!!");
                }


                _filmeRepository.AtualizarIdUrl(id, filme);

                return StatusCode(200);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }



    }
}
