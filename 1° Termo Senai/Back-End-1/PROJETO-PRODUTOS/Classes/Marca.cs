using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PRODUTOS.Classes
{
    public class Marca
    {
       public int Codigo{get; private set; }
       public string NomeMarca{ get; private set; }
       public DateTime DataCadastro{ get; private set; }

       List<Marca> ListadeMarcas = new List<Marca>();

       public Marca Cadastrar()
       {
        //aqui vai a logica
        //instanciar o objeto
        Marca novaMarca = new Marca();
        
        Console.WriteLine($"Digite o Código da Marca:");
        novaMarca.Codigo = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Digite o nome da Marca:");
        novaMarca.NomeMarca = Console.ReadLine();

        novaMarca.DataCadastro = DateTime.Now;
    
        ListadeMarcas.Add(novaMarca);
        
        
        return novaMarca;
       }

       public void Listar()
       {
        //aqui vai a lógica
        //exibir os objetos cadastrados na lista
        if (ListadeMarcas.Count > 0 || ListadeMarcas != null)
            {
               foreach (Marca p in ListadeMarcas)
               {
                Console.WriteLine(@$"
                Código: {p.Codigo}
                Marca: {p.NomeMarca}
                Data do Cadastro: {p.DataCadastro}                               
                ");
                
                }
            }if ( ListadeMarcas.Count < 1)
            {
                Console.WriteLine($"Não exitem marcas cadastrados");   
            }
            
       }

       public void Deletar(int _codigo)
       {
        //aqui vai a lógica
        //buscar um objeto na lista pelo seu código
        int index = ListadeMarcas.IndexOf(ListadeMarcas.Find(x=>x.Codigo == _codigo));
        //remove-lo
        Console.WriteLine($"Deseja exluir o Produto? s para sim e n para não");
            string resp = Console.ReadLine();
            
            if (resp == "s")
            {
                ListadeMarcas.RemoveAt(index);
                Console.WriteLine($"Marca Excluída com sucesso!");
            }
       }
        

    }
}