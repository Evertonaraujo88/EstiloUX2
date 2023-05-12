
using Produto_Interface;

//Instancia do nosso objeto da classe carrinho
Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "Call of Duty", 480f);
Produto p2 = new Produto(2, "Mineirinho ultra Adventures", 2.30f);
Produto p3 = new Produto(3, "The last of Us", 150f);

//Adicionar
carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

//Listar
carrinho.Listar();

//valor do carrinho
carrinho.ValorTotal();

Console.WriteLine($"****************************************");

//remover
carrinho.Remover(p1);
carrinho.Listar();
//valor total do carrinho apos remover item
carrinho.ValorTotal();


Console.WriteLine($"****************************************");

//atualizar
    //criar um novo objeto com os dados atualizados

Produto produtoAtualizado = new Produto();
produtoAtualizado.Nome = "Donkey Kong";
produtoAtualizado.Preco = 2.50f;

//atualizando o carrinho
carrinho.Atualizar(2, produtoAtualizado);

//listando com a atualizacao e mostrando o valor total do carrinho
carrinho.Listar();
carrinho.ValorTotal();
Console.WriteLine($"****************************************");