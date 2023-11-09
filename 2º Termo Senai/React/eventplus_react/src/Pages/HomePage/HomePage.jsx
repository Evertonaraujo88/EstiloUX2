import React, { useState } from 'react';
import Banner from '../../Components/Banner/Banner';
import ContactSection from '../../Components/ContactSection/ContactSection';
import Container from '../../Components/Container/Container';
import MainContent from '../../Components/MainContent/MainContent';
import NextEvent from '../../Components/NextEvent/NextEvent';
import Title from '../../Components/Title/Title';
import VisionSection from '../../Components/VisionSection/VisionSection';
import axios from 'axios';

//import estilizacao
import './HomePage.css';

//import imagens



const HomePage = () => {

    const [nextEvents, setNextEvents] = useState([
        { id: 1, title: "Evento x", description: "Evento de programacao x", eventDate: "10/11/2023" },
        { id: 2, title: "Evento y", description: "Evento de programacao y", eventDate: "15/11/2023" },

    ]); //dados "mocados"

    return (

        <MainContent>

            <Banner />

            <section className='proximos-eventos'>

                <Container>

                    <Title titleText={"Proximos Eventos"} />

                    <div className='events-box'>

                        {
                            nextEvents.map((e) => {

                                return (
                                    <NextEvent
                                        title={e.title}
                                        description={e.description}
                                        eventDate={e.eventDate}
                                        idEvent={e.id}
                                    />
                                    );

                            })
                        }


                    </div>
                </Container>


            </section>

            <VisionSection />

            <ContactSection />


        </MainContent>

    );
};

export default HomePage;