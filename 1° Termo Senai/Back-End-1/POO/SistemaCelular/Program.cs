
/* Faça em sua máquina utilizando os mesmos conceitos dado em aula.
Crie uma Classe de um Celular, com as propriedades:
- cor
- modelo
- tamanho
- ligado(booleano).

Com os métodos:
- ligar
- desligar
-  fazer ligação
- enviar mensagem.

Só será possível executar tais métodos se o celular estiver ligado.
Envie o link do repositório como entrega desta atividade. */

using SistemaCelular;

Celular cel = new Celular();

Console.WriteLine($"Digite a cor do celular: ");
cel.Cor = Console.ReadLine();

Console.WriteLine($"Digite o modelo do celular: ");
cel.Modelo = Console.ReadLine();

Console.WriteLine($"Digite o tamanho do celular: ");
cel.Tamanho = Console.ReadLine();

Console.WriteLine($"O celular esta ligado? s para sim e n para nao ");
string resp = Console.ReadLine().ToLower();

cel.Ligado = resp == "s" ? true : false;

if (cel.Ligado == true)
{
char escolha;
do
{
  Console.WriteLine(@$"
-----------------------------------
|                                 |
| ESCOLHA A OPÇÃO QUE DESEJA:     |
|                                 |
| 1 - LIGAR O CELULAR             |
| 2 - DESLIGAR O CELULAR          |
| 3 - FAZER LIGAÇÃO               |
| 4 - ENVIAR MENSAGEM             |
|                                 |
| 0 - SAIR                        |
-----------------------------------
");

escolha= char.Parse(Console.ReadLine());

    switch (escolha)
{
    case '1':
    cel.Ligar();
    
    break;

    case '2':
    cel.Desligar();
    break;

    case '3':
    cel.FazendoLigacao();
    break;

    case '4':
    cel.EnviarMensagem();
    break;

    case '0':
    Console.WriteLine($"Ate a próxima!!");
    break;
        
    default:
    Console.WriteLine($"Opção inválida!!!");
    break;
}
  
} while (escolha != '0');
     

}



