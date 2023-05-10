//Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

//entrada
//Digite o dia do seu aniversário:
//Digite o mês do seu aniversário:
//digite o ano do seu nascimento:

//se (dia <= 31) então {
//              ( se (mês <= 12)) entao{
//                                  ( se (ano <= 2013)) entao{
//                                  "a data do seu aniversario e valida";}
//                                  se nao {"Ano invalido}
//              se nao{ "mes informado e invalido"}
//se nao{ "dia informado e invalido"}

Console.WriteLine($"Digite o dia do seu aniversário:");
int dia = int.Parse(Console.ReadLine());
if (dia <= 31)
{
    Console.WriteLine($"Digite o mês do seu aniversário:");
    int mes = int.Parse(Console.ReadLine());
    if (mes <= 12)
    {
        Console.WriteLine($"Digite o ano do seu aniversário:");
        int ano = int.Parse(Console.ReadLine());
        if (ano <= 2013)
        {
            Console.WriteLine($"A data do seu aniversario e válida");
            
        }
        else
        {
            Console.WriteLine($"Ano digitado é inválido");
            
        }
    }
    else
    {
        Console.WriteLine($"Mês informádo é inválido");
        
    }
}
else
{
    Console.WriteLine($"Dia informado é inválido!");
    
}

