import { StyleSheet } from "react-native";
import { ContainerCard, ContainerClinicCard, NameProfile } from "../AppointmentCard/Style"
import { SubtextCard } from "../title/style";
import { BoxInfo, BoxRating, BoxSchedule, BoxText, TextRating, TextSchedule } from "./Style";
import { AntDesign } from '@expo/vector-icons';
import { MaterialCommunityIcons } from '@expo/vector-icons';

export const ClinicCard = ({
    border="",
    nome="",
    local="",
    rating="",
    agenda="",
}) => {
    return(
        <ContainerClinicCard border={border}  style={styles.shadow}>
            <BoxText>
                <NameProfile>{nome}</NameProfile>

                <SubtextCard>{local}</SubtextCard>
            </BoxText>

            <BoxInfo>
                <BoxRating>
                    <AntDesign name="star" size={19} color="#F9A620" />
                    <TextRating>{rating}</TextRating>
                </BoxRating>

                <BoxSchedule>

                    <MaterialCommunityIcons name="calendar" size={15} color="#49B3BA" />

                    <TextSchedule>{agenda}</TextSchedule>
                    
                </BoxSchedule>       

            </BoxInfo>
        </ContainerClinicCard>
    )
}

const styles =  StyleSheet.create({
    shadow: {
        elevation: 5,
        shadowColor: '#000000',
    },
});