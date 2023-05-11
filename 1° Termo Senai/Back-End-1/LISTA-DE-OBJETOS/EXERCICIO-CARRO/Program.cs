/* EXERCICIO PARA FIXAÇÃO - NÃO PRECISA ENTREGAR

1- CRIAR UMA CLASSSE "CARRO" - OK
    - PROPRIEDADES: STRING MARCA, STRING CARRO - OK

2- CRIAR CONSTRUTOR VAZIO E COMPLETO - OK

3- CADASTRA E INSERIR EM UMA LISTA 2 OBJETOS (DINÂMICO)
    - ENTRADA DE DADOS PELO CONSOLE

4- EXIBIR OS DADOS DOS OBJETOS NO CONSOLE (FOREACH) */
using EXERCICIO_CARRO;

// criando a lista
List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    // criando um objeto
  Carro carro = new Carro();

  //entrada de dados via console
  Console.WriteLine($"Informe a marca do carro: ");
  //atribuindo a entrada ao objeto e propriedade da classe Carro criada
  carro.Marca = Console.ReadLine();
  
  //entrada de dados via console
  Console.WriteLine($"Informe a cor do carro: ");
  //atribuindo a entrada ao objeto e propriedade da classe Carro criada
  carro.Cor = Console.ReadLine();
  
  //esse codigo vai adicionando as informacoes inseridas em indices diferente.
  carros.Add(carro);  
}

foreach (var item in carros)
{
    Console.WriteLine($"Marca : {item.Marca} - Cor: {item.Cor}");
    
}


