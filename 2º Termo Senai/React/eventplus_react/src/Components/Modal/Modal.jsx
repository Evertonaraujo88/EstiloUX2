import React, { useEffect, useState, useContext } from "react";
import trashDelete from "../../Assets/Images/trash-delete-red.png";

import { Button, Input } from "../FormComponents/FormComponents";
import "./Modal.css";
import { UserContext } from "../../Context/AuthContext";

const Modal = ({
  modalTitle = "Feedback",
  comentaryText = "Não informado.",
  userId = null,
  showHideModal = false,
  fnDelete = null,
  fnGet = null,
  fnPost = null,
  fnNewCommentary = null

}) => {

  const { userData } = useContext(UserContext)
  console.clear();
  console.log(userData);


  const [descricao, setDescricao] = useState("");
  const [idComentarioEvento, setIdComentarioEvento] = useState("");


  useEffect(() => {

    async function carregarDados() {
      fnGet(userData.userId, userData.idEvento);
    }

    carregarDados();

  }, []);

  return (
    <div className="modal">
      <article className="modal__box">

        <h3 className="modal__title">
          {modalTitle}
          <span className="modal__close" onClick={() => showHideModal(true)}>x</span>
        </h3>

        <div className="comentary">
          <h4 className="comentary__title">Comentário</h4>
          <img
            src={trashDelete}
            className="comentary__icon-delete"
            alt="Ícone de uma lixeira"
            onClick={() => { fnDelete(idComentarioEvento, userData.userId, userData.idEvento) }}
          />

          <p className="comentary__text">{comentaryText}</p>

          <hr className="comentary__separator" />
        </div>

    
        <Input
          placeholdder={"Escreva seu comentario ... "}
          value={descricao}
          manipulationFunction={(e) => {
            setDescricao(e.target.value);
          }}
          className="comentary__entry"
        />

        <Button
          textButton="Comentar"
          AdditionalClass="comentary__button"
          manipulationFunction={() => { fnPost(descricao.trim(), userData.userId, userData.idEvento) }}
        />
      </article>
    </div>
  );
};

export default Modal;