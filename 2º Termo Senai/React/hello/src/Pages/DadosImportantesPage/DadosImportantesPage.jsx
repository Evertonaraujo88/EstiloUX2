import React, { useContext } from 'react';
import { ThemeContext } from '../../Context/ThemeContext';

import './DadosImportantesPage.css';

const DadosImportantesPage = () => {

    const { theme } = useContext(ThemeContext);

    return (

        <div>
            <h1>Dados Importantes</h1>
            <span>{theme}</span>
        </div>



    );
};

export default DadosImportantesPage;