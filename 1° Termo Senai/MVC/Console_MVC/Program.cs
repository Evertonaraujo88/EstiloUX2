using Console_MVC.Controller;
using Console_MVC.Model;

//instancia do objeto produto
Produto p = new Produto();

//instancia do objeto produtoController
ProdutoController controller = new ProdutoController();

//chamada do metodo controlador para cadastrar produto 
controller.CadastrarProduto();

//chamada do metodo controlador para listar produto
controller.ListarProdutos();