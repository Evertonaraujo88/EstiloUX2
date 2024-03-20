import { Image, ScrollView, StyleSheet, View } from "react-native"
import { AlignContainer, Container } from "../../components/container/style"
import { ImageProfile } from "../../components/images/style"
import { ButtonTitle, InfoTextProfile, LabelLocal, ProfileName, TextPhoto } from "../../components/title/style"
import { ContainerInfoProfile } from "../Profile/style"
import { DateBox, DoubleContentBoxEP, Line } from "../EditProfile/Style"
import { InputBigProfile, InputGrey, InputResultProfile } from "../../components/input/styled"
import { ButtonPhoto, ContainerPhoto, ContentView, InputProfileBox, ScrollContainer, ViewPhoto } from "./Style"
import { AntDesign } from '@expo/vector-icons';
import { MaterialCommunityIcons } from '@expo/vector-icons';
import { ButtonBox, ButtonCancel, ButtonCancelProfile, ButtonEdit, ButtonSendProfile } from "../../components/button/style"
import { LinkCancel, LinkCancelProfile } from "../../components/Links/style"
import { AlignButton, AlingnButtonProfile } from "../AppointmentLocation/Style"
import { CameraComp } from "../../components/CameraComp/CameraComp"
import { useEffect, useState } from "react"

export const EditMedicalRecord = ({navigation}) => {

    const [ showCamera, setShowCamera ] = useState(false);
    const [uriCameraCapture, setUriCameraCapture] = useState(null)

    useEffect(() => {

    }, [showCamera])

    return(
        
        <ContentView>
            {
                showCamera == true ? (
                    <CameraComp
                        visible={showCamera}
                        setShowCamera={setShowCamera}
                        setUriCameraCapture={setUriCameraCapture}
                    />
                ) : (
                    <ScrollContainer>
                    <Container>
                        <ImageProfile
                                source={require('../../assets/doctorProfileImage.png')}
                        />

                        <AlignContainer>

                            <ProfileName>Dr. Claudio</ProfileName>

                            <ContainerInfoProfile>
                                <InfoTextProfile>Cliníco geral</InfoTextProfile>
                                <InfoTextProfile>CRM-15286</InfoTextProfile>
                            </ContainerInfoProfile>

                            <DateBox>
                                <LabelLocal>Descrição da consulta</LabelLocal>
                                <InputBigProfile
                                    multiline={true}
                                    placeholder="O paciente possuí uma infecção no
                                    ouvido. Necessário repouse de 2 dias
                                    e acompanhamento médico constante"
                                />
                            </DateBox>

                            <InputProfileBox>
                                <LabelLocal>Diagnóstico do paciente</LabelLocal>
                                <InputGrey
                                    multiline={true}
                                    placeholder="Infecção no ouvido"
                                />
                            </InputProfileBox>

                            <InputProfileBox>
                                <LabelLocal>Prescrição médica</LabelLocal>

                                {/* Pesquisar como wrap line in the placeholder */}
                                <InputBigProfile
                                    multiline={true}
                                    placeholder="Medicamento: Advil
                                    Dosagem: 50 mg
                                    Frequência: 3 vezes ao dia
                                    Duração: 3 dias"
                                />
                            </InputProfileBox>

                            <InputProfileBox>
                                <LabelLocal>Exames médicos</LabelLocal>
                                
                                

                                    { uriCameraCapture === null ? (
                                        <ViewPhoto >
                                            <AntDesign name="exclamationcircle" size={20} color="#4E4B59" />
                                            <TextPhoto>Nenhuma foto informada</TextPhoto>
                                        </ViewPhoto>

                                    ): (

                                        <ViewPhoto>

                                            <Image 
                                            source = {{uri: uriCameraCapture}}
                                        />
                                        </ViewPhoto>
                                        
                                        
                                        
                                    )}
                                    
                                
                                    
                            </InputProfileBox>

                            <DoubleContentBoxEP>
                                <ButtonSendProfile onPress={() => setShowCamera(true)}>
                                    <MaterialCommunityIcons name="camera-plus-outline" size={24} color="white" />
                                    <ButtonTitle>Enviar</ButtonTitle>
                                </ButtonSendProfile>

                                <ButtonCancelProfile>
                                    <LinkCancelProfile>Cancelar</LinkCancelProfile>
                                </ButtonCancelProfile>
                            </DoubleContentBoxEP>

                            <Line/>

                            <InputProfileBox>
                                {/* Pesquisar como wrap line in the placeholder */}
                                <InputResultProfile
                                    multiline={true}
                                    placeholder="Resultado do exame de sangue : tudo normal"
                                />
                            </InputProfileBox>

                            <AlingnButtonProfile>
                                <ButtonBox onPress={() => navigation.goBack()}>
                                    <LinkCancel >Voltar</LinkCancel>
                                </ButtonBox>
                            </AlingnButtonProfile>

                        </AlignContainer>


                    </Container>
                    </ScrollContainer>
                )
            }
        </ContentView>



        
    )
}