import { Modal } from "react-native";
import styled from "styled-components";

export const PacientModal = styled.View`
    flex: 1;
    align-items: center;
    justify-content: center;
    background-color: rgba(0,0,0,0.6);
`

export const ScheduleModalView = styled(PacientModal)`
    flex-direction: row;
    align-items: flex-end;
`

export const ContainerBoxModal = styled.View`
    width: 92%;
    height: 310px;
    background-color: white;
    border-radius: 10px;
    align-items: center;
`

export const BoxConfirmationModal =styled(ContainerBoxModal)`
    height: 86%;
`

export const BoxModalSchedule = styled(ContainerBoxModal)`
    width: 100%;
    height: 56%;
    border-bottom-left-radius: 0px;
    border-bottom-right-radius: 0px;
`

export const ContainerBoxModalMedicalRecord = styled(ContainerBoxModal)`
    height: 436px;
`

export const BoxModalDoctor = styled(ContainerBoxModal)`
    height: 68%;
`

export const ModalCancel = styled(Modal)`
    align-items: center;
    justify-content: center;

    background-color: rgba(0,0,0,0.6);
`

