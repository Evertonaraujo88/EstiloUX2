using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        //instanciar objeto Produto e ProdutoView
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //lista de produtos chamada pela model
            List<Produto> produtos =  produto.Ler();

            //chamada do metodo de exibicao(VIEW) recebendo como argumento a lista
            produtoView.Listar(produtos);
        }

        //metodo controlador para acessar o cadastro de produto
        public void CadastrarProduto()
        {
            //chamada para a view que recebe cada objeto a ser inserido no csv
           Produto novoProduto = produtoView.Cadastrar();

           //chamda para a model para inserir esse objeto no csv
           produto.Inserir(novoProduto);
        }
    }
}