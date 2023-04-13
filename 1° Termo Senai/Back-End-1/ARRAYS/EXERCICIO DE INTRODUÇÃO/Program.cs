// Criar um programana em c# qie recena 5 numeros inteiros e ao final exiba o seu dobro

// voce deve utulizar a estrutura array com o tamanho 5 para o armazenamento dos numeros, a estrutura for para a leitura dos numeros e a estrutura foreach para exibi-los

//entrada
// "digite 5 numeros a sua escolha"

//processamento
// criar array tamanha 5
//receber os numeros digitados
//for 1=0, i<5 ,i++
// dobro= i*i;

//saida
//foreach


int []numeros= new int[5];

for (int i = 0; i <5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º numero.");
    numeros[i]= int.Parse(Console.ReadLine());
}
Console.WriteLine($"RESULTADO:");
foreach (var item in numeros)
{    
    Console.WriteLine(  item * 2);   
}


