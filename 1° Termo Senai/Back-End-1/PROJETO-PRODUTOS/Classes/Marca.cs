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
      
        
        //receber os dados e cadastrar nesse obejto
        //armazenar o objeto na lista
        //retornar o objeto criado
        return novaMarca;
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