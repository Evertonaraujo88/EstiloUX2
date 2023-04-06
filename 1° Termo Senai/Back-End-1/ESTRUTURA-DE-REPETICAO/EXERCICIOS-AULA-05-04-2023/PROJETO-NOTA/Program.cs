//faca um programa que peca uma nota de zero a dez. Mostre uma mensagem caso o valor seja invalido e continue pedindo até que o usuário informe o valor correto.

//entreda
//"Digite a nota"

//processamento
// do
// "Nota informada inválida!"
// nota= cwl
// while (nota>=10 ou nota<=0)

Console.WriteLine(@$"
PROGRAMA VALIDAÇÃO DE NOTA:

*Digite sua nota entre 0 e 10 :

");

float nota = float.Parse(Console.ReadLine());

while (nota >= 11 || nota < 0)
{
    Console.WriteLine($"Nota informada invalida!!!");
    nota = float.Parse(Console.ReadLine());
    
}
Console.WriteLine($"Nota cadastrada com sucesso!!!");
