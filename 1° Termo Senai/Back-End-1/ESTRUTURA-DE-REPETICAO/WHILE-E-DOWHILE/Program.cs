//Escreva um algoritmo que pergunte a idade de um artista famoso e continue perguntando até ela acertar a idade correta.

/*bool idadeCerta = false;

while (idadeCerta == false)
{
    Console.WriteLine($"Qual a idade do Pericles ?");
    int idade = int.Parse(Console.ReadLine());

    if (idade == 53)
    {
       idadeCerta = true;
        
    }

}*/


//UTILIZANDO DO WHILE
Console.WriteLine($"Qual a idade do Pericles? ");
int idade = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"idade incorreta!!");
    idade = int.Parse(Console.ReadLine());
    
    
} while (idade != 53 );