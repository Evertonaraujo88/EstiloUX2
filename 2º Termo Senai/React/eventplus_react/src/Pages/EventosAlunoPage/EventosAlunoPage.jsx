import React, { useContext, useEffect, useState } from "react";
import Header from "../../Components/Header/Header";
import MainContent from "../../Components/MainContent/MainContent";
import Title from "../../Components/Title/Title";
import Table from "./TableEvA/TableEvA";
import Container from "../../Components/Container/Container";
import { Select } from "../../Components/FormComponents/FormComponents";
import Spinner from "../../Components/Spinner/Spinner";
import Modal from "../../Components/Modal/Modal";
import api, { eventsResource, myEventsResource } from "../../Services/Service";

import "./EventosAlunoPage.css";
import { UserContext } from "../../Context/AuthContext";

const EventosAlunoPage = () => {
  // state do menu mobile
  const [exibeNavbar, setExibeNavbar] = useState(false);
  const [eventos, setEventos] = useState([]);
  // select mocado
  const [quaisEventos, setQuaisEventos] = useState([
    { value: 1, text: "Todos os eventos" },
    { value: 2, text: "Meus eventos" },
  ]);

  const [tipoEvento, setTipoEvento] = useState("1"); //código do tipo do Evento escolhido
  const [showSpinner, setShowSpinner] = useState(false);
  const [showModal, setShowModal] = useState(false);

  // recupera os dados globais do usuário
  const { userData, setUserData } = useContext(UserContext);

  useEffect(() => {
    async function loadEventsType() {

      setShowSpinner(true);
      setEventos([]); //zera o array de eventos

      if (tipoEvento === "1") {
        //listar os eventos (Evento)
        try {
          const retornoEventos = await api.get(eventsResource);
          setEventos(retornoEventos.data);
          console.log(retornoEventos.data);

        } catch (error) {
          console.log("erro na api funcao loadeventstype da eventosa aluno page");
          console.log(error);
        }
      } else if (tipoEvento === "2") {
        //listar os meu eventos (presencaEventos)
        try {

          const retornoEventos = await api.get(`${myEventsResource}/${userData.userId}`);

          const arrEventos = []; //array vazio

          retornoEventos.data.forEach(e => {
            arrEventos.push(e.evento);
          });
          setEventos(arrEventos);
          console.log(arrEventos);

        } catch (error) {
          console.log("erro na api funcao loadeventstype da eventosa aluno page na condicao else");
          console.log(error);
        }
      } else{
        setEventos([]);
      } 

      
      setShowSpinner(false);
    }

    loadEventsType();
  }, [tipoEvento, userData.id]);

  const verificaPresenca = (arrEvents, eventsUser) => {

    for (let x = 0; x < arrEvents.length; x++) {

      for (let i = 0; i < eventsUser.length; i++) {
        
        if (arrEvents[x].idEvento === eventsUser[i].idEvento) {
          arrEvents[x].situacao = true;
          break; //para de procurar para o evento principal
        }
        
      }
      
      
    }
  }

  // toggle meus eventos ou todos os eventos
  function myEvents(tpEvent) {
    setTipoEvento(tpEvent);
  }

  async function loadMyComentary(idComentary) {
    return "????";
  }

  const showHideModal = () => {
    setShowModal(showModal ? false : true);
  };

  const commentaryRemove = () => {
    alert("Remover o comentário");
  };

  function handleConnect() {
    alert("Desenvolver a função conectar evento");
  }
  return (
    <>
      {/* <Header exibeNavbar={exibeNavbar} setExibeNavbar={setExibeNavbar} /> */}

      <MainContent>
        <Container>
          <Title titleText={"Eventos"} className="custom-title" />

          <Select
            id="id-tipo-evento"
            name="tipo-evento"
            required={true}
            options={quaisEventos} // aqui o array dos tipos
            manipulationFunction={(e) => myEvents(e.target.value)} // aqui só a variável state
            defaultValue={tipoEvento}
            additionalClass="select-tp-evento"
          />

          <Table
            dados={eventos}
            fnConnect={handleConnect}
            fnShowModal={() => {
              showHideModal();
            }}
          />
        </Container>
      </MainContent>

      {/* SPINNER -Feito com position */}
      {showSpinner ? <Spinner /> : null}

      {showModal ? (
        <Modal
          userId={userData.userId}
          showHideModal={showHideModal}
          fnDelete={commentaryRemove}
        />
      ) : null}
    </>
  );
};

export default EventosAlunoPage;
