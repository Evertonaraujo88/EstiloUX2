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
            string resp;
           
            Console.WriteLine($"Digite o codigo do produto: ");           
            novoProduto.Codigo =int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do Produto: ");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            
            novoProduto.DataCadastro = DateTime.Now;

            novoProduto.Marca = Marca.Cadastrar();

             
            novoProduto.CadastradoPor = new Usuario();
             
            //armazenar o objeto na lista
            ListaDeProdutos.Add(novoProduto);
            
        }

        public void Listar()
        {
            //aqui vai a lógica
            //exibir os objetos cadastrados na lista
            if (ListaDeProdutos.Count > 0 || ListaDeProdutos != null)
            {
               foreach (Produto p in ListaDeProdutos)
               {
                Console.WriteLine(@$"
                Codigo: {p.Codigo}
                Nome: {p.NomeProduto}
                Preço: {p.Preco:C}
                Marca: {p.Marca.NomeMarca}
                Data do cadastro: {p.DataCadastro}
                Cadastrado por: {p.CadastradoPor.Nome}
                                
                ");
                
                }
            }if ( ListaDeProdutos.Count < 1)
            {
                Console.WriteLine($"Não exitem produtos cadastrados");   
            }
            
            
        }

        public void Deletar(int _codigo)
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            int index = ListaDeProdutos.IndexOf(ListaDeProdutos.Find(x=>x.Codigo == _codigo));
                       
            //remove-lo
            Console.WriteLine($"Deseja exluir o Produto? s para sim e n para não");
            string resp = Console.ReadLine();
            
            if (resp == "s")
            {
                ListaDeProdutos.RemoveAt(index);
                Console.WriteLine($"Produto Excluído!");
            }
                       
        }
    }
}   