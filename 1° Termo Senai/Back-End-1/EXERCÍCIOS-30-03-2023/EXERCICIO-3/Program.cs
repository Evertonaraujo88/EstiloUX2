//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
//Sendo    que:    
//− Triângulo    Equilátero:    possui    os    3    lados    iguais.
//− Triângulo    Isóscele:    possui    2    lados    iguais.
//− Triângulo    Escaleno:    possui    3    lados    diferentes.

//entrada
//digite um lado do triangulo = a
//digite outro lado do triangulo = b
//digite outro lado do triangulo = c

//processamento
// if (a==b && b==c) ....{(imprimi...Triangulo Equilatero!!)
// else if (a == b && b != c)....{imprimir...Triangulo Isoceles}
// else {imprimir....Triangulo Escaleno}

Console.WriteLine($"Digite um lado do triângulo: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite outro lado do triângulo: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite outro lado do triângulo: ");
int c = int.Parse(Console.ReadLine());

if (a==b && b==c){
    Console.WriteLine($"Seu triângulo é Equilátero!!");
} else if (a != b && b != c && c !=a){
    Console.WriteLine($"Seu triângulo é Escaleno!!");
} else{
    Console.WriteLine($"Seu triângulo é Isoceles!!");
}