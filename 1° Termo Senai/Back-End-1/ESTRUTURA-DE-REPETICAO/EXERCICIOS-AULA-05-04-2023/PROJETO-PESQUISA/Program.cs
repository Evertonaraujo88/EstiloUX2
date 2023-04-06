/*1. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:

A. O número de pessoas que responderam SIM.

B. O número de pessoas que responderam NÃO;

C. O número de mulheres que responderam SIM;

D. A porcentagem de homens que responderam NÃO entre todos

E. os homens analisados.*/

string sexo="";
string resp;
string respsim;
string respnao;


   


     while (sexo == "h" || sexo =="m")
     {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Digite o sexo do entrevistado (h para homem ou m para mulher): ");
            sexo = Console.ReadLine();

            while (sexo == "h")
            {
                Console.WriteLine($"Gostou do produto lançado? (s para sim ou n para não)");
                
            }
            
        }
        
     }
     
     Console.WriteLine($"Sexo digitado invalido!!!!");   
     
    

