    static string GerarTabuada(int numero)
    {
      
        string tabuada = "";

     
        for (int i = 1; i <= 10; i++)
        {
            tabuada += $"{numero} x {i} = {numero * i}\n";
        }

        return tabuada;
    }

  Console.Write("Digite um número para ver sua tabuada: ");
        int numero = int.Parse(Console.ReadLine());

    
        Console.WriteLine(GerarTabuada(numero));

