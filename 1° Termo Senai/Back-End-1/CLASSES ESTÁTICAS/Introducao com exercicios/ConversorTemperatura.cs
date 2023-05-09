using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLASSES_ESTÁTICAS
{
    public static class ConversorTemperatura
    {

        //membro estatico
        public static float Temperatura { get; set; }

        //metodo estático para converter temperatura de celcius para fahreinheit
        public static float CelsiusParaFahreunheit(float temperaturaCelsius)
        {
            //logica da função
            //converter

            Temperatura = temperaturaCelsius;

            float fahreinheit = (Temperatura * 1.8f) + 32;

            return fahreinheit;
        }

        public static float FahreinheitParaCelsius (float temperaturaFahreinheit)
        {
            //logica da funcao
            //converter

            Temperatura = temperaturaFahreinheit;

            float celsius = (Temperatura - 32) * 0.55f;

            return celsius;
        }
    }
}