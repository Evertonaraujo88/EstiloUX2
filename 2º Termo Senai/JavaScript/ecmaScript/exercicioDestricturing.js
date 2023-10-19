// criar uma desestruturacao para um objeto filme
//trazer somente 3 propriedades

/* 
const filme = {

    genero: "acao",
    podutora: "Universal",
    tituloFilme: "60 segundos",
    descricao: "Famoso ladrao de carros no passado, teve que voltar a ativa para salvar sua familia",
    atorPrincipal: "Nicolas Cage",
    diretor: "Stivem Wonder",
    duracao: "2h"

};

const {genero, tituloFilme, descricao} = filme;

console.log(`

Genero: ${genero}
Titulo do Filme: ${tituloFilme}
Descrição do Filme: ${descricao}

`); */

const filmes = [
    {
        genero: "acao",
        podutora: "Universal",
        tituloFilme: "60 segundos",
        descricao: "Famoso ladrao de carros no passado, teve que voltar a ativa para salvar sua familia.",
        atorPrincipal: "Nicolas Cage",
        diretor: "Stivem Wonder",
        duracao: "2h"
    },
    {
        genero: "Comedia",
        podutora: "pixar",
        tituloFilme: "Monstros SA",
        descricao: "Uma farbica de susto irá passar por serios apuros por causa de uma visita indesejada.",
        atorPrincipal: "Bu",
        diretor: "Sulivan",
        duracao: "2h"
    },
    {
        genero: "comedia",
        podutora: "Brasileiro",
        tituloFilme: "Minha mãe é uma peça",
        descricao: "Uma mãe pra lá de engraçada e preocupada com seus filhos.",
        atorPrincipal: "Paulo Gustavo",
        diretor: "Stivem Wonder",
        duracao: "2h"
    },

    
];

filmes.forEach(({tituloFilme, genero, descricao}, i) => {

    console.log(`
Genero: ${genero}
Titulo do Filme: ${tituloFilme}
Descrição do Filme: ${descricao}
`)

});

