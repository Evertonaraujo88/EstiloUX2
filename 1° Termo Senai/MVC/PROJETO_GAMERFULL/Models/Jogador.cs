using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJETO_GAMERFULL.Models
{
    public class Jogador
    {
        [Key]//DATA ANNOTATION - IdJogador
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        

                              //DATA ANNOTATION - IdEquipe
        [ForeignKey("Equipe")]// definindo a chave estrangeira na classe Jogador, utilizando a chave primaria criada na classe Equipe
        public int IdEquipe { get; set; }
    }


}