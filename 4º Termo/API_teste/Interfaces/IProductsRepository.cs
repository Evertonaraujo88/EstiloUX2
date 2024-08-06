using API_teste.Domains;

namespace API_teste.Interfaces
{
    /// <summary>
    /// Interface para o repositório de produtos, definindo os métodos necessários para manipulação de produtos.
    /// </summary>
    public interface IProductsRepository
    {
        /// <summary>
        /// Obtém a lista de todos os produtos.
        /// </summary>
        /// <returns>Lista de produtos.</returns>
        public List<Product> GetProducts();

        /// <summary>
        /// Adiciona um novo produto.
        /// </summary>
        /// <param name="product">Objeto do tipo Product a ser adicionado.</param>
        public void Post(Product product);

        /// <summary>
        /// Remove um produto pelo seu identificador.
        /// </summary>
        /// <param name="id">Identificador único do produto a ser removido.</param>
        public void Delete(Guid id);

        /// <summary>
        /// Obtém um produto pelo seu identificador.
        /// </summary>
        /// <param name="id">Identificador único do produto.</param>
        /// <returns>Objeto do tipo Product.</returns>
        public Product GetById(Guid id);

        /// <summary>
        /// Atualiza um produto existente.
        /// </summary>
        /// <param name="id">Identificador único do produto a ser atualizado.</param>
        /// <param name="product">Objeto do tipo Product com as novas informações.</param>
        public void Put(Guid id, Product product);
    }
}
