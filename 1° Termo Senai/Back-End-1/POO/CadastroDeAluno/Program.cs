/* Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
 
Crie uma classe Aluno com as seguintes propriedades:

Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
Também teremos os métodos: 

VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

obs:
bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
outros casos a mensalidade será integral
Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

Acrescente o que achar necessário. */

//Instanciando a classe Aluno
using CadastroDeAluno;

Aluno cad = new Aluno();

Console.WriteLine(@$"
---------------------------
|    CADASTRO DE ALUNOS   |
---------------------------

");
Console.WriteLine($"Digite o nome do aluno: ");
cad.nome = Console.ReadLine();

Console.WriteLine($"Digite o nome do curso: ");
cad.curso = Console.ReadLine();

Console.WriteLine($"Digite a idade do aluno: ");
cad.idade = Console.ReadLine();

Console.WriteLine($"O aluno é bolsista? s para sim ou n para não");
 string respbolsista = (Console.ReadLine().ToLower());

//Operador ternário
cad.bolsista = respbolsista == "s" ? true : false;

 //if composto
 /* if (respbolsista == "s")
 {
    cad.bolsista = true;
 }
 else
 {
    cad.bolsista = false;
 }
 */
Console.WriteLine($"Digite a media final do aluno: ");
cad.mediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor da mensalidade: ");
cad.valorDaMensalidade = float.Parse(Console.ReadLine());

char escolha;
do
{
  Console.WriteLine(@$"
-----------------------------------
|                                 |
| ESCOLHA A OPÇÃO QUE DESEJA:     |
|                                 |
| 1 - VER A MEDIA                 |
| 2 - VALOR DA MENSALIDADE        |
| 0 - SAIR                        |
-----------------------------------
");

escolha= char.Parse(Console.ReadLine());

    switch (escolha)
{
    case '1':
    Console.WriteLine($"A media do aluno {cad.nome} é: {cad.VerMediaFinal}");
    
    break;

    case '2':
    Console.WriteLine($"O valor da mensalidade é {cad.VerMensalidade()}");
    break;

    case '0':
    Console.WriteLine($"Ate a próxima!!");
    break;
        
    default:
    Console.WriteLine($"Opção inválida!!!");
    break;
}
  
} while (escolha != '0');
     
