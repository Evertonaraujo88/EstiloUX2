// 1
//Crie uma classe chamada "Produto"
//Crie as propriedades: Codigo, Nome, Preco
//Crie um contrutor vazio dessa classe
//Crie um construtor com todos os atributos


//2
//Cria uma lista de objetos (produtos)

using LISTA_DE_OBJETOS;

List<Produto> produtos = new List<Produto>();

//AGORA FAZER  C R U D 

//CREATE

//inserir objetos de produtos dentro da lista
//atraves de uma isntacia direto (com construtor)
produtos.Add(
    new Produto( 1234, "camiseta lacoste", 19.99f)
    ); 


//atraves de uma instacia basica de objeto
Produto camisetaArmani = new Produto( 1235, "camiseta armani", 49.99f);
produtos.Add(camisetaArmani);

produtos.Add(
    new Produto( 1236, "camiseta ducalina", 299.95f)
    ); 

//READ


Console.WriteLine($"Produtos antes da altecao");

foreach (var item in produtos)
{
    Console.WriteLine ($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} - {produtos.IndexOf(item)}");
}

//UPDATE

//acessar um objeto da lista para poder manipula-lo.
Produto produtoEncontrado = produtos.Find(x => x.Codigo == 1235);
int index = produtos.IndexOf(produtoEncontrado);

//exibir o indice do produto encontrado
Console.WriteLine($"O índice do produto encontrato é o: {index}");

Console.WriteLine($"Produtos depois da alteracao");

//fazer alteracoes
produtoEncontrado.Preco = 599f;

//remover o item antigo da lista
produtos.RemoveAt(index);

//devolver o item atualizo no lugar
produtos.Insert(index, produtoEncontrado);

foreach (var item in produtos)
{
    Console.WriteLine ($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} - {produtos.IndexOf(item)}");
}

//DELETE
produtos.RemoveAt(1);

foreach (var item in produtos)
{
    Console.WriteLine ($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}  - {produtos.IndexOf(item)}");
}