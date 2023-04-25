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

    }
}