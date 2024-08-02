using ConversaoTemperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturaTest
{
    public class ConversorTemperaturaTest
    {
        //Teste unitário para o método ConverterCelsiusParaFahrenheit usando Theory e InlineData
        [Theory]
        [InlineData(0, 32)]        // 0°C é igual a 32°F
        [InlineData(100, 212)]     // 100°C é igual a 212°F
        [InlineData(-40, -40)]     // -40°C é igual a -40°F
        [InlineData(37, 98.6)]     // 37°C é igual a 98.6°F
        [InlineData(25, 77)]       // 25°C é igual a 77°F

        public void TestarConverterCelsiusParaFahrenheit(double celsius, double resultadoEsperado)
        {
            // Act: Executar o método que estamos testando
            var resultado = ConversorTemperatura.ConverterCelsiusParaFahrenheit(celsius);

            // Assert: Verificar se o resultado é o esperado
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
