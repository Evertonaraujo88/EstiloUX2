//um programa que receba o nome do usuario e a senha
//a senha dete ter 6 caracteres
//validar a senha
//enquanto a senha nao estiver com regra pedidia, preciso que
    //o programa nao se encerra e que solicite que seja digitado
    //uma senha no padrao requerido
//caso a senha infotmada esteja com 6 caractes, exima uma mensagem de ok

Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua senha (tem que ter  6 caracteres)");
string senha = Console.ReadLine();

while (senha.Length != 6 )
{
    Console.WriteLine($"Digite uma senha tenha o padrao solicitado (6 caracteres)");
    senha = Console.ReadLine();
    
}
Console.WriteLine($"Nome e senha cadastrados com sucesso!!!");



