import React, { useContext } from 'react';
import { ThemeContext } from '../../Context/ThemeContext';

const HomePage = () => {
    
    const objetoTheme = useContext(ThemeContext);

    return (
        <div>

            <h1>Página Home</h1>
            <p>{objetoTheme.theme}</p>
            <p>{objetoTheme.nome}</p>

           {/*  <form action="">

                <label htmlFor="">NOME:</label>
                <input 
                type="text"
                placeholder='Digite seu nome'
                onChange={(e) => {
                    e.target.
                }}  
                />
            </form> */}
            
            
        </div>
    );
};

export default HomePage;