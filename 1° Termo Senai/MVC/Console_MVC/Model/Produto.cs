using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console_MVC.Model
{

        public class Produto
    {
        //Propriedades:
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        //caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produto.csv";

        //criar um cosntrutor
        public Produto()
        {
            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0]; //[0] eh o indice que sera guardado a pasta  e "Database" eh o nome da pasta

            //se nao existir uma pasta Database, entao cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //se nao existir um arquivo csv no caminho, entao cria-se um
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
            
        }

        public List<Produto> Ler()
        {
            //instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha csv
            string[] linhas = File.ReadAllLines(PATH);

            //para a leitura das linhas
            foreach (string item in linhas)
            {
                
                //antes do split
                //001;Picanha;114,90

                //array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");

                //apos o split
                //atributos[0] = "001"
                //atributos[1] = "Picanha"
                //atributos[2] = "114,90"

                //instancia de objeto produto
                Produto p = new Produto();

                //atribuir os dados dentro de um objeto
                p.Codigo = int.Parse(atributos[0]); //"001"
                p.Nome = atributos[1]; //"Picanha"
                p.Preco = float.Parse(atributos[2]); //"114,90"

                //adiciona os objejtos dentro da lista
                produtos.Add(p);
            }

            //retorna a lista de produtos
            return produtos;
        }
    }
}