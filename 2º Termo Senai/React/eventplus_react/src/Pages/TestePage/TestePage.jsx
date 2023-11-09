import userEvent from '@testing-library/user-event';
import React, { useEffect, useState } from 'react';


const TestePage = () => {
    const [count, setCount] = useState(0);
    const [calculation, setCalculation] = useState();

    //executa quando o componente for montado
    //e quando o state count for alterado
    useEffect(()=>{
        setCalculation( count *2);
    }, [count]);

    return (
        <div>
            <p>Count: {count}</p>
            <br/>
            <button onClick={()=> setCount((c)=> c+1)}>+</button>
            <br/>
            <p>Calculation: {calculation}</p>
            
        </div>
    );
};

export default TestePage;