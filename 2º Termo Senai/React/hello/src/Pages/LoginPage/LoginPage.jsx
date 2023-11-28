import React,{ useContext } from 'react';
import { ThemeContext } from '../../Context/ThemeContext';

const LoginPage = () => {
    const {theme} = useContext(ThemeContext);

    return (
        <div>
            <h1>Login Page</h1>
            <span>{theme}</span>
            
        </div>
    );
};

export default LoginPage;