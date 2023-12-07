import React, { useEffect } from "react";
import trashDelete from "../../Assets/Images/trash-delete-red.png";

import { Button, Input } from "../FormComponents/FormComponents";
import "./Modal.css";

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

  useEffect(()=>{

    
  },[]);

  return (
    <div className="modal">
      <article className="modal__box">
        
        <h3 className="modal__title">
          {modalTitle}
          <span className="modal__close" onClick={()=> showHideModal(true)}>x</span>
        </h3>

        <div className="comentary">
          <h4 className="comentary__title">Comentário</h4>
          <img
            src={trashDelete}
            className="comentary__icon-delete"
            alt="Ícone de uma lixeira"
            onClick={() => {fnDelete()}}
          />

          <p className="comentary__text">{comentaryText}</p>

          <hr className="comentary__separator" />
        </div>

        <Input
          placeholder="Escreva seu comentário..."
          className="comentary__entry"
        />

        <Button
          buttonText="Comentar"
          AdditionalClass="comentary__button"
          manipulationFunction ={() => {fnPost()}}
        />
      </article>
    </div>
  );
};

export default Modal;