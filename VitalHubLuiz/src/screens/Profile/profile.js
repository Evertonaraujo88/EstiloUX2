import { ScrollView } from "react-native"
import { Container } from "../../components/container/style"
import { ImageProfile } from "../../components/images/style"
import { InputDescriptionEdit, InputDescriptionProfile, InputDiagnosisEdit, InputDiagnosisProfile, InputPrescriptionEdit, InputPrescriptionProfile } from "../../components/input/styled"
import { ButtonTitle, InfoTextProfile, InputTitle, TitleProfile } from "../../components/title/style"
import { ContainerInfoProfile, ContainerInput, ContainerInputProfile, TextInput, TextInputEdit } from "./style"
import { ButtonBlue, ButtonCancel, ButtonGrayEdit, ButtonLoginVE } from "../../components/button/style"
import { LinkCancel } from "../../components/Links/style"
import { useState } from "react"


export const Profile = ({navigation}) => {

    const [ editInput, setEditInput ] = useState(false);

    return(
        <ScrollView>
            <Container>
                <ImageProfile
                    source={require('../../assets/profilePic.jpg')}
                />

                <TitleProfile>Richard Kosta</TitleProfile>

                <ContainerInfoProfile>
                    <InfoTextProfile>22 anos</InfoTextProfile>
                    <InfoTextProfile>richard.kosta@gmail.com</InfoTextProfile>
                </ContainerInfoProfile>
                
                <ContainerInputProfile>
                    <InputTitle>Descrição da consulta</InputTitle>

                    {
                        editInput == false ? (
                            <InputDescriptionProfile>
                                <TextInput>Descrição</TextInput>
                            </InputDescriptionProfile>
                        ) :
                        (
                            <InputDescriptionEdit>
                                <TextInputEdit multiline={true}>O paciente possuí uma infecção no 
                                ouvido. Necessário repouse de 2 dias 
                                e acompanhamento médico constante</TextInputEdit>
                            </InputDescriptionEdit>
                        )
                    }
                </ContainerInputProfile>

                <ContainerInputProfile>
                    <InputTitle>Diagnostico do paciente</InputTitle>

                    {
                        editInput == false ? (
                            <InputDiagnosisProfile>
                                <TextInput>Diagnostico</TextInput>
                            </InputDiagnosisProfile>
                        ):

                        (
                            <InputDiagnosisEdit>
                                <TextInputEdit>Infecção no ouvido</TextInputEdit>
                            </InputDiagnosisEdit>
                        )
                    }
                </ContainerInputProfile>

                <ContainerInputProfile>
                    <InputTitle>Prescrição médica</InputTitle>

                    {
                        editInput == false ? (
                            <InputPrescriptionProfile>
                                <TextInput>Prescrição medica</TextInput>
                            </InputPrescriptionProfile>
                        ):(
                            <InputPrescriptionEdit>
                                <TextInputEdit>Medicamento: Advil 
                                    Dosagem: 50 mg 
                                    Frequência: 3 vezes ao dia 
                                    Duração: 3 dias</TextInputEdit>
                            </InputPrescriptionEdit>
                        )
                    }


                </ContainerInputProfile>

                <ButtonLoginVE>
                    <ButtonTitle>SALVAR</ButtonTitle>
                </ButtonLoginVE>

                {
                    editInput == false ? (
                        <ButtonGrayEdit onPress={() => setEditInput(true)}>
                            <ButtonTitle>EDITAR</ButtonTitle>
                        </ButtonGrayEdit>
                    ):
                    (
                        <ButtonBlue onPress={() => setEditInput(false)}>
                            <ButtonTitle>EDITAR</ButtonTitle>
                        </ButtonBlue>
                    )
                }


                <ButtonCancel onPress={() => navigation.pop(1)}>
                    <LinkCancel>Cancelar</LinkCancel>
                </ButtonCancel>

            </Container>
        </ScrollView>

    )
}