/* const numeros = [1, 2, 5, 10, 300]; 

//funcao map, ela passa por cada item, modifica e retorna um novo array modificado
const arrDobro = numeros.map((n) => {

    return n * 2

}); */

/* console.log(numeros);
console.log(arrDobro); */

//criar 2 arrays com nome e sobrenomes
const nome = ['Everton', 'Luiz', 'Guilherme', 'Andre', 'Joao'];
const sobrenome = ['Araujo', 'correia', 'santos', 'brizido', 'oliveira'];

//crei um terceiro array de nomes completos
const nomeCompleto = nome.map((nome, indice) => `${nome} ${sobrenome[indice]}`);

//exibir a juncao dos dois arrays
nomeCompleto.forEach((nc)=> console.log(nc));