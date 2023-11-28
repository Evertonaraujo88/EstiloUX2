import React, { useContext } from 'react';
import { ThemeContext } from '../../Context/ThemeContext';

const ProdutoPage = () => {

    const {theme} = useContext(ThemeContext);

    return (
        <div>
            <h1>Produto Page</h1>
            <span>{theme}</span>
            
        </div>
    );
};

export default ProdutoPage;