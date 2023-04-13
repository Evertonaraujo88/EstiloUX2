//EXERCICIO DE FIXACAO
//escreve um programa que receba e imprima o nome e idade de 5 pessoas

string[] nomes = new string [5];
int[] idades = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine( $"Digite o {i+1}º nome: ");
    nomes[i]= Console.ReadLine();
    
    Console.WriteLine($"Digite a {i+1}º idade:");
    idades[i]= int.Parse(Console.ReadLine());     
}

for (int i = 0; i <5; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{i+1}) nome: {nomes[i]}");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"   idade: {idades[i]} anos");
    Console.ResetColor();
    Console.WriteLine($"");
    
}