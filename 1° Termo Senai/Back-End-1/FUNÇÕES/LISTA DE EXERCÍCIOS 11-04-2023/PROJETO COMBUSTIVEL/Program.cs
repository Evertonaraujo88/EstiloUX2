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

float Alcool= 4.90f;
float Gasolina= 5.30f;

static double DescGasolina(float Gasolina, float litros)
{
    if (litros > 20)
    {
        return( litros * (Gasolina* 0.94));
    }
    else
    {
        return (litros * (Gasolina * 0.96));
    }
}

static double DescAlcool (float Alcool, float litros)
{
    if (litros > 20)
    {
        return( litros * (Alcool * 0.95) );
    }
    else
    {
        return (litros *(Alcool * 0.97));
    }
}
// Informar se é Alcool ou Gasolina
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
Console.WriteLine($"Informar quantos litros foram abastecidos: ");
float litros = float.Parse(Console.ReadLine());

//Processamento
    double VlAlcool = DescAlcool(Alcool, litros);
    double VlGasolina = DescGasolina(Gasolina, litros);
   
    switch (Combustivel)
{
    case 'A': if (litros <= 20)
    {
        Console.WriteLine($"O valor por {litros} litros a ser pago é R$ {Math.Round(VlAlcool,2)}.");
        
    }
    else
    {
        Console.WriteLine($"O valor por {litros} litros a ser pago é R$ {Math.Round(VlAlcool,2)}.");
    }

    break;

    case 'G': 
    if (litros <= 20)
    {
        Console.WriteLine($"O valor por {litros} litros a ser pago é R$ {Math.Round(VlGasolina,2)}.");
        
    }
    else
    {
        Console.WriteLine($"O valor por {litros} litros a ser pago é R$ {Math.Round(VlGasolina,2)}.");
    }

    break;    
    default:
    Console.WriteLine($"Operação inválida, escolha a opção correta!");
    break;
    
}


