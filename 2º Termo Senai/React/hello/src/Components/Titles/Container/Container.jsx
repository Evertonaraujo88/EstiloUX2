import React from "react";

import './Container.css'


const Container = ({children})=>{
    return(
        <div className= "container">
      {/*       A props.children é uma prop especial que passa os elementos filho do componente diretamente para a sua respectiva saída renderizada. Isso permite que outros componentes também possam passar seus elementos filhos no próprio JSX. */}
            {children}
        </div>
    );
};

export default Container