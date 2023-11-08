import React from 'react';
import Banner from '../../Components/Banner/Banner';
import ContactSection from '../../Components/ContactSection/ContactSection';
import MainContent from '../../Components/MainContent/MainContent';
import VisionSection from '../../Components/VisionSection/VisionSection';



const HomePage = () => {
    return (

        <MainContent>

            <Banner />
            <VisionSection />
            <ContactSection />


        </MainContent>

    );
};

export default HomePage;