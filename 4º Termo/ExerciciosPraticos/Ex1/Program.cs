// ex1 - Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.

System.Console.WriteLine(" Digite um número:");
int num = int.Parse(Console.ReadLine());

if (num %2 == 0)
{
    System.Console.WriteLine(" O número digitado é Par!!");
} else
{
    System.Console.WriteLine("O número digitado é Ímpar");
}
