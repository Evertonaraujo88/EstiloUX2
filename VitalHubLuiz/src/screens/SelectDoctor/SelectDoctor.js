import { DoctorCard } from "../../components/DoctorCard/DoctorCard"
import { LinkCancel } from "../../components/Links/style"
import { ComponentList } from "../../components/List/Style"
import { ButtonCancel, ButtonSchedule } from "../../components/button/style"
import { Container } from "../../components/container/style"
import { ButtonTitle, TitleModal } from "../../components/title/style"
import { AlignBox, ContentBox } from "../SelectClinic/Style"

const Doctors = [
    {id: 1, nome:"Dra Alessandra", especialidade:"Demartologa, Esteticista"},
    {id: 2, nome:"Dr Kumushiro", especialidade:"Cirurgião, Cardiologista"},
    {id: 3, nome:"Dr Rodrigo Santos", especialidade:"Clínico, Pediatra"},
];

export const SelectDoctor = ({navigation}) => {
    return(
        <Container>
            <ContentBox>
                <TitleModal>Selecionar médico</TitleModal>

                <ComponentList
                data={Doctors}
                keyExtractor={(item) => item.id}

                renderItem={({ item }) =>
                (
                    <DoctorCard
                        nome={item.nome}
                        especialidade={item.especialidade}
                    />
                )
                }
            />

                
            </ContentBox>
                

            <AlignBox>
                <ButtonSchedule onPress={() => navigation.navigate("SelectDate")}>
                    <ButtonTitle>continuar</ButtonTitle>
                </ButtonSchedule>

                <ButtonCancel onPress={() => navigation.pop(2)}>
                    <LinkCancel>Cancelar</LinkCancel>
                </ButtonCancel>
            </AlignBox>
        </Container>
    )
}