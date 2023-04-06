//Faca um programa que leia um nome de usuario e a sua senha e nao aceite a senha igual o nome do usuario e mostrando uma mensagem de erro e voltando a pedir as informacoes.

//entrada
//"Digite seu nome: "
//" digite sua senha: "

//processamento
// while ( nome != senha)
// " Sua senha nao pode ser igual ao nome do usuario, insira outra senha!!!"

//saida
//"Usuario cadastrado com sucesso!!!"

Console.WriteLine(@$"
---------------------------------
***PROJETO CADASTRO DE USUARIO***
---------------------------------
");
Console.WriteLine($"Digite o nome do usuario: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua senha: ");
string senha = Console.ReadLine();

while (nome == senha)
{
    Console.WriteLine($"Senha inválida, sua senha não pode ser igual ao nome do usuario! DIGITE OUTRA SENHA: ");
    senha = Console.ReadLine();
    
}
Console.WriteLine($"Usuário cadastrado com sucesso!!!");



