import React from "react";
import { Route, BrowserRouter, Routes } from "react-router-dom";
import { PrivateRoute } from "./PrivateRoute";


import TipoEventosPage from "../Pages/TipoEventosPage/TipoEventos";
import EventosPage from "../Pages/EventosPage/EventosPage";
import HomePage from "../Pages/HomePage/HomePage";
import LoginPage from "../Pages/LoginPage/LoginPage";
import TestePage from "../Pages/TestePage/TestePage";
import Header from "../Components/Header/Header";
import Footer from "../Components/Footer/Footer";
import InstituicaoPage from "../Pages/InstituicaoPage/InstituicaoPage";
import EventosAlunoPage from "../Pages/EventosAlunoPage/EventosAlunoPage";

const Rotas = () => {
    return (


        <BrowserRouter>
            <Header />

            <Routes>
                {/* ROTAS PÚBLICAS */}
                <Route element={<LoginPage />} path="/login"  />
                <Route element={<HomePage />} path="/" exact/>

                {/* ROTAS PRIVADAS */}
                <Route
                    element={
                        <PrivateRoute redirectTo="/">
                            <TipoEventosPage />
                        </PrivateRoute>}
                    path="/tipo-eventos"
                />

                <Route
                    element={
                        <PrivateRoute redirectTo="/">
                            <EventosPage />
                        </PrivateRoute>}
                    path="/eventos"
                />

                <Route
                    element={
                        <PrivateRoute redirectTo="/">
                            <InstituicaoPage />
                        </PrivateRoute>}
                    path="/instituicao"
                />
                <Route
                    element={
                        <PrivateRoute redirectTo="/">
                            <EventosAlunoPage />
                        </PrivateRoute>}

                    path="/eventos-aluno"
                />
            </Routes>

            <Footer />
        </BrowserRouter>


    );
};

export default Rotas;