using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using ControleInventario;

namespace ControleInventario.Test
{
    public class InventarioTest
    {
        
        [Fact]
        public void TestarAdicionarProduto()
        {
            // Arrange: Preparar os dados e objetos necessários para o teste
            Inventario.AdicionarProduto("ProdutoA", 10);
            Inventario.AdicionarProduto("ProdutoA", 5);
            Inventario.AdicionarProduto("ProdutoB", 8);

            // Act & Assert: Verificar se os produtos foram adicionados corretamente
            // Verifica se a quantidade do ProdutoA foi incrementada corretamente
            Assert.Equal(15, Inventario.ObterQuantidadeProduto("ProdutoA"));
            
            
            // Verifica se o ProdutoB foi adicionado corretamente
            Assert.Equal(8, Inventario.ObterQuantidadeProduto("ProdutoB"));
        }

        
        [Fact]
        public void TestarObterQuantidadeProduto()
        {
            // Arrange: Preparar os dados e objetos necessários para o teste
            Inventario.AdicionarProduto("ProdutoC", 20);

            // Act: Obter a quantidade de um produto pelo nome
            var quantidade = Inventario.ObterQuantidadeProduto("ProdutoC");

            // Assert: Verificar se a quantidade obtida é a esperada
            Assert.Equal(20, quantidade);
        }

        // Teste unitário para verificar a quantidade de um produto inexistente
        [Fact]
        public void TestarObterQuantidadeProdutoInexistente()
        {
            // Act: Obter a quantidade de um produto inexistente
            var quantidade = Inventario.ObterQuantidadeProduto("ProdutoInexistente");

            // Assert: Verificar se a quantidade obtida é zero
            Assert.Equal(0, quantidade);
        }
    }
}
