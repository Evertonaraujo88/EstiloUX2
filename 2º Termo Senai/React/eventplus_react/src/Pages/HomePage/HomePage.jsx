import React, { useEffect, useState } from 'react';
import Banner from '../../Components/Banner/Banner';
import ContactSection from '../../Components/ContactSection/ContactSection';
import Container from '../../Components/Container/Container';
import MainContent from '../../Components/MainContent/MainContent';
import NextEvent from '../../Components/NextEvent/NextEvent';
import Title from '../../Components/Title/Title';
import VisionSection from '../../Components/VisionSection/VisionSection';
import axios from 'axios';

import api from '../../Services/Service';


//import estilizacao
import './HomePage.css';

//import imagens



const HomePage = () => {

    const [nextEvents, setNextEvents] = useState([]);
    

    //roda somente na inicialização do componente
    useEffect(() => {

        async function getNextEvents() {

            try {

                const promise = await api.get(`/Evento/ListarProximos`);
                const dados = await promise.data;

                setNextEvents(dados); //atualiza o state

            } catch (error) {
                alert("Erro!!!")
            }

        }

        //roda a função
        getNextEvents();

    }, []);

    return (

        <MainContent>

            <Banner />

            <section className='proximos-eventos'>

                <Container>

                    <Title titleText={"Proximos Eventos"} />

                    <div className='events-box'>

                        {   //map busca o array original e retorna modificado
                           /*  nextEvents.map((e) => {

                                return (

                                    <NextEvent
                                        key={e.idEvento}
                                        title={e.nomeEvento}
                                        description={e.descricao}
                                        eventDate={e.dataEvento}
                                        idEvent={e.idEvento}
                                    />
                                );

                            }) */
                            nextEvents.map((e) => {

                                return (

                                    <NextEvent
                                        key={e.idEvento}
                                        title={e.nomeEvento}
                                        description={e.descricao}
                                        eventDate={e.dataEvento}
                                        idEvent={e.idEvento}
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