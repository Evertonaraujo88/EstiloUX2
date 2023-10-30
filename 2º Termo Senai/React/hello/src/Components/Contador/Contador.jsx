import React from "react";
import { useState } from "react";


const Contador = () => {

    const[contador,setContador] = useState(0); //dado do componente

    /* Const Incrementar = () => {
        setContador(contador + 1)
    }
    const Decrementar = () => {
        setContador(contador - 1)
    } */

        function handleIncremetar(){
            setContador( contador +1);
            
        };

        function handleDecremetar(){

         setContador( contador === 0 ? 0: contador -1)
            
        };
    
    return (
        <>
            <h1>Contador</h1>

            <span>{contador}</span>

            <button onClick={()=>
            {handleIncremetar()}}>Incrementar</button>

            <button onClick={() =>
            {handleDecremetar()}}>Decrementar</button>
        </>
    )
}

export default Contador