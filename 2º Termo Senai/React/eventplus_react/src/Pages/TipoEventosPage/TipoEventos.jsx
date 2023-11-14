import React, { useState } from 'react';
import Container from '../../Components/Container/Container';
import ImageIllustrator from '../../Components/ImageIllustrator/ImageIllustrator';
import MainContent from '../../Components/MainContent/MainContent';
import Title from '../../Components/Title/Title';
import { Input, Button } from '../../Components/FormComponents/FormComponents';


//estilizacao
import './TipoEventos.css';

//imagens
import tipoEventoImagem from '../../Assets/Images/tipo-evento.svg';

//api
import api, { eventsTypeResource } from '../../Services/Service';




const TipoEventos = () => {

    const [frmEdit, setFrmEdit] = useState(false); //esta em edicao?
    const [titulo, setTitulo] = useState("");


    async function handleSubmit(e) {
        e.preventDefault();// evita o submit do formulario

        if (titulo.trim().length < 3) {
            alert('O titulo deve ter pelo menos tres caracteres!')
        }

        try {
                                        //('recurso', 'objeto de config')
            const retorno = await api.post(eventsTypeResource, {
                titulo: titulo
            });

            alert("Cadastrado com sucesso!!")
            console.log(retorno);
        } catch (error) {

            alert("deu ruim no submit da funcao handleSubmit")

        }

    }

    function handleUpdate() {
        alert('Bora alterar')
    }
    return (


        <MainContent>

            <section className='cadastro-evento-section'>

                <Container>

                    <div className='cadastro-evento__box'>
                        {/* Titulo */}
                        <Title titleText={"Cadastro Tipos de Eventos"} />

                        {/* imagem de ilustracao */}
                        <ImageIllustrator
                            imageRender={tipoEventoImagem}
                        />

                        {/* componente formulario */}
                        <form
                            className='ftipo-evento'
                            onSubmit={frmEdit ? handleUpdate : handleSubmit}
                        >
                            {/* cadastrar ou editar? */}
                            {
                                !frmEdit ? (
                                    <>

                                        <Input

                                            id="Titulo"
                                            placeholder="Título"
                                            name={"titulo"}
                                            type={"text"}
                                            required={"required"}
                                            value = {titulo}
                                            manipulationFunction = {(e)=>{
                                                setTitulo(e.target.value);
                                            }}

                                        />
                                                                             
                                        <Button

                                            textButton="Cadastrar"
                                            id={"cadastrar"}
                                            name={"cadastrar"}
                                            type={"submit"}
                                            
                                        />

                                    </>


                                ) : (

                                    <>

                                        <p>Tela de edicao</p>

                                    </>


                                )
                            }
                        </form>

                    </div>
                </Container>

            </section>

        </MainContent>


    );
};

export default TipoEventos;