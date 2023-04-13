//Faça um programa que receba um número inteiro e mostre a sua tabuada.

//ENTRADA
//Digite um numero que deseja saber sua taboada:

//PROCESSAMENTO
//tabuada = num * i
//i=0
//i++

Console.WriteLine(@$"
---------------------
***PROJETO TABOADA***
---------------------
");
int taboada;
Console.WriteLine($"Digite um número que deseja saber sua taboada: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    taboada = num * i;
    
    Console.WriteLine($" {num} x {i} : {taboada}");
    
}
