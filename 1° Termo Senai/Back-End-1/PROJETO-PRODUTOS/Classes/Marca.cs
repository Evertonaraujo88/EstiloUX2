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
        Marca novaMarca = new Marca();
        //aqui vai a logica
        Console.WriteLine($"Digite o nome da Marca:");
        novaMarca.NomeMarca = Console.ReadLine();
        
        
        ListadeMarcas.Add(novaMarca);
        //instanciar o objeto
        
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
                Marca: {p.NomeMarca}                               
                ");
                
                }
            }else
            {
                Console.WriteLine($"Produto não cadastrado!!!");
            }
       }

       public void Deletar(int _codigo)
       {
        //aqui vai a lógica
        //buscar um objeto na lista pelo seu código
        //remove-lo
       }
        

    }
}