/*Pesquise como funciona o algoritmo Fibonacci.
 Faça um programa que gere a série até que o valor seja maior que 500. 
 
 *** Serie Fibonacci***
 É uma sequência que tem seus primeiros numeros sendo 0 e 1...e os proximos números da sequência são os somatórios dos dos seus numeros..exemplo: 0, 1, 1, 2, 3, 5, 8, 13....
 
 */


//UTLILIZANZO FOR//
 Console.WriteLine($"Serie de Fibonacci");

 int num1 = 0;
 int num2 = 1;
 int auxiliar;

 for (var i = 0; i < 500; i++)
 {
    auxiliar = num1;
    num1 = num2;
    num2 = num1 + auxiliar;

    Console.WriteLine($" num2");

    if (num2 > 500)
    {
        Console.ReadLine();
         
    }
    
 }
 
 //UTILIZANDO
