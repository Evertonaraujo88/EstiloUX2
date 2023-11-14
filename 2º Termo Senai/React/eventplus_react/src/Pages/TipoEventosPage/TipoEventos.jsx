import React, { useEffect, useState } from 'react';
import Container from '../../Components/Container/Container';
import ImageIllustrator from '../../Components/ImageIllustrator/ImageIllustrator';
import MainContent from '../../Components/MainContent/MainContent';
import Title from '../../Components/Title/Title';
import { Input, Button } from '../../Components/FormComponents/FormComponents';
import TableTp from './TableTp/TableTp';

//estilizacao
import './TipoEventos.css';

//imagens
import tipoEventoImagem from '../../Assets/Images/tipo-evento.svg';

//api
import api, { eventsTypeResource } from '../../Services/Service';





const TipoEventos = () => {

    const [frmEdit, setFrmEdit] = useState(false); //esta em edicao?
    const [titulo, setTitulo] = useState("");
    const [tipoEventos, setTipoEventos] = useState([]);

    useEffect(() => {

        async function loadEventsType() {

            try {
                const retorno = await api.get(eventsTypeResource);

                setTipoEventos(retorno.data);
                console.log(retorno.data);
            } catch (error) {
                console.log("Erro api na funcao loadEventsType no tipoEventos.JSX");
                console.log(error);
            }

        }
        //chama a funcao/api no carregamento da oaguna/componentes
        loadEventsType();
    }, []);


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

            //esse comando usa para zerar o imput apos enviar para api
            setTitulo("");

            alert("Cadastrado com sucesso!!")
            console.log(retorno);

        } catch (error) {

            alert("deu ruim no submit da funcao handleSubmit")

        }

    }

    async function handleUpdate(e) {
        e.preventDefault();


        try {

            const retorno = await api.put(eventsTypeResource, {
                titulo: titulo
            });

            alert("Alterado com Sucesso")
            console.log(retorno);



        } catch (error) {

            alert("deu ruim no submit da funcao handleUpdate")
        }
    }

    //cancela a tela de edicao
    function editActionAbort() {
        alert("Cancelar a tela de edicao de dados")
    }

    //mostra o formulario de edicao
    function showUpdateForm() {
        alert('vamos mostrar o formularo de edicao');
    }

    //apaga o tipo de evento
    async function handleDelete(idElement) {
        alert(`vamos apagar o evento de id: ${idElement}`);
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
                                            value={titulo}
                                            manipulationFunction={(e) => {
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

                                        <Input

                                            id="Titulo"
                                            placeholder="Título"
                                            name={"titulo"}
                                            type={"text"}
                                            required={"required"}
                                            value={titulo}
                                            manipulationFunction={(e) => {
                                                setTitulo(e.target.value);
                                            }}

                                        />

                                        <Button

                                            textButton="Editar"
                                            id={"editar"}
                                            name={"editar"}
                                            type={"submit"}

                                        />

                                    </>

                                )
                            }
                        </form>



                    </div>
                </Container>

            </section>

            <section className='lista-eventos-section'>

                <Container>
                    <Title titleText={"Lista Tipos de Eventos"} color="white" />

                    <TableTp
                        dados={TipoEventos}
                        fnUpdate={showUpdateForm}
                        fnDelete={handleDelete}


                    />


                </Container>

            </section>

        </MainContent>


    );
};

export default TipoEventos;