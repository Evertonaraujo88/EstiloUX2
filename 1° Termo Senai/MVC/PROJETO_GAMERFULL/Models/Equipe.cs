using System.ComponentModel.DataAnnotations;

namespace PROJETO_GAMERFULL.Models
{
    public class Equipe
    {
             //criando a chave primaria na prop IdEquipe para relacionar na classe Jogador
        [Key]//DATA ANNOTATION - IdEquipe
        public int IdEquipe { get; set; }//somente essa prop recebera a Key

        public string Nome { get; set; }

        public string Imagem { get; set; }

        //acesso a colecao de Jogador atraves da ForeignKey (feita na classe Jogador)
        public ICollection<Jogador> Jogador {get; set; } //referencia que a classe Equipe vai ter acesso a Collection "Jogador"
    }


}