/* Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
Menu de opções : dólar para real, real para dólar, sair
Personalizar a resposta, usando recursos da linguagem(Bibliotecas) */

using Exercicio_ConversorDeMoedas;

Console.WriteLine(@$"
 _____________________
|                     |
|CONVERSOR DE MOEDAS  |
|_____________________|

");


Console.WriteLine(@$"
 _____________________
|                     |
|    MENU DE OPÇÕES   |
|                     |
| 1- DOLAR PARA REAIS |  
| 2- REAIS PARA DOLAR |
| 0- SAIR             |
|_____________________|

");


char resp = char.Parse(Console.ReadLine()); 


switch (resp)
{
    case '1':
    ConversorDeMoedas.DolarParaReal(ConversorDeMoedas.ValorParaConverter);
    break;

    case '2': 
    ConversorDeMoedas.RealParaDolar(ConversorDeMoedas.ValorParaConverter);
    break;

    default:
    Console.WriteLine($"Operação inválida!!");
    break; 
}


ConversorDeMoedas.RealParaDolar(100);

ConversorDeMoedas.DolarParaReal(100);