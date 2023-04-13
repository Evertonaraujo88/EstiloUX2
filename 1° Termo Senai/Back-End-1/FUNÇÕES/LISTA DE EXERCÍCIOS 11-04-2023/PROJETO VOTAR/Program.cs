//1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
//ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

//Entrada
Console.WriteLine($"Digite seu ano de Nasmcimento.");
int Nascimento = int.Parse(Console.ReadLine());



int CalcData = DateTime.Now.Year - Nascimento;

if (CalcData >= 16 && CalcData <18)
{
    Console.WriteLine($"Você tem {CalcData} anos e já pode Votar, porém, não é Obrigado!!!");
    
}
else if (CalcData >= 18)
{
    Console.WriteLine($"Você tem {CalcData} anos já pode voltar, inclusive é obrigatório!!!");
    
}
else
{
    Console.WriteLine($"Você tem {CalcData} anos e ainda não pode Voltar!!");
    
}

