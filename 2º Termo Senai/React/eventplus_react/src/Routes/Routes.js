import React from "react";
import { Route, BrowserRouter, Routes } from "react-router-dom";

import React from 'react';

const Routes = () => {
    return (
        <div>

            <BrowserRouter>
                <Routes>
                    <Route element={<HomePage />} path={"/"} exact />
                    <Route element={<LoginPage />} path={"/login"} exact />
                    <Route element={} path={"/"} exact />
                </Routes>
            </BrowserRouter>

        </div>
    );
};

export default Routes;