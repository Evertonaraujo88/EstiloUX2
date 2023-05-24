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
    }
}