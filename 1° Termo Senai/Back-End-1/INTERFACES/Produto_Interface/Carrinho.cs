using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor {get; set; }

        //lista onde vamos manipular os objetos
        List<Produto> carrinho = new List<Produto>();

        //Implementar a logica para cada metodo
        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        
        public void Listar()
        {
            if (carrinho.Count > 0 || carrinho != null)
            {
               foreach (Produto p in carrinho)
               {
                Console.WriteLine($"Codigo: {p.Codigo} - Nome: {p.Nome} - Preço: {p.Preco:C}");
                }
            }else
            {
                Console.WriteLine($"Carrinho Vazio!!!");
            }

        }
        public void Atualizar(int _codigo, Produto _novoproduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoproduto.Preco;
        }

       

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void ValorTotal()
        {
            Valor = 0;

            //verificacao se tem algo dentro do carrinho, se houver....essa operacao soma os precos e imprime o total
            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                Console.WriteLine($"O valor total do carrinho esta em: {Valor:C}");
                
            }else
            {
                Console.WriteLine($"Seu carrinho esta vazio!!");
                
            }
        }
    }
}