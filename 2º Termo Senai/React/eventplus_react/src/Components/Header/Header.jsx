import React from 'react';
import Container from '../Container/Container'
import Nav from '../Nav/Nav'
import PerfilUsuario from '../PerfilUsuario/PerfilUsuario';

//Import Css
import '../Header.css';

//import Imagens
import menubar from '../../Assets/Images/menubar.png';

const Header = () => {
    return (
        <header className='headerpage'>
            <Container>
                <div className='header-flex'>
                    <img src={menubar} alt="imagem menu de barras, serve para ativar, exibir ou esconder o menu do smartPhone" />
                     

                     
                     <Nav />

                     <PerfilUsuario/>
                </div>
            </Container>

        </header>
    );
};

export default Header;