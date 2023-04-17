/* 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário. */

bool encontrado = false;
string [] listaNomes = new string[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o nome da {i+1}° pessoas: ");
    listaNomes[i] = Console.ReadLine();
        
}


 Console.WriteLine($"Digite o nome que deseja buscar:");
 string busca = Console.ReadLine();
 

 foreach (string nome in listaNomes)
 {
    if (nome == busca)
    {
        encontrado = true;
        break;
    }
    
 }
 
/*  if (encontrado == true)
{
    Console.WriteLine($"ACHEIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII!!!!!!!!!!!!!");    
}
else
{
    Console.WriteLine($"NÃO  ACHEIIIIIIIIIIIIIIIIIIIIIIIII!");    
} */

/*string resultadoPesquisa = encontrado == true ? "ACHEI!!" : "NÃO ACHEI!!!";
Console.WriteLine(resultadoPesquisa);*/

Console.WriteLine(encontrado == true ? "ACHEI" : "NÃO ACHEI");
   
    
    