using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* EXERCICIO PARA FIXAÇÃO - NÃO PRECISA ENTREGAR

1- CRIAR UMA CLASSSE "CARRO"
    - PROPRIEDADES: STRING MARCA, STRING CARRO

2- CRIAR CONSTRUTOR VAZIO E COMPLETO

3- CADASTRA E INSERIR EM UMA LISTA 2 OBJETOS (DINÂMICO)
    - ENTRADA DE DADOS PELO CONSOLE

4- EXIBIR OS DADOS DOS OBJETOS NO CONSOLE (FOREACH) */


namespace EXERCICIO_CARRO
{
    public class Carro
    {
        public string Marca { get; set; }

        public string Cor { get; set; }

public Carro()
{
}

public Carro(string marca, string cor)
{
    Marca = marca;
    Cor = cor;
}

    }
}