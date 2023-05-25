using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_EVENTO.Model
{
    public class Eventos
    {
        //propriedades:
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Data { get; set; }

        //caminho pasta e arquivo a ser usado
        private const string PATH = "Database/Evento.csv";

        //construtor 
        public Eventos()
        {
            //armazenando o caminho ja com separador de texto na variavel "folder"
            string folder = PATH.Split("/")[0];

                //Verificando se ja existe a pasta criada, se nao existir...deve criar
            if (!Directory.Exists(folder))
            {
                //criando a pasta
                Directory.CreateDirectory(folder);
            }
                //verificando se ja existe o arquido, se nao existir... deve criar
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }
        //criando um metodo para ler a lista de Eventos do arquivo csv
        public List<Eventos> Read()
        {

            //instancia da lista
            List<Eventos> eventos = new List<Eventos>();

            //criando array para receber as linhas do arquivo csv
            string [] lines = File.ReadAllLines(PATH);

            foreach (string item in lines)
            {
                
            }

            return Read();
        }
    }
}