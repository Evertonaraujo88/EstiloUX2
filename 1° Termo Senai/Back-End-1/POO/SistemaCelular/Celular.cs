using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCelular
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado = false;

        public void Ligar()
        {
            
            if (Ligado == false)
            {
                this.Ligado = true;
                Console.WriteLine($"Ligando...");
            }else
            {
                Console.WriteLine($"Ligando...");
            }
            
        }
        
        public void Desligar()
        {
            Console.WriteLine($"Desligando...");
            this.Ligado = false;
                    }

        public void FazendoLigacao()
        {
            Console.WriteLine($"Em ligação!!!!");
                      
        }

        public void EnviarMensagem()
        {
            Console.WriteLine($"Enviando Mensagem...");
                    }

        public void CorCelular()
        {
            if (this.Cor == "azul")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (this.Cor == "preto")
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (this.Cor == "amarelo")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (this.Cor == "vermelho")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (this.Cor == "verde")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (this.Cor == "branco")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
}