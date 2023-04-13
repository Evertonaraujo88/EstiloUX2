// Faça um projeto utilizando um temporizador (thead.sleep) 

static void BarraCarregamento (string texto, int QuantidadeDePontinhos, int Tempo)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.Write(texto);

    for (int i = 0; i < QuantidadeDePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep (Tempo);
        
    }
    Console.ResetColor();
}