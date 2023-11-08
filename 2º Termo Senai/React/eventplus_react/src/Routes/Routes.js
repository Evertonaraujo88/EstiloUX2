import React from "react";
import { Route, BrowserRouter, Routes } from "react-router-dom";


import TipoEventos from "../Pages/TipoEventosPage/TipoEventos";
import EventosPage from "../Pages/EventosPage/EventosPage";
import HomePage from "../Pages/HomePage/HomePage";
import LoginPage from "../Pages/LoginPage/LoginPage";
import TestePage from "../Pages/TestePage/TestePage";
import Header from "../Components/Header/Header";
import Footer from "../Components/Footer/Footer";

const Rotas = () => {
    return (


        <BrowserRouter>
            <Header />

            <Routes>


                <Route element={<HomePage />} path={"/"} exact />
                <Route element={<LoginPage />} path={"/login"} />
                <Route element={<TipoEventos />} path={"/tipo-eventos"} />
                <Route element={<EventosPage />} path={"/eventos"} />
                <Route element={<TestePage />} path={"/testes"} />

            </Routes>

            <Footer />
        </BrowserRouter>


    );
};

export default Rotas;