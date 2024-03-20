import { StyleSheet } from "react-native";
import { ContainerClinicCard, ContainerDoctorCard, NameProfile } from "../AppointmentCard/Style"
import { BoxText } from "../ClinicCard/Style";
import { SubtextModal } from "../title/style";
import { ImageDoctorProfile } from "./Style";

export const DoctorCard = ({
    border="",
    nome="",
    especialidade="",
}) => {
    return(
        <ContainerDoctorCard border={border}  style={styles.shadow}>

            {/* Nao sei como muda a imagem dinamicamente */}

            <ImageDoctorProfile
                source={require('../../assets/noPhoto.jpg')}
            />  

            <BoxText>
                <NameProfile>{nome}</NameProfile>
                <SubtextModal>{especialidade}</SubtextModal>
            </BoxText>

        </ContainerDoctorCard>
    )
}

const styles =  StyleSheet.create({
    shadow: {
        elevation: 5,
        shadowColor: '#000000',
    },
});