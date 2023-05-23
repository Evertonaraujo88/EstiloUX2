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

       public static List<Marca> ListaDeMarcas = new List<Marca>();

       public Marca Cadastrar()
       {
        //aqui vai a logica
        //instanciar o objeto
        Marca novaMarca = new Marca();
        
        Console.WriteLine($"Digite o Código da Marca:");
        int codigo = int.Parse(Console.ReadLine());

       novaMarca = ListaDeMarcas.FirstOrDefault(x => x.Codigo == codigo);
                     
       
         if (novaMarca == null)
        {
            novaMarca = new Marca();
            novaMarca.Codigo = codigo;

            Console.WriteLine($"Digite o nome da Marca:");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.Now;
    
            ListaDeMarcas.Add(novaMarca);

            return novaMarca;
            
        }
        else
        {
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Marca já cadastrada!");
            Console.ResetColor();
            Console.WriteLine($"");
            

            return novaMarca;
            
        } 
    
       }

       public void Listar()
       {
        //aqui vai a lógica
        //exibir os objetos cadastrados na lista
        if (ListaDeMarcas.Count > 0 || ListaDeMarcas != null)
            {
               foreach (Marca p in ListaDeMarcas)
               {
                Console.WriteLine(@$"
                Código: {p.Codigo}
                Marca: {p.NomeMarca}
                Data do Cadastro: {p.DataCadastro}                               
                ");
                
                }
            }if ( ListaDeMarcas.Count < 1)
            {
                Console.WriteLine($"");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Não exitem marcas cadastrados");
                Console.ResetColor();
                Console.WriteLine($"");
            }
            
       }

       public void Deletar(int _codigo)
       {
        //aqui vai a lógica
        //buscar um objeto na lista pelo seu código
        int index = ListaDeMarcas.IndexOf(ListaDeMarcas.Find(x=>x.Codigo == _codigo));
        //remove-lo
        Console.WriteLine($"Deseja exluir o Produto? s para sim e n para não");
        string resp = Console.ReadLine();
            
            if (resp == "s")
            {
                ListaDeMarcas.RemoveAt(index);

                Console.WriteLine($"");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Marca Excluída com sucesso!");
                Console.ResetColor();
                Console.WriteLine($"");
            } else
            {
                Console.WriteLine($"");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Marca não excluida, voltando ao menu!");
                Console.ResetColor();
                Console.WriteLine($"");
            }
       }
        

    }
}