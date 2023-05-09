using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosConstrutores
{
    public class Produto
    {
        //propriedade

        public string Nome {get; set; }

        public int Codigo { get; set; }

        public int Estoque { get; set; }

        //metodo construtor vazio
        public Produto()
        {

        }

        //metodo construtor passando o codigo como obrigatorio
        public Produto (int codigo)
        {
            Codigo = codigo;
        }

        //metodo construtor passando todas as propriedades como obrigatorio
        public Produto (string nome, int codigo, int estoque)
        {
            Nome = nome;
            Codigo = codigo;
            Estoque = estoque;
        }
    }
}