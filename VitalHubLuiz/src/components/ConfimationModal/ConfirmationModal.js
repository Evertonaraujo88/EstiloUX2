import { useNavigation } from "@react-navigation/native"
import { ContentModalConfirmationBox } from "../../screens/SelectClinic/Style"
import { BoxConfirmationModal, ContainerBoxModal, PacientModal } from "../CancelAppointmentModal/Style"
import { LinkCancel } from "../Links/style"
import { ButtonBox, ButtonCancel, ButtonModal, ButtonSchedule } from "../button/style"
import { ButtonTitle, ConfirmationText, RegularText, RegularTextModal, TextDefault, TitleM, TitleTextInfo } from "../title/style"
import { AlignBoxModal, DateBox, DoctorBox, ModalConfirmation } from "./Style"

export const ConfirmationModal = ({
    visible, setShowModalConfirmation, ...rest
}) => {
    const navigation = useNavigation();
    return(
        <ModalConfirmation {...rest} visible={visible} transparent={true} animationType="fade">

            <PacientModal>

                <BoxConfirmationModal>

                <ContentModalConfirmationBox>
                    <TitleM>Agendar consulta</TitleM>
                    <ConfirmationText>Consulte os dados selecionados para a sua consulta</ConfirmationText>

                    <DateBox>
                        <TitleTextInfo>Data da consulta</TitleTextInfo>
                        <TextDefault>1 de Novembro de 2023</TextDefault>
                    </DateBox>

                    <DoctorBox>
                        <TitleTextInfo>Médico(a) da consulta</TitleTextInfo>
                        <TextDefault>Dra Alessandra</TextDefault>
                        <TextDefault>Demartologa, Esteticista</TextDefault>
                    </DoctorBox>

                    <DoctorBox>
                        <TitleTextInfo>Local da consulta</TitleTextInfo>
                        <TextDefault>São Paulo, SP</TextDefault>
                    </DoctorBox>

                    <DoctorBox>
                        <TitleTextInfo>Tipo da consulta</TitleTextInfo>
                        <TextDefault>Rotina</TextDefault>
                    </DoctorBox>
                </ContentModalConfirmationBox>

                <AlignBoxModal>
                    <ButtonSchedule onPress={() => navigation.pop(3) & setShowModalConfirmation(false)}>
                        <ButtonTitle>Confirmar</ButtonTitle>
                    </ButtonSchedule>

                    <ButtonCancel onPress={() => navigation.pop(3) & setShowModalConfirmation(false)}>
                        <LinkCancel >Cancelar</LinkCancel>
                    </ButtonCancel>
                </AlignBoxModal>

                </BoxConfirmationModal>
            </PacientModal>

        </ModalConfirmation>
    )
}