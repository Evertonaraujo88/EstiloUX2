
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
import api, { eventsTypeResource, eventsResource } from '../../Services/Service';


const EventosPage = () => {


    //states
    const [frmEdit, setFrmEdit] = useState(false); //esta em edicao?
    const [nome, setNome] = useState("");
    const [idTypeEvento, setIdTypeEvento] = useState("");
    const [descricao, setDescricao] = useState("");
    const [frmdata, setFrmData] = useState("");
    const [idEvento, setIdEvento] = useState(null);
    const [tipoEventos, setTipoEventos] = useState([]);// quando precisar trazer um array no useState usar []
    const [eventos, setEventos] = useState([]);// quando precisar trazer um array no useState usar []
    const [frmEditData, setfrmEditData] = useState([]);



    const [notifyUser, setNotifyUser] = useState("");
    const [showSpinner, setShowSpinner] = useState(false);//spinner loading


    useEffect(() => {

        //toda vez que houver alguma alteracao na api essa funcao correga o array tipo eventos
        async function loadEventsType() {
            setShowSpinner(true);

            try {
                const retorno = await api.get(eventsTypeResource);
                const dados = await (retorno.data.map(tipoEvento => {
                    return { value: tipoEvento.idTipoEvento, text: tipoEvento.titulo }
                }))
                setTipoEventos(dados);
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

        async function loadEvents() {
            setShowSpinner(true);

            try {
                const retorno = await api.get(eventsResource);

                setEventos(retorno.data);
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
        loadEvents();
    }, []);


    /* ******CADASTRAR****** */
    async function handleSubmit(e) {
        e.preventDefault();// evita o submit do formulario


        try {
            //('recurso', 'objeto de config')
            /*  setFrmData(new Date(frmdata).toJSON()); */
            const retorno = await api.post(eventsResource, {
                nomeEvento: nome,
                descricao: descricao,
                idTipoEvento: idTypeEvento,
                dataEvento: frmdata,
                idInstituicao: "c68e3cc2-2ad7-42f7-9dc8-96084b714a35"//"6f556c09-04bb-48e9-9953-8856b57476f8"

            });

            console.log(retorno);
            //atualiza a lista de eventos cadastrados
            const buscarEventos = await api.get(eventsResource);
            setEventos(buscarEventos.data);//aqui retornar um array com o item cadastrado
            console.log(retorno);
            //esse comando usa para zerar o imput apos enviar para api
            setNome("")
            setDescricao('')
            setFrmData('')

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

            console.error(error)

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
            setShowSpinner(true);

            const retorno = await api.put(eventsResource + "/" + idEvento, {
                
            });

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
                const retorno = await api.get(eventsResource);
                setEventos(retorno.data)
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
        // setTitulo("");
        setIdEvento(null);

    }

    //mostra o formulario de edicao
    async function showUpdateForm(evento) {

        setfrmEditData(evento)
        setFrmEdit(true);
     /*    setIdEvento(idEvento); */

        try {

            const retorno = await api.get(`${eventsResource}/${idEvento}`);
            setNome(retorno.data.nomeEvento)
            setDescricao(retorno.data.descricao)
            setTipoEventos(retorno.data.idTipoEvento)
            setFrmData(retorno.data.dataEvento)

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

            const retorno = await api.delete(`${eventsResource}/${idElement}`);

            setEventos([]);//atualiza o TipoEventos

            const buscarEventos = await api.get(eventsResource);
            setEventos(buscarEventos.data);//aqui retornar um array sem o item apagado

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
                                                value={idTypeEvento}
                                                manipulationFunction={(e) => {
                                                    setIdTypeEvento(e.target.value)
                                                }}
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
                                                id="Nome"
                                                placeholder="Nome"
                                                name={"nome"}
                                                type={"text"}
                                                required={"required"}
                                                value={frmEditData.nomeEvento}
                                                manipulationFunction={(e) => {
                                                    setNome(e.target.value);
                                                }}
                                            />

                                            <Input
                                                id="Descricao"
                                                placeholder="Descrição"
                                                name={"descricao"}
                                                type={"text"}
                                                required={"required"}
                                                value={frmEditData.descricao}
                                                manipulationFunction={(e) => { setDescricao(e.target.value); }}
                                            />

                                            <Select
                                                id="tipo-evento"
                                                name="tipo-evento"
                                                required="required"
                                                options={tipoEventos}
                                                value={frmEditData.idTypeEvento}
                                                manipulationFunction={(e) => {
                                                    setIdTypeEvento(e.target.value)
                                                }}
                                            />



                                            <Input
                                                id="Data"
                                                placeholder="Data do Evento"
                                                name={"data"}
                                                type={"date"}
                                                required={"required"}
                                                value={new Date(frmEditData.dataEvento).toLocaleDateString("sv-SE")}
                                                manipulationFunction={(e) => { setFrmData(e.target.value); }}
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
                            dados={eventos}
                            dadosTp={tipoEventos}
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