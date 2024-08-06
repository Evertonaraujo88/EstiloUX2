using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInventario
{
    
    public static class Inventario
    {
        // Lista de produtos
        private static List<Produto> _produtos = new List<Produto>();

        //Adiciona um produto ao inventário
        public static void AdicionarProduto(string nome, int quantidade)
        {
            // Procura o produto pelo nome na lista
            var produto = _produtos.FirstOrDefault(p => p.Nome == nome);

            if (produto != null)
            {
                // Se o produto já existe, incrementa a quantidade
                produto.Quantidade += quantidade;
            }
            else
            {
                // Se o produto não existe, adiciona um novo produto à lista
                _produtos.Add(new Produto { Nome = nome, Quantidade = quantidade });
            }
        }

        //Obtem a quantidade de um produto pelo nome
        public static int ObterQuantidadeProduto(string nome)
        {
            // Procura o produto pelo nome na lista
            var produto = _produtos.FirstOrDefault(p => p.Nome == nome);

            // Retorna a quantidade do produto, ou zero se o produto não existir
            return produto != null ? produto.Quantidade : 0;
        }
    }
}
