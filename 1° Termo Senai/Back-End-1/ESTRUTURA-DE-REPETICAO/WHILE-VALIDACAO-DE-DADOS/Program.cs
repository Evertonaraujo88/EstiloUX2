//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

while (nome.Length == 1)
{
    Console.WriteLine($"O nome invalido");
    nome = Console.ReadLine();
    
}
Console.WriteLine($"digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

while ( idade >=101 || idade <0)
{
  Console.WriteLine($"Idade invalida!!!!");
  idade = int.Parse(Console.ReadLine());
    
}
Console.WriteLine($"Digite seu salario: ");
float salario = float.Parse(Console.ReadLine());

while (salario <= 0)
{
Console.WriteLine($"Salario invalido!");
salario = float.Parse(Console.ReadLine());

}
Console.WriteLine (@$"
Digite seu estado civel, sendo:
s - solteiro(a)
c - casado(a)
v - viuvo(a) 
d - divorciado(a)
");

string estadoCivil = Console.ReadLine();

while (estadoCivil != "s" && estadoCivil!= "c" && estadoCivil!="v" && estadoCivil!="d")
{
    Console.WriteLine($"Estado Civil invalido!!!");
    estadoCivil = Console.ReadLine();
    
}
Console.WriteLine($"Cadastro realizado com sucesso!!!");
