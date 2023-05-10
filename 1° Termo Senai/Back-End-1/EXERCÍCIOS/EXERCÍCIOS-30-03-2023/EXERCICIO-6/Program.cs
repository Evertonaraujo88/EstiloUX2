//6)Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

//entrada
//"Digite a frequência do aluno: "
//"Digite a média do aluno: "

//Processamento:
//se (frequencia >= 75) então 
//                      { se (media >=7) entao 
//                      { "ALUNO APROVADO!!!"} SENAO
//                      {"RECUPERACAO!!"}
//senao {REPROVADO!!}

Console.WriteLine($"Digite a frequência do aluno: ");
float frequencia = float.Parse(Console.ReadLine());

if(frequencia >= 75){
    Console.WriteLine($"Digite a média do aluno: ");
    float media = float.Parse(Console.ReadLine());
    
    if(media >=7.0){
        Console.WriteLine($"ALUNO APROVADO!!!");   
    }else {
        Console.WriteLine($"ALUNO DE RECUPERAÇÃO!!");  
    }
}else{
    Console.WriteLine($"ALUNO REPROVADO");
    
}


