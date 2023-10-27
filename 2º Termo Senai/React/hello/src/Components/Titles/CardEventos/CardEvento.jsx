import React from "react";
import './CardEvento.css'

const CardEvento = ({titulo, descricao, botao}) => {
    return (

        <div className="card-evento">
            <div className="card">
                <h1 className="card__titulo">{titulo}</h1>
                <h2 className="card__texto">
                    {descricao}
                </h2>
                <button className="card__conect card__conect--desabilitado">{botao}</button>
            </div>
        </div>

    );
};

export default CardEvento;