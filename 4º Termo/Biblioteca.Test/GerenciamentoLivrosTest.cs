using System;
using System.Collections.Generic;
using Xunit;
using Biblioteca;

namespace Biblioteca.Test
{
 
        public class GerenciamentoLivrosTest
        {
            // Teste unitário para o método AdicionarLivro
            [Fact]
            public void TestarAdicionarLivro()
            {
                // Arrange: Preparar os dados e objetos necessários para o teste
                var livro = new Livro
                {
                    Titulo = "O Senhor dos Anéis",
                    Autor = "J.R.R. Tolkien"
                };

                // Act: Executar o método que estamos testando
                GerenciamentoLivros.AdicionarLivro(livro);

                // Assert: Verificar se o livro foi adicionado corretamente
                var livros = GerenciamentoLivros.ObterLivros();
                Assert.Contains(livro, livros);
            }
        }
    
}
