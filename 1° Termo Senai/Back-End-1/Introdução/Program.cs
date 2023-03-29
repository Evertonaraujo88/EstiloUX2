//string name = "Everton";
//Console.WriteLine(name);

//int idade = 34;
//Console.WriteLine("A idade do " + name + " é " + idade + " anos.");

//const int idade = 34;
//idade = 50;

// //diferente de
// Console.WriteLine( 5 != 6);

//operadores lógicos

// && : e
// || : ou 
// ! : não

// Console.WriteLine(5 == 5 && 8 == 8);// TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 5);// TRUE && FALSE = FALSE
// Console.WriteLine(5 == 6 && 8 == 8);// FALSE && TRUE = FALSE
// Console.WriteLine(5 == 6 && 8 == 5);// FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 || 3 == 3);// TRUE || TRUE = TRUE
// Console.WriteLine(2 == 2 || 3 == 4);// TRUE || FALSE = TRUE
// Console.WriteLine(2 == 4 || 3 == 3);// FALSE || TRUE = TRUE
// Console.WriteLine(2 == 4 || 3 == 5);// FALSE || FALSE = FALSE

// Console.WriteLine((2 == 4 || 4 == 4) && (7 == 6));

// Console.WriteLine(!(2 == 2 || 3 == 3));

//Crie um programa para calcular o IMC de uma pessoa

//Algoritmo
//entrada: nome, idade, peso, altura
//processamento: peso dividido por altura ao quadrado

//entrada
string nome = "Everton";
int idade = 34;
float peso = 86;
float altura = 1.75f;

//processamento
float imc = peso / (altura * altura);

//saída
Console.WriteLine($"O IMC do " + nome + " é de : " + Math.Round(imc,2));
