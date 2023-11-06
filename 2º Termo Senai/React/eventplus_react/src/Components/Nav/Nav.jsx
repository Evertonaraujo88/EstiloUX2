import React from 'react';
import '../Nav/Nav.css';

//import imagens
import logoMobile from '../../Assets/Images/logo-white.svg';
import logoDesktop from '../../Assets/Images/logo-pink.svg';
import { Link } from 'react-router-dom';

const Nav = ({ exibeNavbar, setExibeNavbar }) => {

    console.log(`exibe o menu? ${exibeNavbar}`);
    return (

        <nav className={`navbar ${exibeNavbar ? "exibeNavbar" : ""}`}>
            <span
                onClick={() => { setExibeNavbar(false) }}
                className='navbar__close'
            >
                X
            </span>

            <Link to="/" className='eventlogo'>
                <img
                    className='eventlogo__logo-image'
                    src={window.innerWidth >= 992 ? logoDesktop : logoMobile}
                    alt="Event plus Logo"
                />
            </Link>

            <div className='navbar__items-box'>

                <Link to="/" className='navbar__item'>Home</Link>
                <Link to="/tipo-eventos" className='navbar__item'>Tipos de Evento</Link>
                <Link to="/eventos" className='navbar__item'>Eventos</Link>
                <Link to="/login" className='navbar__item'>Login</Link>
                <Link to="/testes" className='navbar__item'>Testes</Link>

            </div>

        </nav>

    );
};

export default Nav;