const camisaLacoste = {

    descricao: "Camisa Polo",
    preco: 589.97,
    tamanho: "M",
    cor: "Amarelo",
    presente: true

};

/* const {descricao} = camisaLacoste
const {preco} = camisaLacoste

console.log("produto:");

console.log(`Descricao: ${descricao}`);
console.log(`Preco: ${preco}`); */

const {descricao, preco, presente} = camisaLacoste;

console.log(`
    Produto:
    Descricao: ${descricao}
    Preco: ${preco}
    Presente: ${ presente ? "Sim" : "Nao"}

`);