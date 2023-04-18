/* Nesta aula vamos aplicar o seguinte projeto para gerenciamento de passagens aéreas pelo console:

Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados:
1- Nome do passageiro
2 -Origem/Destino
3-Data do Voo de 5 passageiros.

*****Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à:
 123456

O sistema deve exibir um menu com as seguintes opções:

1- Cadastrar passagem
2- Listar Passagens
0- Sair

Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).
 */

 //Entreda
 // Acesso por senha
 // se correta "entra no sistema" se errada "digita novamente"

 //processamento
 // Menu: 1- Cadastrar passagem
        //2- Listar Passagens
        //0- Sair
 // entrar com (nome, origem, destino, data do voo) de 5 passageiros


//saida
//perguntar se deseja cadastrar uma nova passagem(s/N)


//Variaveis
int qtdCadastro = 5;
string [] nome = new string [qtdCadastro] ;
string [] origem= new string [ qtdCadastro] ;
string [] destino= new string [qtdCadastro] ;
string [] dataVoo= new string [qtdCadastro] ;

int senhaCorreta = 123456;


//Funcoes

 static void cadastroPassagem (string[] nome, string[] origem, string[] destino, string[] dataVoo)
 {
    for (int i = 0; i < nome.Length; i++)
    {
        Console.WriteLine($"Digite o {i+1}º nome: ");
        nome[i] = Console.ReadLine();

        Console.WriteLine($"Digite a {i+1}º origem do Voo: ");
        origem[i] = Console.ReadLine();
        
        Console.WriteLine($"Digite o {i+1}º destino do Voo: ");
        destino[i] = Console.ReadLine();
        
        Console.WriteLine($"Digite a {i+1}º data do Voo: ");
        dataVoo[i] = Console.ReadLine();
        
    }
    
        
 }
  Console.WriteLine($"Digite o nome do usuário: ");
string usuario = Console.ReadLine();

Console.WriteLine($"Digite sua senha: ");
int senhaDigitada = int.Parse(Console.ReadLine());

while (senhaDigitada != senhaCorreta )
{
    Console.WriteLine($"Senha inválida, digite novamente!!!");
    senhaDigitada= int.Parse(Console.ReadLine());
    
}  

Console.WriteLine(@$"
--------------------------------
***PROJETO PASSAGENS AEREAS***
--------------------------------
");

Console.WriteLine(@$"
-----------------------------------
|                                 |
| Escolha a opção que deseja:     |
|                                 |
| 1 - Cadastrar Passagem          |
| 2 - Listar Passagen             |
| 0 - Sair                        |
-----------------------------------
");

char escolha = char.Parse(Console.ReadLine().ToUpper());

switch (escolha)
{
    case '1':
    cadastroPassagem(nome, origem, destino, dataVoo);
    break;

    case '2':
    Console.WriteLine($"listar");
    break;

    case '0':
    Console.WriteLine($"sair");
    break;
    
    default:
    Console.WriteLine($"Opção inválida!!");
    break;
}
while (escolha != 0);
