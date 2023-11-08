import React, { useState } from 'react';
import Container from '../Container/Container'
import Nav from '../Nav/Nav'
import PerfilUsuario from '../PerfilUsuario/PerfilUsuario';

//Import Css
import './Header.css';

//import Imagens
import menubar from '../../Assets/Images/menubar.png';


const Header = () => {

    const [exibeNavbar, setExibeNavbar] = useState(false);  //exibe/esconde menu hamurger

    return (
        <header className='headerpage'>
            <Container>

                <div className='header-flex'>
                    <img 
                    className='headerpage__menubar'
                    src={menubar} 
                    alt="imagem menu de barras, serve para ativar, exibir ou esconder o menu do smartPhone" 
                    onClick={ () => {setExibeNavbar(true)}}
                    />
                                          
                     <Nav exibeNavbar={exibeNavbar} setExibeNavbar= {setExibeNavbar}/>

                     <PerfilUsuario/>
                </div>

               

            </Container>

        </header>
    );
};

export default Header;