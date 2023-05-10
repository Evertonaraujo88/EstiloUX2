//2-Faça um programa que leia três números e mostre o maior e o menor deles.

//Entrada: "Digite três números de sua preferência: "
// int a
//int b
// int c

//Processamento:
// se (a >b && a>c)
//          " Maior número é {a}."
// se nao ( se (b>c))
//          " Maior numero e {b}"
//          se nao (c>a)
//          " Maior numero e {c}"

Console.WriteLine($"Digite um número: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite outo número: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite mais um número: ");
int c = int.Parse(Console.ReadLine());

//maior
if (a>b && a>c)
{
    Console.WriteLine($"O maior número é {a}");
    
}
else if (b>c)
{
    Console.WriteLine($"O maior número é {b}");
}
else
{
    Console.WriteLine($"O maior número é {c}");
}

//menor
if (a<b && a<c)
{
    Console.WriteLine($"O menor número é {a}");
    
}
else if (b<c)
{
    Console.WriteLine($"O menor número é {b}");
}
else
{
    Console.WriteLine($"O menor número é {c}");
}
