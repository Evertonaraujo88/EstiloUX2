
import React, { useEffect, useState } from 'react';
import Container from '../../Components/Container/Container';
import ImageIllustrator from '../../Components/ImageIllustrator/ImageIllustrator';
import MainContent from '../../Components/MainContent/MainContent';
import Title from '../../Components/Title/Title';
import { Input, Button, Select } from '../../Components/FormComponents/FormComponents';
import TableEv from './TableEv/TableEv';
import Notification from '../../Components/Notification/Notification';
import Spinner from '../../Components/Spinner/Spinner';


//estilizacao
import './EventosPage.css';

//imagens
import EventoImagem from '../../Assets/Images/evento.svg';

//api
import api, { eventsTypeResource } from '../../Services/Service';


const EventosPage = () => {


    //states
    const [frmEdit, setFrmEdit] = useState(false); //esta em edicao?
    const [nome, setNome] = useState("");
    const [titulo, setTitulo] = useState("");
    const [descricao, setDescricao] = useState("");
    const [frmdata, setFrmData] = useState("");
    const [idEvento, setIdEvento] = useState(null);
    const [tipoEventos, setTipoEventos] = useState([]);// quando precisar trazer um array no useState usar []
    const [notifyUser, setNotifyUser] = useState("");
    const [showSpinner, setShowSpinner] = useState(false);//spinner loading


    useEffect(() => {

        //toda vez que houver alguma alteracao na api essa funcao correga o array tipo eventos
        async function loadEventsType() {
            setShowSpinner(true);

            try {
                const retorno = await api.get(eventsTypeResource);

                setTipoEventos(retorno.data);
                console.log(retorno.data);

            } catch (error) {
                setNotifyUser({
                    titleNote: "danger",
                    textNote: 'Erro api na funcao loadEventsType no tipoEventos.JSX',
                    imgIcon: "danger",
                    imgAlt: "Imagem de illustracao de erro, Rapaz segurando im balão com símbolo",
                    showMessage: true
                });

                console.log(error);
            }

            setShowSpinner(false);
        }
        //chama a funcao/api no carregamento da page/componentes
        loadEventsType();
    }, []);

 /*    async function loadEventsType() {
        try {
            const retorno = await api.get(eventsTypeResource)
            setTipoEventos(retorno.data)
        } catch (error) {
            console.log(error)
        }
    } */

    /* ******CADASTRAR****** */
    async function handleSubmit(e) {
        e.preventDefault();// evita o submit do formulario

        if (titulo.trim().length < 3) {

            setNotifyUser({
                titleNote: "Aviso",
                textNote: 'O titulo deve ter pelo menos tres caracteres!',
                imgIcon: "warning",
                imgAlt: "Imagem de illustracao de aviso.",
                showMessage: true
            });

            return;
        }


        try {
            //('recurso', 'objeto de config')
            const retorno = await api.post(eventsTypeResource, {
                titulo: titulo
            });

            //atualiza a lista de eventos cadastrados
            const buscarEventos = await api.get(eventsTypeResource);
            setTipoEventos(buscarEventos.data);//aqui retornar um array com o item cadastrado

            //esse comando usa para zerar o imput apos enviar para api
            setTitulo("");

            setNotifyUser({
                titleNote: "Sucesso",
                textNote: "Evento cadastrado com sucesso",
                imgIcon: "success",
                imgAlt:
                    "Image de ilustracao de sucesso. Moça segurando um balão com símbolo de confirmação ok",
                showMessage: true
            });
            console.log(retorno);

        } catch (error) {

            setNotifyUser({
                titleNote: "danger",
                textNote: 'deu ruim no submit da funcao handleSubmit',
                imgIcon: "danger",
                imgAlt: "Imagem de illustracao de erro, Rapaz segurando im balão com símbolo",
                showMessage: true
            });


        }

    }

    /* ******ATUALIZAR****** */
    async function handleUpdate(e) {


        try {

            e.preventDefault();

            const retorno = await api.put(eventsTypeResource + "/" + idEvento, { "titulo": titulo });

            if (retorno.status === 204) {
                //avisa o usuario que foi cadastrado
                setNotifyUser({
                    titleNote: "Sucesso",
                    textNote: "Evento alterado com sucesso",
                    imgIcon: "success",
                    imgAlt: "Imagem de illustracao de sucesso",
                    showMessage: true
                });

                //atualiza os dados na tela
                const retorno = await api.get(eventsTypeResource);
                setTipoEventos(retorno.data)
            }

            //volta para a tela de cadastro
            editActionAbort();


        } catch (error) {

            //avisa o usuario que deu erro na execução da etapa
            setNotifyUser({
                titleNote: "danger",
                textNote: 'deu ruim no submit da funcao handleUpdate',
                imgIcon: "danger",
                imgAlt: "Imagem de illustracao de erro, Rapaz segurando im balão com símbolo",
                showMessage: true
            });
        }
    }

    //cancela a tela de edicao
    function editActionAbort() {

        setFrmEdit(false);
        setTitulo("");
        setIdEvento(null);

    }

    //mostra o formulario de edicao
    async function showUpdateForm(idElement) {

        setFrmEdit(true);
        setIdEvento(idElement);

        try {

            const retorno = await api.get(`${eventsTypeResource}/${idElement}`);
            setTitulo(retorno.data.titulo)

            console.log(retorno);

        } catch (error) {

            setNotifyUser({
                titleNote: "danger",
                textNote: 'deu ruim no delete na função showUpdateForm',
                imgIcon: "danger",
                imgAlt: "Imagem de illustracao de erro, Rapaz segurando im balão com símbolo",
                showMessage: true
            });
        }



    }

    /* ******DELETAR****** */
    async function handleDelete(idElement) {

        if (!window.confirm("Confirma a exclusão?")) {

            return;
        }

        try {

            const retorno = await api.delete(`${eventsTypeResource}/${idElement}`);

            setTipoEventos([]);//atualiza o TipoEventos

            const buscarEventos = await api.get(eventsTypeResource);
            setTipoEventos(buscarEventos.data);//aqui retornar um array sem o item apagado

            setNotifyUser({
                titleNote: "Sucesso",
                textNote: "Evento excluído com sucesso",
                imgIcon: "success",
                imgAlt: "Imagem de illustracao de sucesso",
                showMessage: true
            });

            console.log(retorno);

        } catch (error) {

            alert("deu ruim no delete na handleDelete")
        }

    }

    function theMagic() {
        setNotifyUser({
            titleNote: "Sucesso",
            textNote: "Evento excluído com sucesso",
            imgIcon: "success",
            imgAlt: "Imagem de illustracao de sucesso",
            showMessage: true
        });
    }

    return (
        <>
            {<Notification {...notifyUser} setNotifyUser={setNotifyUser} />}

            {showSpinner ? <Spinner /> : null}

            <MainContent>
                <section className='cadastro-evento-section'>
                    {/* título */}
                    <Title titleText={"Eventos"} />
                    <Container>
                        <div className='cadastro-evento__box'>

                            {/* imagem de ilustração */}
                            <ImageIllustrator
                                imageRender={EventoImagem}
                            />
                            {/* componente de formulário*/}
                            <form
                                className='ftipo-evento'
                                onSubmit={frmEdit ? handleUpdate : handleSubmit}
                            >
                                {/* {cadastrar ou editar} */}
                                {
                                    !frmEdit ? (
                                        <>
                                            <Input
                                                id="Nome"
                                                placeholder="Nome"
                                                name={"nome"}
                                                type={"text"}
                                                required={"required"}
                                                value={nome}
                                                manipulationFunction={(e) => { setNome(e.target.value); }}
                                            />

                                            <Input
                                                id="Descricao"
                                                placeholder="Descrição"
                                                name={"descricao"}
                                                type={"text"}
                                                required={"required"}
                                                value={descricao}
                                                manipulationFunction={(e) => { setDescricao(e.target.value); }}
                                            />

                                            <Select
                                                id="tipo-evento"
                                                name="tipo-evento" 
                                                required="required" 
                                                options={tipoEventos}
                                                manipulationFunction={(e) => {
                                                    setFrmData({
                                                        ...frmdata,
                                                        idTipoEvento: e.target.value
                                                    })

                                                }}

                                                defaultValue={0}
                                            />


                                            <Input
                                                id="Data"
                                                placeholder="Data do Evento"
                                                name={"data"}
                                                type={"date"}
                                                required={"required"}
                                                value={frmdata}
                                                manipulationFunction={(e) => { setFrmData(e.target.value); }}
                                            />

                                            <Button
                                                textButton="Cadastrar"
                                                id="cadastrar"
                                                name="cadastrar"
                                                type="submit"
                                            />

                                            {/*  <Button
                                                textButton="Magica"
                                                id="cadastrar"
                                                name="cadastrar"
                                                type="button"
                                                manipulationFunction={theMagic}
                                            /> */}
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
                                            <div className='buttons-editbox'>
                                                <Button
                                                    textButton="Atualizar"
                                                    id="atualizar"
                                                    name="atualizar"
                                                    type="submit"
                                                    additinalClass='button-component--middle'
                                                />

                                                <Button

                                                    textButton="Cancelar"
                                                    id="cancelar"
                                                    name="cancelar"
                                                    type="button"
                                                    manipulationFunction={editActionAbort}
                                                    additinalClass='button-component--middle'
                                                />
                                            </div>

                                        </>

                                    )
                                }
                            </form>

                        </div>
                    </Container>
                </section>

                <section className='lista-eventos-section'>
                    <Container>
                        <Title titleText={"Lista de Eventos"} color='white' />
                        <TableEv
                            dados={tipoEventos}
                            fnUpdate={showUpdateForm}
                            fnDelete={handleDelete}
                        />
                    </Container>
                </section>
            </MainContent>
        </>
    );
};

export default EventosPage;