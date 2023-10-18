const numeros = [1,0,200,10,7,12,15,8];

console.log(numeros);

const nMenor10 = numeros.filter((n) =>{
    return n < 10;
});

console.log((nMenor10).sort());

const comentarios = [
    {comentario: "knfainfioajfias", exibe: true},
    {comentario: "evento lixo",exibe: false},
    {comentario: "maravilhoso",exibe: true},
    {comentario: "uma merda",exibe: false},
];

const comentariosOk = comentarios.filter( (c) =>{
return c.exibe === true

});

console.log(comentariosOk);