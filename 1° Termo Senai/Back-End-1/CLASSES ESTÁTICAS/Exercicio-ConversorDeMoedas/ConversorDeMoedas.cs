using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_ConversorDeMoedas

{
    

    public static class ConversorDeMoedas
    {
        public static float ValorDolar { get; private set; } = 5.44f;

        public static float ValorParaConverter;


        public static void RealParaDolar (float ValorParaConverter)
        {
            float conversor = ValorParaConverter * ValorDolar;

           Console.WriteLine ($"{conversor:C}");
            
        }
        public static void DolarParaReal (float ValorParaConverter)
        {
            float conversor = ValorParaConverter / ValorDolar;

            //especificar de moeda CultureInfo.CreateSpecificCulture("codigo do pais")
           Console.WriteLine ($"{(conversor).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
        
        }
    }
}