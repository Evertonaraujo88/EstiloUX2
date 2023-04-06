//Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
/*
A.Total de Homens;      
B.Total de Mulheres;      
C.Média de idade dos Homens;      
D.Média de idade das mulheres.
*/

string sexo;
int sexoh = 0;
int idadeh = 0;
float pesoh = 0;
int sexom = 0;
int idadem = 0;
float pesom = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite seu sexo : (sendo 'h' para homem e 'm' para mulher)");
sexo = Console.ReadLine();

if (sexo == "h")
{
    Console.WriteLine($"Digite sua idade: ");
    idadeh = idadeh + int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite seu peso: ");
    pesoh = pesoh + int.Parse(Console.ReadLine());
    
    sexoh = sexoh +1;   
        
}
else 
if (sexo == "m")
{
    Console.WriteLine($"Digite sua idade: ");
    idadem = idadem + int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite seu peso: ");
    pesom = pesom + int.Parse(Console.ReadLine());
    
    sexom = sexom +1;   
}
else
{
    Console.WriteLine($"Dados inválidos!!!!");
    
}

}

Console.WriteLine($"O total de Homens é: {sexoh}.");
Console.WriteLine($"O total de Mulheres é: {sexom}.");
Console.WriteLine($"A média de idade dos Homens é: {idadeh/sexoh}.");
Console.WriteLine($"A média de idade das Mulheres é: {idadem/sexom}.");
Console.WriteLine($"A média de peso dos Homens é: {pesoh/sexoh}.");
Console.WriteLine($"A média de peso das Mulheres é: {pesom/sexom}.");






