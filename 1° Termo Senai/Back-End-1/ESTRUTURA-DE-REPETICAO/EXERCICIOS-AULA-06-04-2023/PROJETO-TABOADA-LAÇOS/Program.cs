/*6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

Exemplo: tabuada do 1, tabuada do 2, etc...
Dica: utilize um laço dentro do outro.*/

Console.WriteLine(@$"
--------------------------------
***PROJETO TABOADA DO 1 AO 10***
--------------------------------
");

int taboada;

Console.WriteLine($"Pressione enter saber a taboada: ");
Console.ReadLine();

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"-----------");
    
    for (int a = 0; a <= 10; a++)
    {
      
        taboada = a * i;

        Console.WriteLine(@$"{a} x {i} : {taboada}");
    }
    
    Console.WriteLine($"-----------");       
}