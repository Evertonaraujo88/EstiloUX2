import React from 'react';
import '../Nav.css';

//import imagens
import logoMobile from '../../Assets/Images/logo-white.svg';
import logoDesktop from '../../Assets/Images/logo-pink.svg';

const Nav = () => {
    return (
        <div>
            <nav className='navbar'>
                <span className='navbar_close'>X</span>

                <a href="" className='eventlogo'>
                    <img 
                    className='eventlogo__logo-image' 
                    src={logoMobile} 
                    alt="" />
                </a>
                
                <div className='navbar__items-box'> 
                    <a href="">Home</a>
                    <a href="">Tipos de Evento</a>
                    <a href="">Usuarios</a>
                </div>

            </nav>
        </div>
    );
};

export default Nav;