 int anoNascimento;
 int idade;
 int idadeEmSemana;
 
 int anoAtual = DateTime.Now.Year;

 Console.Write($"Digite o ano do nascimento :");
 
 anoNascimento = int.Parse(Console.ReadLine());

 idade = (anoAtual - anoNascimento);
 idadeEmSemana = (idade*52);

 Console.Write($"sua idade é {idade} em anos e {idadeEmSemana} em semanas.");
 