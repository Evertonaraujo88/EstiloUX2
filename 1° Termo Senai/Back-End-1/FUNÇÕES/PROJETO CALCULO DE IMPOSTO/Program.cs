//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda 

using System.Globalization;

static float CalcularImposto (float Salario)
{
    
    if (Salario <= 1500)
    {
        return 0;
               
    }
    else 
    if (Salario >=1501 && Salario <=3500)
    {
        
        return (Salario/100)*20;
        
    }
    else if (Salario >=3501 && Salario <= 6000)
    {
        return (Salario/100)*25;
    } else
    {
        return (Salario/100)*35;
    }
    
}

Console.WriteLine($"Olá, informe o salário");
float Salario = float.Parse(Console.ReadLine());

float ImpostoDevido =CalcularImposto (Salario);
Console.WriteLine(@$"
Salário: {Math.Round(Salario,2).ToString("C", new CultureInfo("pt-BR"))}
Valor do Imposto: R${Math.Round (ImpostoDevido,2)}
");

