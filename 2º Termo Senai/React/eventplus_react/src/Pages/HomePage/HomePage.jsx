import React from 'react';
import Banner from '../../Components/Banner/Banner';
import ContactSection from '../../Components/ContactSection/ContactSection';
import Container from '../../Components/Container/Container';
import MainContent from '../../Components/MainContent/MainContent';
import NextEvent from '../../Components/NextEvent/NextEvent';
import Title from '../../Components/Title/Title';
import VisionSection from '../../Components/VisionSection/VisionSection';

//import estilizacao
import './HomePage.css';

//import imagens



const HomePage = () => {
    return (

        <MainContent>

            <Banner />

            <section className='proximos-eventos'>

                <Container>
                    
                    <Title titleText={"Proximos Eventos"} />

                    <div className='events-box'>

                        <NextEvent
                            title={"Api"}
                            description={"Evento de Api com o Carlão"}
                            eventDate={"15/12/2023"}
                            idEvent={"baskgquebajkkanilusmdcbdkuad"}
                        />
                        <NextEvent
                            title={"React"}
                            description={"Evento de React com O Edu"}
                            eventDate={"15/12/2023"}
                            idEvent={"baskgquebajkbdkuad"}
                        />
                        <NextEvent
                            title={"Banco de Dados"}
                            description={"Bando de dados do zero ao avançado"}
                            eventDate={"15/12/2023"}
                            idEvent={"baskgqueba16481klashiujkbdkuad"}
                        />

                    </div>
                </Container>


            </section>

            <VisionSection />

            <ContactSection />


        </MainContent>

    );
};

export default HomePage;