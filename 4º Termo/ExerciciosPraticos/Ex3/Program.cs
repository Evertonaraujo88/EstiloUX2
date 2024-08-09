//Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar os números pares.

        int[] numeros = new int[10];
        
        int somaPar = 0;
       
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite um numero: ", i + 1);
            numeros[i] = int.Parse(Console.ReadLine());
        }
       
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0) 
            {
                somaPar += numeros[i]; 
            }
        }

        Console.WriteLine("\nA soma dos números pares do vetor é: " + somaPar);