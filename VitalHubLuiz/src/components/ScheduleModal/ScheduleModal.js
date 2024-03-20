import { useNavigation } from "@react-navigation/native"
import { BoxModalSchedule, PacientModal, ScheduleModalView } from "../CancelAppointmentModal/Style"
import { LinkCancel } from "../Links/style"
import { ModalMedicalRecord } from "../MedicalRecordModal/Style"
import { ButtonCancel, ButtonLogin, ButtonLoginVE, ButtonSchedule } from "../button/style"
import { Input, InputScheduleModal_1, InputScheduleModal_2, InputScheduleModal_3 } from "../input/styled"
import { ButtonTitle, ScheduleModalText, TitleModal } from "../title/style"
import { BoxContent, BoxInput, ContainerBoxAlign } from "./Style"

export const ScheduleModal = ({
    visible, setShowModalSchedule, ...rest
}) => {
    const navigation = useNavigation();
    return(
        <ModalMedicalRecord {...rest} visible={visible} transparent={true} animationType="fade">
            <ScheduleModalView>
                <BoxModalSchedule>

                    <ContainerBoxAlign>
                        <TitleModal>Agendar consulta</TitleModal>
                        <BoxContent>
                            <ScheduleModalText>Qual o nível da consulta</ScheduleModalText>

                            <BoxInput>
                                <InputScheduleModal_1
                                    placeholder="Rotina"
                                />
                                <InputScheduleModal_1
                                    placeholder="Exame"
                                />
                                <InputScheduleModal_2
                                    placeholder="Urgência"
                                />
                            </BoxInput>

                            <ScheduleModalText>Informe a localização desejada</ScheduleModalText>

                            <InputScheduleModal_3
                                placeholder="Informe a localização"
                            />

                            <ButtonSchedule onPress={() => navigation.navigate("SelectClinic") & setShowModalSchedule(false)}>
                                <ButtonTitle>continuar</ButtonTitle>
                            </ButtonSchedule>

                            <ButtonCancel onPress={() => setShowModalSchedule(false)}>
                                <LinkCancel>Cancelar</LinkCancel>
                            </ButtonCancel>
                            
                        </BoxContent>
                    </ContainerBoxAlign>

                </BoxModalSchedule>
            </ScheduleModalView>
        </ModalMedicalRecord>
    )
}