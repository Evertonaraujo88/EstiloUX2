//Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada letra do alfabeto aparece no texto.


        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine().ToLower();

        // instanciando Dicionário para armazenar a contagem de cada letra
        Dictionary<char, int> contagemLetras = new Dictionary<char, int>();

  
        for (char c = 'a'; c <= 'z'; c++)
        {
            contagemLetras[c] = 0;
        }

        foreach (char c in texto)
        {
            if (contagemLetras.ContainsKey(c))
            {
                contagemLetras[c]++;
            }
        }


        Console.WriteLine("\nContagem de letras no texto:");
        foreach (var item in contagemLetras)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

