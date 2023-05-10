//Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
//A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
//Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

//Use a estrutura condicional Switch Case.

//entrada:
//Escolha a bebida desejada:
//1 - coca-cola
//2 - Guaraná Antartica
//3 - Soda
//4 - Suco de laranja


//processamento
//swicth (bebida)
//case"coca"
//case"Guaraná"
//case"Soda"
//case"suco"

//saida:
//Sua {bebida} esta saindo geladinha!
//SUa {bebida} esta saindo em temperatura ambiente!

string bebida="";

Console.WriteLine(@$"
-----------------------------------
|    PROJETO MAQUINA DE BEBIDAS   |
|                                 |
|  Escolha a bebida desejada:     |
|                                 |
| c - para Coca-cola              |
| g - Guaraná Antártica           |
| s - Soda                        |
| l - Suco de Laranja             |
-----------------------------------

");

//Operacao escolhida
char menu = char.Parse(Console.ReadLine());

switch (menu)
{
    case 'c':
        bebida = "Coca-Cola";
        break;
       
    case 'g':
        bebida = "Guaraná Antártia";
        
        break;

    case 's':
        bebida = "Soda";
        break;

    case 'l':
        bebida = "Suco de Laranja";
        break;

    default:
        Console.WriteLine($"Operacao invalida!!!");
        break;

}

Console.WriteLine($"Deseja adicionar gelo na(o) {bebida}? S para sim ou N para nao");
        string gelo = (Console.ReadLine().ToUpper());

        if (gelo == "S")
        {
            Console.WriteLine($"Saindo {bebida} gelada!!!!!");

        }else
        {
            Console.WriteLine($"Saindo {bebida} em temperatura ambiente!!");
        }

