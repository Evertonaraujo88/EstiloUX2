Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
--------------------
|   Programa para  |
|   calcular IMC   |
--------------------
");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente: ");
string? nome= Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso sistema {nome} ;)");

Console.WriteLine($"Informe o peso do paciente: ");
float peso = float.Parse(Console.ReadLine());

//so exemplo:
//Console.WriteLine($"informe a altura do paciente:");
//double altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse (Console.ReadLine());

float imc = (peso / (float)Math.Pow(altura,2));

Console.WriteLine($"O paciente {nome} tem o imc igual à : {imc}");

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrogado por utilizar nosso sistema !");
Console.ResetColor();







