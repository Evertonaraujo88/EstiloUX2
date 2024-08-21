using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperatura
{
    public static class ConversorTemperatura
    {
        //Método para converter Celsius para Fahrenheit
        public static double ConverterCelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
