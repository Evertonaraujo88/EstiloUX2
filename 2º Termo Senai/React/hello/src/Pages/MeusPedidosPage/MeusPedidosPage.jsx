import React, { useContext } from 'react';
import { ThemeContext } from '../../Context/ThemeContext';

import './MeusPedidosPage.css';

const MeusPedidosPage = () => {

    const { theme,nome, sobrenome, produtos } = useContext(ThemeContext);

    
    return (
        <div>
            <h1>Meus Pedidos:</h1>

            <p>{theme}</p>
            <p>{nome} {sobrenome}</p>

            <ul style={{ listStyle: "nome" }}>
                
                {produtos.map((p) => {

                    return (
                        <li key={p.idProduto}>
                            <strong>Produto:</strong> {p.descricao} | &nbsp;
                            <strong>Preço:</strong> {p.preco} | &nbsp;
                            <strong>Promoção:</strong> {p.promo ? "sim" : "não"}
                            
                        </li>
                                               
                    );
                })}

            </ul>

        </div>
    );
};

export default MeusPedidosPage;