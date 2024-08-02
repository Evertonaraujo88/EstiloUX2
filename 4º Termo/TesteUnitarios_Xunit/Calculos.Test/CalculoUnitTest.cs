using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        //AAA : Act, Arrange, Assert (Agir, Organizar e Assertir)

        //indica que eh um metodo de teste
        [Fact]
        public void TestarMetodoSomar()
        {
            //Arrenge: Organizar os dados
            var x1 = 4.1;
            var x2 = 5.9;

            var valorEsperado = 10;

            //Act: Agir
            var soma = Calculo.Somar(x1, x2);

            //Assert: Provra
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void TestarMetodoSubtrair()
        {
            //Arrenge: Organizar os dados
            var x1 = 6;
            var x2 = 4;

            var valorEsperado = 2;

            //Act: Agir
            var subtrair = Calculo.Subtrair(x1, x2);

            //Assert: Provra
            Assert.Equal(valorEsperado, subtrair);
        }

        [Fact]
        public void TestarMetodoMultiplicar()
        {
            //Arrenge: Organizar os dados
            var x1 = 6;
            var x2 = 4;

            var valorEsperado = 24;

            //Act: Agir
            var multiplicar = Calculo.Multiplicar(x1, x2);

            //Assert: Provra
            Assert.Equal(valorEsperado, multiplicar);
        }

        [Fact]
        public void TestarMetodoDividir()
        {
            //Arrenge: Organizar os dados
            var x1 = 20;
            var x2 = 5;

            var valorEsperado = 4;

            //Act: Agir
            var dividir = Calculo.Dividir(x1, x2);

            //Assert: Provra
            Assert.Equal(valorEsperado, dividir);
        }
    }
}
