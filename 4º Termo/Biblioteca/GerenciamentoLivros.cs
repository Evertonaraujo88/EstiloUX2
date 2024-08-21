using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

    
   
        // Classe estática que gerencia a lista de livros
        public static class GerenciamentoLivros
        {
            // Lista privada de livros
            private static List<Livro> _livros = new List<Livro>();

            // Método para adicionar um livro à lista
            public static void AdicionarLivro(Livro livro)
            {
                _livros.Add(livro);
            }

            // Método para obter a lista de livros
            public static List<Livro> ObterLivros()
            {
                return _livros;
            }
        }
    
}
