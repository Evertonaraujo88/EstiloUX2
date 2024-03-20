import { ContentModalConfirmationBox, ContentModalDoctor } from "../../screens/SelectClinic/Style"
import { BoxConfirmationModal, BoxModalDoctor, PacientModal } from "../CancelAppointmentModal/Style"
import { AlignBoxModal, AlignButton, ModalConfirmation } from "../ConfimationModal/Style"
import { LinkCancel } from "../Links/style"
import { ButtonBox, ButtonCancel, ButtonSchedule } from "../button/style"
import { ButtonTitle, InfoTextProfile, TitleProfile } from "../title/style"
import { BoxInfoDoctor, DoctorImage } from "./Style"

export const DoctorModal = ({
    visible, setShowModalDoctor, onPressLocal, ...rest
}) => {
    return(
        <ModalConfirmation {...rest} visible={visible} transparent={true} animationType="fade">
            <PacientModal>
                <BoxModalDoctor>

                    <ContentModalDoctor>
                    <DoctorImage
                        source={require('../../assets/noPhoto.jpg')}
                    />

                    <TitleProfile>Dr. Claudio</TitleProfile>

                    <BoxInfoDoctor>
                        <InfoTextProfile>Cliníco geral</InfoTextProfile>
                        <InfoTextProfile>CRM-15286</InfoTextProfile>
                    </BoxInfoDoctor>

                    </ContentModalDoctor>


                    <AlignButton>
                        <ButtonSchedule onPress={onPressLocal}>
                            <ButtonTitle>Ver local da consulta</ButtonTitle>
                        </ButtonSchedule>

                        <ButtonBox onPress={() => setShowModalDoctor(false)}>
                            <LinkCancel >Cancelar</LinkCancel>
                        </ButtonBox>
                    </AlignButton>
                </BoxModalDoctor>
            </PacientModal>
        </ModalConfirmation>
    )
}