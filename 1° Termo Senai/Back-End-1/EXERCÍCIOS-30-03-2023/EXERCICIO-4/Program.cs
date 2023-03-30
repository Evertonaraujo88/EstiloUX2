//4)Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
//A     senha     válida     é     o     número     1234. 
//Devem     ser    impressas     as    seguintes     mensagens:
//ACESSO    PERMITIDO    caso    a    senha    seja    válida.
//ACESSO    NEGADO    caso    a    senha    seja    inválida.
Console.WriteLine($"Digite a senha:");
int senha = int.Parse(Console.ReadLine());

int correta = 1234;

if (senha == correta){
    Console.WriteLine($"ACESSO PERMITIDO!!");
    
}else {
    Console.WriteLine($"ACESSO NEGADO!!");
}
