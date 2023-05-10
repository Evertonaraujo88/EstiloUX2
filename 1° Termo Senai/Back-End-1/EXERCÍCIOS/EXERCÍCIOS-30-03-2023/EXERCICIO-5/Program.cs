//5)As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

//entreda
//"Digite a quantidadde de maçãs compradas: "
//quantidade = ()

//Processamento:
//Se quantidade >= 12
//{valor=(quantidade*0,25)}
//Se nao
//{ valor = (quantidade*0,30)}

//saida
// "O valor total da sua compra é: "

Console.WriteLine($"Digite a quantidade de maçãs compradas: ");
int quantidade = int.Parse(Console.ReadLine());


if ( quantidade >= 12){

    float valor = (quantidade * 0.25f);
    Console.WriteLine($"O valor total da sua compra é: {valor}");
} else{
    float valor = (quantidade * 0.30f);
    Console.WriteLine($"O valor total da sua compra é: {valor}");
}


