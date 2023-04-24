using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_com_POO
{
    public class ClassCalculadora
    {
        public float num1;
        public float num2;
        public float Soma()
        {
            return (this.num1 + this.num2); //usando o operador "this" para chamar propriedades ou metodos da propria classe
        }

        public float Subtracao()
        {
            return(num1 - num2);
        }

        public float Multiplicacao()
        {
            return(num1 * num2);
        }

        public float Divisao()
        {
            while (num2 == 0)
            {
                Console.WriteLine($"O dividendo precisar ser maior que zero!!");
            }
            return (num1 / num2);
        }
    }
}