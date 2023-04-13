//CRIAR METODOS DE OPERAÇÕES MATEMÁTICAS (ADOÇÃO, SUBTRAÇÃO, MULTIPLICAÇÃO, DIVISÃO)

Console.WriteLine($"Informe o primeiro numero: ");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

//Adição
static float Soma(float n1, float n2)
{
    return (n1 + n2);
}

Console.WriteLine($"A Soma de {n1} + {n2} é: {Soma(n1,n2)}.");
Console.WriteLine($"");


//Subtração
static float Subtrair(float n1, float n2)
{
    return (n1 - n2);
}

Console.WriteLine($"A Subtração de {n1} - {n2} é: {Subtrair(n1,n2)}.");
Console.WriteLine($"");

//Multiplicação
static float Mult(float n1, float n2)
{
    return (n1 * n2);
}

Console.WriteLine($"A Multiplicacao de {n1} x {n2} é: {Mult(n1,n2)}.");
Console.WriteLine($"");

//Duivisao
static float Div(float n1, float n2)
{
    return (n1 / n2);
}

Console.WriteLine($"A Divisao de {n1} / {n2} é: {Div(n1,n2)}.");
Console.WriteLine($"");

