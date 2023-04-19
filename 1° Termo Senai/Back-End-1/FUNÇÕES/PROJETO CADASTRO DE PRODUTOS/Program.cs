/* Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

Os produtos terão os seguintes atributos:
string Nome
float Preco
bool Promocao (se está em promoção ou não)

O sistema deverá ter as seguintes funcionalidades:
CadastrarProduto
ListarProdutos
MostrarMenu
Crie função(ões) para otimizar o código.
Incremente o que achar necessário. Utilize sua lógica e sua criatividade. */

//Algoritmo
//Lista para armazenar nome, preço e promoção
//menu de opções


string [] nomes = new string [10];
float [] precos = new float [10];
bool [] promocao = new bool [10];


static string promo ( bool promocao)
{
if (promocao == true)
{
    return "Está na promoção!";
}
else
{
    return "Não está na promoção!";
}
}

//Menu de opções
Console.WriteLine(@$"
-----------------------------------
|  GERENCIAMENTO DE PRODUTOS:     |
|                                 |
| O que deseja fazer?             |
|                                 |
| 1 - Cadastrar Produto           |
| 2 - Listar Produtos             |
| 0 - Sair do menu                |
-----------------------------------
");
Console.WriteLine($"Digite a opção que deseja:");
char escolha = char.Parse(Console.ReadLine().ToUpper());

switch (escolha)
{
    case '1':

    for (int i = 0; i < 10 ; i++)
    {
        Console.WriteLine($"Digite o nome do produto:");
        nomes[i] = Console.ReadLine();
        
        Console.WriteLine($"Digite o preço do produto:");
        precos[i] = float.Parse(Console.ReadLine());

        Console.WriteLine($"O produto está em promoção: (s/n)");
        
        
        
    }
    default:
}