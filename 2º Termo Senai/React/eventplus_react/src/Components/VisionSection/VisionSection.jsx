import React from 'react';
import Title from '../Title/Title';
import './VisionSection.css'

const VisionSection = () => {
    return (

        <section className='vision'>

            <div className='vision__box'>

                <Title
                    titleText={"Visão"}
                    color='white'
                    potatoClass='vision__title'
                />
                <p className='vision__text'>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Sequi nemo ea quisquam placeat eligendi? Atque doloribus id dolores optio nesciunt maxime pariatur sunt sed consectetur ullam? Maiores nulla porro saepe?
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Sequi nemo ea quisquam placeat eligendi? Atque doloribus id dolores optio nesciunt maxime pariatur sunt sed consectetur ullam? Maiores nulla porro saepe?
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Sequi nemo ea quisquam placeat eligendi? Atque doloribus id dolores optio nesciunt maxime pariatur sunt sed consectetur ullam? Maiores nulla porro saepe?
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Sequi nemo ea quisquam placeat eligendi? Atque doloribus id dolores optio nesciunt maxime pariatur sunt sed consectetur ullam? Maiores nulla porro saepe?
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Sequi nemo ea quisquam placeat eligendi? Atque doloribus id dolores optio nesciunt maxime pariatur sunt sed consectetur ullam? Maiores nulla porro saepe?
                </p>
                <p className='vision__text'>A visão do SENAI é consolidar-se como o líder nacional em educação profissional e tecnológica e ser reconhecido como indutor da inovação e da transferência de tecnologias para a Indústria Brasileira, atuando com padrão internacional de excelência.</p>

            </div>

        </section>
    );
};

export default VisionSection;