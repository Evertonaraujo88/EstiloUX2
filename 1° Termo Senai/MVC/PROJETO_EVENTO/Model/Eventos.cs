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
        private const string CAMINHOPASTA = "Database/Evento.csv";

        //construtor 
        public Eventos()
        {
            //armazenando o caminho ja com separador de texto na variavel "folder"
            string pasta = CAMINHOPASTA.Split("/")[0];

                //Verificando se ja existe a pasta criada, se nao existir...deve criar
            if (!Directory.Exists(pasta))
            {
                //criando a pasta
                Directory.CreateDirectory(pasta);
            }
                //verificando se ja existe o arquido, se nao existir... deve criar
            if (!File.Exists(CAMINHOPASTA))
            {
                File.Create(CAMINHOPASTA);
            }

        }
        //criando um metodo para ler a lista de Eventos do arquivo csv
        public List<Eventos> Read()
        {

            //instancia da lista
            List<Eventos> eventos = new List<Eventos>();

            //criando array para receber as linhas do arquivo csv
            string [] lines = File.ReadAllLines(CAMINHOPASTA);


            //leitura linha por linha do array "lines"
            foreach (string item in lines)
            {
                //array de nome atributos que recebe os itens das lines separadas por ";"
                string[] atributos = item.Split(";");

                //instanciando objeto da classe Eventos para receber os indices do array atributos
                Eventos objEventos = new Eventos();

                //Obj  da classe Eventos.propriedade Nome = recebendo indice 0 do string atributos
                objEventos.Nome = atributos[0];

                //obj da classe Eventos.propriedade Descricap = recebendo indice 1 do string atributos
                objEventos.Descricao = atributos[1];

                //obj da classe Eventos.Data Data = recebendo indice 2 do string atributos
                objEventos.Data = atributos[2];

                //adicionando objetos na lista eventos
                eventos.Add(objEventos);


            }

            return eventos;
        }
    }
}