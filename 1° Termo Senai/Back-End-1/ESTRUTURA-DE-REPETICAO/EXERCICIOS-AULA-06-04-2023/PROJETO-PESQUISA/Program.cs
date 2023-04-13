/*1. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:

A. O número de pessoas que responderam SIM.

B. O número de pessoas que responderam NÃO;

C. O número de mulheres que responderam SIM;

D. A porcentagem de homens que responderam NÃO entre todos

E. os homens analisados.*/
Console.WriteLine(@$"
    -------------------------
    ***PESQUISA DE MERCADO***
    -------------------------
    ");

string sexo="";
string resp="";
int respsim= 0;
int respnao= 0;
int sexohsim =0;
int sexohnao=0;
int sexomsim = 0;
int sexomnao= 0;
float percentual;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o sexo do entrevistado: (h para homem e m para mulher)");
    sexo = Console.ReadLine();
    
    if (sexo == "h")
    {
        Console.WriteLine($"Gostou do produto lançado? (digite 's' para sim e 'n' para não)");
        resp = Console.ReadLine();
        
        if (resp == "s")
        {
            respsim= respsim +1;
            sexohsim = sexohsim +1;
        }
        else if (resp == "n")
        {
            respnao= respnao +1;
            sexohnao= sexohnao +1;
        }
        else
        {
            Console.WriteLine($"Opção digitada é inválida.");
            
        }
        
    }
    else 
    if (sexo == "m")
    {
        
        Console.WriteLine($"Gostou do produto lançado? (digite 's' para sim e 'n' para não)");
        resp = Console.ReadLine();

        if (resp == "s")
        {
            respsim= respsim +1;
            sexomsim = sexomsim + 1;
        }
        else 
        {
            respnao= respnao +1;
            sexomnao= sexomnao +1;
        }
    }
    else
    { Console.WriteLine($"Sexo digitado é invalido");
    }    
    
}
     
    Console.WriteLine($"O número de pessoas que digitaram SIM é {respsim}.");
    Console.WriteLine($"O número de pessoas que digitaram NÃO é {respnao}");
    Console.WriteLine($"O número de mulheres que responderam SIM é {sexomsim}");
    Console.WriteLine($"A porcentagem de homens que responderam NÃO entre todos é {percentual= (sexohnao*100)/(sexohsim+sexohnao)} %");
    Console.WriteLine($"O total de homens analisados é {sexohsim+sexohnao}.");
    
    
    
    
    

