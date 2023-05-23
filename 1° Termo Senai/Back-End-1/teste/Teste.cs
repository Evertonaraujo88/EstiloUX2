using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste
{
    public class Teste
    {
        
    static void Piscar(string[] args)
    {
        BlinkingMessage(@$"
                **************************************
                
                  GERENCIAMENTE DE PRODUTOS E MARCAS  
                
                **************************************
                
                ", ConsoleColor.Yellow, ConsoleColor.Red);
    }

    static void BlinkingMessage(string message, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
    {
        while (true)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(1000); // Tempo de espera para alternar as cores (500ms = 0,5 segundos)
            Console.ResetColor();
            //Console.Clear();
            Thread.Sleep(1000); // Tempo de espera antes de mostrar a mensagem novamente
        }
    }
    }
}