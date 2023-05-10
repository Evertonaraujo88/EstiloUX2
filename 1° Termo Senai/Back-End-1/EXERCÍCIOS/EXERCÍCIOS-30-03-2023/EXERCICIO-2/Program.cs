//Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

//entrada
//devs = (gols do palmeiras)
//redes = (gols do curintia)

//processamento
// se devs > redes ...imprimir (Vitoria dos devs)
//else if redes > devs...imprimir (vitoria dos redes)
// else....imprimir (empate)

Console.WriteLine($"Quantos gols dos Devs: ");
int devs = int.Parse(Console.ReadLine());

Console.WriteLine($"Quantos gols dos Redes: ");
int redes = int.Parse(Console.ReadLine());

if (devs > redes){
    Console.WriteLine($"Vitódia do time dos Devs!!");  
} 
else if (redes > devs){
    Console.WriteLine($"Vitódia do time de Redes!!");
}
else{
    Console.WriteLine($"Nem um..nem outro...DEU EMPATE!!!!");
}



