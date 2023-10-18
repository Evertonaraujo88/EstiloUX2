/* const numeros = [10,12,20];

const somatorio = numeros.reduce((total, n) => {
    return total + n

},0);

console.log(somatorio); */

const produtos = [
    {produto : "camiseta", preco: 129.90},
    {produto : "Tenis", preco: 350.97},
    {produto : "Jaqueta de couro", preco: 700.01},
];

let totalProduto = produtos.reduce((vlInicial,oP)=> {

    return vlInicial + oP.preco;
}, 0);

console.log(totalProduto);