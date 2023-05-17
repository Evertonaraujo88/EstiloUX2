using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PRODUTOS.Classes
{
    public class Usuario
    {
        public int Codigo{get; private set; }
        public string Nome{ get; private set; }
        public string Email{get; private set; }
        public string Senha{ get; private set;}
        public DateTime DataCadastro{ get; private set; }

    public Usuario()
    {
        Cadastrar();
    }
    public void Cadastrar()
    {
        this.Nome = "Everton";
        this.Email = "evertonaraujosenai@gmail.com";
        this.Senha = "1234";
        this.DataCadastro = DateTime.Now;
    }

    public void Deletar()
    {
        this.Nome = "";
        this.Email = "";
        this.Senha = "";
        this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
    }
    }

    
}