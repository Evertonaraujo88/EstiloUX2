using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PRODUTOS.Classes
{
    public class Produto
    {
        public int Codigo{get; private set; }
        public string NomeProduto{ get; private set; }
        public float Preco{ get; private set;}
        public DateTime DataCadastro{ get; private set; }
        
        public Marca Marca = new Marca();

        public Usuario CadastradoPor{ get; private set; }

        List<Produto> ListaDeProdutos = new List<Produto>();
        public void Cadastrar()
        {
            //aqui vai a lógica
            //instanciar o objeto
            Produto novoProduto = new Produto();
            //receber os dados e cadastrar nesse objeto
            Console.WriteLine($"Digite o codigo do produto: ");
            int _codigo = int.Parse(Console.ReadLine());
            
            novoProduto.Codigo =_codigo;

            Console.WriteLine($"Text");
            
            //armazenar o objeto na lista
        }

        public void Listar()
        {
            //aqui vai a lógica
            //exibir os objetos cadastrados na lista
        }

        public void Deletar(int _codigo)
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            //remove-lo
        }
    }
}