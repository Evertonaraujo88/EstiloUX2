// calculo de idade
// meses
//dias
//horas
//minutos

//entrada 
// informar a idade

//processamento

//meses
//idade*12

//dias
//idade*365

//horas
//idade*8766

//minutos
//idade*525960

//saida
// idade em meses
//idade em dias
//idade em horas
//idade em minutos

Console.WriteLine($"digite sua idade");
int idade = int.Parse(Console.ReadLine());

int meses = (idade * 12);
Console.WriteLine($"Sua idade em meses é: {meses} meses.");

int dias = (idade * 365);
Console.WriteLine($"Sua idade em dias é: {dias} dias.");

int horas = (idade * 8766);
Console.WriteLine($"Sua idade em horas é: {horas} horas.");

int minutos = (idade * 525960 );
Console.WriteLine($"Sua idade em minutos é: {minutos} minutos.");


