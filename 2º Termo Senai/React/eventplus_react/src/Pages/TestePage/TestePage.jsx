import React, { useState } from 'react';
import Botao from '../../Components/Botao/Botao';
import Input from '../../Components/Input/Input';
import Title from '../../Components/Title/Title';

const TestePage = () => {

    //variaveis do componente
    const [n1, setN1] = useState();
    const [n2, setN2] = useState();
    const [total, setTotal] = useState();


    function handleCalcular(e) {
        e.preventDefault()
        setTotal(parseFloat(n1) + parseFloat(n2));

    }
    return (
        <div>
           
            
            <Title
                titleText="Pagina de Poc´s"
                
            />
            <h2>Calculator</h2>
            <form onSubmit={handleCalcular} >

                <Input
                    type="number"
                    name="n1"
                    placeholder="Digite um numero:"
                    id="n1"
                    value={n1}
                    onChange={(e) => { setN1(e.target.value) }}

                />
                <br />

                <Input
                    type="number"
                    name="n2"
                    placeholder="Digite um numero:"
                    id="n2"
                    value={n2}
                    onChange={(e) => { setN2(e.target.value) }}
                />
                <br />

                <Botao

                    textButton="Calcular"
                    type="submit"
                    onClick={handleCalcular}
                />
                <span>Resultado: <strong>{total}</strong></span>

                
            </form>

            {/*  <p>Valor do N1: {n1}</p>
            <p>Valor do N2: {n2}</p> */}

        </div>
    );
};

export default TestePage;