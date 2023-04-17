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


static bool login (int senha)
{
    int senhaCorreta = 123456;

    while (senha == senhaCorreta)
    {
        Console.WriteLine($"Senha incorreta!");
    }

return(true);
}

Console.WriteLine($"Digite a senha de acesso:");
int senha = int.Parse(Console.ReadLine());
