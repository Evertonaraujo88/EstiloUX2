import React from "react";
import './Title.css'

//desta forma estamos criando e exportando o componente title
/* export default function Title() {
    return(
        <h1 className="title">Hello Componente Title</h1>
    );
} */


//desta forma criamos uma const e depois exportamos a função de callback
const Title = (props) => {
    return(
        <h1 className="title">Hello {props.nome} {props.sobrenome}!!!</h1>
    );
}

export default Title;

