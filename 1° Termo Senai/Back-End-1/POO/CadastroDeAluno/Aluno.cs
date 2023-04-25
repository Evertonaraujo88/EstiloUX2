using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeAluno
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public string idade;
        public string rg;
        public bool bolsista;
        public float mediaFinal;
        public float valorDaMensalidade;

      public float VerMensalidade()
      {

        if (bolsista == true && mediaFinal >= 8)
        {
            return((this.valorDaMensalidade * 0.50f));
        }
        else if (bolsista == true && (mediaFinal >= 6 && mediaFinal <8))
        {
            return (valorDaMensalidade * 0.70f);
        }
        else
        {
            return(valorDaMensalidade);
        }
      }  

      public void VerMediaFinal()
      {
              
        Console.WriteLine($"A média final é {mediaFinal}");
        
      }
    } 
}


/* VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.


Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

Acrescente o que achar necessário. */