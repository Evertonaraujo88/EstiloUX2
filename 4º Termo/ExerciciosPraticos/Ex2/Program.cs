//2 -Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética. Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por exemplo, bubble sort) para ordenar os nomes.


       
        string[] nomes = new string[5];

    
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write("Digite um nome: ", i + 1);
            nomes[i] = Console.ReadLine();
        }

        
        for (int i = 0; i < nomes.Length - 1; i++)
        {
            for (int j = 0; j < nomes.Length - i - 1; j++)
            {
                if (string.Compare(nomes[j], nomes[j + 1]) > 0)
                {
                    
                    string temp = nomes[j];
                    nomes[j] = nomes[j + 1];
                    nomes[j + 1] = temp;
                }
            }
        }

       
        Console.WriteLine("\nNomes cadastrados em ordem alfabética:");
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }
    

