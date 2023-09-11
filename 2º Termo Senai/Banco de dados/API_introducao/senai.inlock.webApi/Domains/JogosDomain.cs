using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi_.Domains
{
    public class JogosDomain
    {

        public int IdEstudio { get; set; } 

        public string Nome { get; set; }
        [Required(ErrorMessage = "O nome do jogo eh obrigatorio!")]

        public string Descricao { get; set; }
        [Required(ErrorMessage = "A descricao do jogo eh obrigatoria!")]

        public int  DataLancamento { get; set; }

        public int Valor { get; set; }
        [Required(ErrorMessage = "O valor do jogo eh obrigatorio!")]

        //referencia para a classe Estudio
        public EstudioDomain Estudio { get; set; }

    }
}
