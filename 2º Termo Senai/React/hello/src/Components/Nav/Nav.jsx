import React, { useContext } from 'react';
import { Link } from 'react-router-dom';
import { ThemeContext, toggleTheme } from '../../Context/ThemeContext';


import './Nav.css';

const Nav = () => {

    const { theme, setTheme } = useContext(ThemeContext);

    const toggleTheme = () => {
        const tm = theme === 'light' ? "dark" : "light";
        setTheme(tm);
        /* setTheme ( theme === 'light' ? "dark" : "light") */

        localStorage.setItem("theme", tm);//salva no navegador
    }



    return (
        <nav>

            <Link to="/">Home</Link> | &nbsp;
            <Link to="/produtos">Produtos</Link> | &nbsp;
            <Link to="/importante">Dados importantes</Link> | &nbsp;
            <Link to="/meus-pedidos">Meus Pedidos</Link> | &nbsp;
            <Link to="/login">Login</Link> | &nbsp;

            <button onClick={toggleTheme}> {theme}</button>

        </nav>
    );
};

export default Nav;