//Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

//entrada do salario
//entrada do total dos gastos

//processamento:
//se salario > total dos gastos ......imprimir “Gastos dentro do orçamento”

//se nao....imprimir “Orçamento estourado”

Console.WriteLine($"informe o valor recebido de salario: ");
float salario = float.Parse (Console.ReadLine());

Console.WriteLine($"informe o valor total dos gastos: ");
float gastos =  float.Parse (Console.ReadLine());

if (salario > gastos){
    Console.WriteLine($"Gastos dentro do orçamento");   
} else {
    Console.WriteLine($"Orçamento estourado");
}
