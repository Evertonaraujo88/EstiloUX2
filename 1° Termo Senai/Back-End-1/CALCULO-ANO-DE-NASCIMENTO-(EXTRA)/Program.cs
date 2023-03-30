Console.WriteLine($"Digite o Ano de seu Nascimento");
var Nascimento = (Console.ReadLine());

var data = DateTime.Now;
var formatada = String.Format("{0:yyyy}", data);

var anos = ((formatada) - Nascimento);

 