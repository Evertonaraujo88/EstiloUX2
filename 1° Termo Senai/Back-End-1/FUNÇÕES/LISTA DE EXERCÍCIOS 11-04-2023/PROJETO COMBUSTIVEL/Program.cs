// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


//ENTRDA
// Informar se eh:
// a - para alcool
// g - para gasolina

Console.WriteLine(@$"
-----------------------------------
|  PROJETO CALCULO DE COMBUSTIVEL |
|                                 |
| Qual combustivel ira abastecer: |
|                                 |
| A - Alcool                      |
| G - Gasolina                    |
-----------------------------------

");

char Combustivel = char.Parse(Console.ReadLine().ToUpper());

// Informar quantos litros foram abastecidos:
Console.WriteLine($"Informar quantos litros foi abastecido: ");
float litros = float.Parse(Console.ReadLine().ToUpper());

//Processamento
switch (Combustivel)
{
    case 'A':


    case "G": 
    
    default:
}

