import { Modal } from "react-native";
import styled from "styled-components";

export const ModalMedicalRecord = styled(Modal)`
    /* align-items: center;
    justify-content: center; */

    background-color: rgba(0,0,0,0.6);
`

export const ImageModalMedicalRecord = styled.Image`
    width: 285px;
    height: 181px;
    border-radius: 10px;
    margin-top: 30px;
`

export const ContainerData = styled.View`
    flex-direction: row;
    gap: 20px;
`