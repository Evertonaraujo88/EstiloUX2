import React, { useContext, useEffect, useState } from "react";
import ImageIllustrator from "../../Components/ImageIllustrator/ImageIllustrator";
import logo from "../../Assets/Images/logo-pink.svg";
import loginImg from "../../Assets/Images/login.svg";
import { Input, Button } from "../../Components/FormComponents/FormComponents";
import Notification from '../../Components/Notification/Notification';

//hook que retorna a funcao que destina para a rota que você definir
import { useNavigate } from "react-router-dom";


import "./LoginPage.css";

//api
import api, { loginResource } from '../../Services/Service';
import { UserContext, userDecodeToken } from "../../Context/AuthContext";


const LoginPage = () => {

    const [user, setUser] = useState({  email: "adm@adm.com", senha: "senai123"  });

    const [notifyUser, setNotifyUser] = useState("");

    //importa os dados globais (context Api)
    const { userData, setUserData } = useContext(UserContext);
    const navigate = useNavigate();

    useEffect(() => {
        if (userData.nome) {
            navigate("/");
        }
    }, [userData]);

    async function handleSubmit(e) {
        e.preventDefault();

        //validar usuário e senha:

        //tamanho mínimo de caracteres: 3
        if (user.email.length >= 3 && user.senha.length >= 3) {

            try {

                const promise = await api.post(loginResource, {
                    email: user.email,
                    senha: user.senha
                })

                //visualizar no consele os dados
                console.log("dados do usuario:");
                console.log(promise.data);

                //decodificando o token gerado pela promise
                const userFullToken = userDecodeToken(promise.data.token);

                //guarda token
                setUserData(userFullToken);

                localStorage.setItem("token", JSON.stringify(userFullToken));
                navigate("/"); //envia o usuario para homePage

                setNotifyUser({
                    titleNote: "Sucesso",
                    textNote: "Login efetuado com Sucesso!!!",
                    imgIcon: "success",
                    imgAlt:
                        "Image de ilustracao de sucesso. Moça segurando um balão com símbolo de confirmação ok",
                    showMessage: true
                });



            } catch (error) {

                //erro da api: BAD REQUEST  (401) ou erro de conexao
                alert("verifique is dados e a conexão cin a internet")
                console.log("erros no longin do usuario");
                console.log(error);
            }

        } else {
            alert("Informar os dados corretos")
        }

    }


    return (

        <>
            {<Notification {...notifyUser} setNotifyUser={setNotifyUser} />}

            <div className="layout-grid-login">
                <div className="login">
                    <div className="login__illustration">
                        <div className="login__illustration-rotate"></div>
                        <ImageIllustrator
                            imageRender={loginImg}
                            altText="Imagem de um homem em frente de uma porta de entrada"
                            additionalClass="login-illustrator "
                        />
                    </div>

                    <div className="frm-login">
                        <img src={logo} className="frm-login__logo" alt="" />

                        <form className="frm-login__formbox" onSubmit={handleSubmit}>
                            <Input
                                additionalClass="frm-login__entry"
                                type="email"
                                id="login"
                                name="login"
                                required={true}
                                value={user.email}
                                manipulationFunction={(e) => {
                                    setUser({ ...user, email: e.target.value.trim() })
                                }}
                                placeholder="Username"
                            />
                            <Input
                                additionalClass="frm-login__entry"
                                type="password"
                                id="senha"
                                name="senha"
                                required={true}
                                value={user.senha}
                                manipulationFunction={(e) => {
                                    setUser({ ...user, senha: e.target.value.trim() })
                                }}

                                placeholder="****"
                            />

                            <a href="" className="frm-login__link">
                                Esqueceu a senha?
                            </a>

                            <Button

                                textButton="Login"
                                id="btn-login"
                                name="btn-login"
                                type="submit"
                                additionalClass="frm-login__button"

                            />
                        </form>
                    </div>
                </div>
            </div>
        </>

    );
};

export default LoginPage;
