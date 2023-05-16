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
        
        public Marca Marca {get; private set; }

        public Usuario CadastradoPor{ get; private set; }

        public List<Produto> ListaDePrduto{ get; private set; }
    }
}