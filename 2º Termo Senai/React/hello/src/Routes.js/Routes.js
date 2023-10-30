import React from "react";
import { Route, BrowserRouter, Routes } from "react-router-dom";
import HomePage from "../Pages/HomePage/HomePage";
import LoginPage from "../Pages/LoginPage/LoginPage";
import ProdutoPage from "../Pages/ProdutoPage/ProdutoPage";


//imports dos compornentes

const Rotas = () => {

    return (

        <BrowserRouter>

            <Routes>

                <Route element={<HomePage />} path={"/"} exact />
                <Route element={<LoginPage />} path={"/login"} exact />
                <Route element={<ProdutoPage />} path={"/produtos"} exact />
                
            </Routes>

        </BrowserRouter>

    );
}

export default Rotas;