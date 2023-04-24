using Calculadora_com_POO;


//INSTACIANDO A CLASSE CALCULADORA
ClassCalculadora calc = new ClassCalculadora();

Console.WriteLine($"{calc.num1}");


 Console.WriteLine(@$"
-----------------------------------
|      PROJETO CALCULADURA        |
|                                 |
| QUAL OPERAÇÃO MATEMÁTICA DESEJA:|
|                                 |
| 1 - ADIÇÃO                      |
| 2 - SUBTRAÇÃO                   |
| 3 - MULTIPLICAÇÃO               |
| 4 - DIVISÃO                     |
| 0 - SAIR                        |
-----------------------------------
");

char escolha= char.Parse(Console.ReadLine());

Console.WriteLine($"Digite o 1º número: ");
calc.num1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o 2º número: ");
calc.num2 = float.Parse(Console.ReadLine());

switch (escolha)
{   
    case'1':
    {
        Console.WriteLine($"Resultado: {calc.Soma()}.");  
    }
    break;

    case'2':
    {
        Console.WriteLine($"Resultado: {calc.Subtracao()}.");  
    }
    break;

    case'3':
    {
        Console.WriteLine($"Resultado: {calc.Multiplicacao()}."); 
    }
    break;
    
    case'4':
    {
        Console.WriteLine($"Resultado: {calc.Divisao()}.");
    }
    break;
    
    default:{
        Console.WriteLine($"Operação inválida!!!");

    }
    break;
}

 