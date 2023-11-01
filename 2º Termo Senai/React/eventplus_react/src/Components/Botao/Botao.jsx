import React from 'react';

const Botao = ({textButton, type}) => {
    return (
        <div>
            <button
                
                type={type}>
                {textButton}
               
            </button>
        </div>
    );
};

export default Botao;