import React, { useState } from "react";
import { Route, BrowserRouter, Routes } from "react-router-dom";
import { ThemeContext, toggleTheme } from "../Context/ThemeContext"
import { useContext } from "react";

//import de paginas
import DadosImportantesPage from "../Pages/DadosImportantesPage/DadosImportantesPage";
import HomePage from "../Pages/HomePage/HomePage";
import LoginPage from "../Pages/LoginPage/LoginPage";
import MeusPedidosPage from "../Pages/MeusPedidosPage/MeusPedidosPage";
import ProdutoPage from "../Pages/ProdutoPage/ProdutoPage";

//imports dos compornentes
import Nav from "../Components/Nav/Nav";

//testar as rotas
//Context Api
//



const Rotas = () => {

    

    return (

        <BrowserRouter>
           
                <Nav />
                <Routes>

                    <Route element={<HomePage />} path={"/"} exact />
                    <Route element={<LoginPage />} path={"/login"} exact />
                    <Route element={<ProdutoPage />} path={"/produtos"} exact />
                    <Route element={<DadosImportantesPage />} path={"/importante"} exact />
                    <Route element={<MeusPedidosPage />} path={"/meus-pedidos"} exact />


                    <Route element={<HomePage />} path={"*"} />//qualquer rota inesistente volta para a página inicial

                </Routes>


        </BrowserRouter>

    );
}

export default Rotas;