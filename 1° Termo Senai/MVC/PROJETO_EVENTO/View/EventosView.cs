using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROJETO_EVENTO.Model;

namespace PROJETO_EVENTO.View
{
    public class EventosView
    {
        //metodo para exibir os dados da lista
        public void ListarNaView(List<Eventos> eventos)
        {
            foreach (var item in eventos )
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Descrição: {item.Descricao}");
                Console.WriteLine($"Data: {item.Data}");
            }
        }
    }
}