/* 3 - Faça um algoritmo para ler: 
    - a descrição do produto (nome), 
    - a quantidade adquirida
    - o preço unitário. 

Calcular e escrever o total:
- (total = quantidade adquirida * preço unitário), 
- o desconto
- o total a pagar (total a pagar = total - desconto), 

sabendo-se que:
- Se quantidade <= 5 o desconto será de 2%
- Se quantidade > 5 e quantidade <=10 o desconto será de 3%
- Se quantidade < 10 o desconto será de 5%
Dica: utilize if / else if / else */


using System.Globalization;

float total;
double totalapagar;
float desconto;

//Entrada
Console.WriteLine($"Digite o nome do Produto: ");
String produto = Console.ReadLine();

Console.WriteLine($"Digite a quantidade de produtos que foram adquiridos: ");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor por unidade: ");
float vlunidade = float.Parse(Console.ReadLine());

//Processamento
if (quantidade <= 5)
{
    total = (quantidade * vlunidade);
    desconto = ((total * 2 )/100);
    totalapagar= (total - desconto);
}
else if (quantidade <=10)
{
    total = (quantidade * vlunidade);
    desconto = ((total * 3 )/100);
    totalapagar= (total - desconto);
}
else
{
    total = (quantidade * vlunidade);
    desconto = ((total * 5 )/100);
    totalapagar= (total - desconto);
}

//Saída

Console.WriteLine(@$"
O valor a ser pago por {quantidade} unidades de {produto} é {Math.Round(total,2).ToString("C", new CultureInfo("pt-BR"))}.
Aplicando desconto de {Math.Round(desconto,2).ToString("C", new CultureInfo("pt-BR"))}.
O total a pagar é {Math.Round(totalapagar,2).ToString("C", new CultureInfo("pt-BR"))}.
");

