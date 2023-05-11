using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{

    //interface para a classe Carrinho
    public interface ICarrinho
    {
        //defini(declarar) quais os metodos deveram ser implementados
        // na classe que herdar desta interface

        //C R U D : Create/ Read/ Update/ Delete

        //Create
        void Adicionar(Produto _produto);

        //Read
        void Listar();

        //Update
        void Atualizar(int _codigo, Produto _produto);

        //Delete
        void Remover(Produto _produto);

    }
}