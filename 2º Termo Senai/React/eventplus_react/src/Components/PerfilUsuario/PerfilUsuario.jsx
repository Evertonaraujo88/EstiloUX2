import React, { useContext } from 'react';
import iconeLogout from "../../Assets/Images/icone-logout.svg";

//import estilização
import '../PerfilUsuario/PerfilUsuario.css';

import { UserContext } from '../../Context/AuthContext';
import { Link, useNavigate } from 'react-router-dom';

const PerfilUsuario = () => {

    const { userData, setUserData } = useContext(UserContext);

    const navigate = useNavigate();

    const logout = () => {
        localStorage.removeItem("token");
        setUserData({});
        navigate("");
    };

    return (
        <div className="perfil-usuario">


            {userData.nome ? (
                <>

                    <span className="perfil-usuario__menuitem">{userData.nome}</span>

                    <img
                        title="Deslogar"
                        className="perfil-usuario__icon"
                        src={iconeLogout}
                        alt="imagem ilustrativa de uma porta de saída do usuário "
                        onClick={logout}
                    />

                </>

            ) : (
                <Link to="/login" className="perfil-usuario__menuitem" >
                    Login
                </Link>
            )}




        </div>
    );
};

export default PerfilUsuario;
