import React from 'react';
import Title from '../Title/Title';
import './ContactSection.css';
import contatoMap from '../../Assets/Images/contato-map.png';

const ContactSection = () => {
    return (
        <section className='contato'>

            <Title titleText={"Contato"} />

            <div className='contato__endereco-box'>

                <img
                    src={contatoMap}
                    alt=""
                    className='contato__img-map'
                />

                <p>

                    Rua Niteroi, 180 - Centro <br />
                    São Caetano do SUl - SP <br />
                    <a href="tel:+551142252000" className='contato__telefone'>
                        (11) 4225-2000
                    </a>

                </p>

            </div>


        </section>
    );
};

export default ContactSection;