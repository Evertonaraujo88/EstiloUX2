using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoEmail.Test
{
    public class ValidadorTest
    {
        //Teste unitário para o método ValidarEmail usando Theory e InlineData

        //Theory: é usado para indicar que um método de teste deve ser executado várias vezes com diferentes conjuntos de dados.
        [Theory]

        //InlineData: é usado em conjunto com [Theory] para fornecer os dados de entrada para o método de teste.
        [InlineData("everton@email.com", true)]
        [InlineData("email@email", false)]
        [InlineData("senai.com", false)]
        [InlineData("senai@.com", true)]
        [InlineData("", false)]
        [InlineData(null, false)]

        public void TestarValidarEmail(string email, bool resultadoEsperado)
        {
            // Act: Executar o método que estamos testando
            var resultado = Validador.ValidarEmail(email);

            // Assert: Verificar se o resultado é o esperado
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
