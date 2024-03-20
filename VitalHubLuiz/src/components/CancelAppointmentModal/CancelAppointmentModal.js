import { Modal } from "react-native"
import { LinkCancel } from "../Links/style"
import { ButtonBox, ButtonCancel, ButtonLoginVE, ButtonModal } from "../button/style"
import { ContainerModal } from "../container/style"
import { ButtonTitle, RegularText, RegularTextModal, Title, TitleM, TitleModal } from "../title/style"
import { ContainerBoxModal, ModalCancel, PacientModal } from "./Style"

export const CancelAppointmentModal = ({
    visible, setShowModalCancel, onPressConfirmation, ...rest
}) => {
    return(
        
        
        <ModalCancel {...rest} visible={visible} transparent={true} animationType="fade">
            <PacientModal>
                <ContainerBoxModal>
                    <TitleM>Cancelar consulta</TitleM>
                    <RegularTextModal>Ao cancelar essa consulta, abrirá uma possível disponibilidade no seu horário, deseja mesmo cancelar essa consulta?</RegularTextModal>
                    <ButtonModal onPress={onPressConfirmation}>
                        <ButtonTitle>Confirmar</ButtonTitle>
                    </ButtonModal>

                    <ButtonBox onPress={() => setShowModalCancel(false)}>

                        <LinkCancel>Cancelar</LinkCancel>
                        
                    </ButtonBox>
                    
                </ContainerBoxModal>
            </PacientModal>

        </ModalCancel>

        // <ContainerModal>
        //     <ContainerBoxModal>
        //         <TitleModal>Cancelar consulta</TitleModal>
        //         <RegularTextModal>Ao cancelar essa consulta, abrirá uma possível disponibilidade no seu horário, deseja mesmo cancelar essa consulta?</RegularTextModal>
        //         <ButtonLoginVE>
        //             <ButtonTitle>Confirmar</ButtonTitle>
        //         </ButtonLoginVE>

        //         <LinkCancel>Cancelar</LinkCancel>
        //     </ContainerBoxModal>
            
        // </ContainerModal>
    )
}

