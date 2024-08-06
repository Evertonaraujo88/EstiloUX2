using API_teste.Domains;
using API_teste.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        /// <summary>
        /// Obtém todos os produtos.
        /// </summary>
        /// <returns>Lista de produtos.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productsRepository.GetProducts();
            return Ok(products);
        }

        /// <summary>
        /// Obtém um produto pelo ID.
        /// </summary>
        /// <param name="id">ID do produto.</param>
        /// <returns>Produto correspondente ao ID.</returns>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var product = _productsRepository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        /// <summary>
        /// Adiciona um novo produto.
        /// </summary>
        /// <param name="product">Produto a ser adicionado.</param>
        /// <returns>Resultado da operação.</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _productsRepository.Post(product);
            return CreatedAtAction(nameof(Get), new { id = product.IdProduct }, product);
        }

        /// <summary>
        /// Atualiza um produto existente.
        /// </summary>
        /// <param name="id">ID do produto a ser atualizado.</param>
        /// <param name="product">Dados do produto a serem atualizados.</param>
        /// <returns>Resultado da operação.</returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingProduct = _productsRepository.GetById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            _productsRepository.Put(id, product);
            return NoContent();
        }

        /// <summary>
        /// Remove um produto pelo ID.
        /// </summary>
        /// <param name="id">ID do produto a ser removido.</param>
        /// <returns>Resultado da operação.</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var product = _productsRepository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productsRepository.Delete(id);
            return NoContent();
        }
    }
}
