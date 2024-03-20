import styled from 'styled-components'

export const ContainerCard = styled.TouchableOpacity`
    width: 90%;
    height: 102px;
    flex-direction: row;
    align-items: center;
    padding: 10px 10px;
    margin: 6px auto;
    border-radius: 5px;
    background-color: #FFFFFF;
`

export const ContainerClinicCard = styled(ContainerCard)`
    height: 84px;
    width: 88%;
    justify-content: space-between;
    padding: 0px 18px;
    border: ${(props) => props.border == "yes" ?
    "2px solid #496BBA" : "0px solid "};
`

export const ContainerDoctorCard = styled(ContainerClinicCard)`
    height: 102px;
    padding: 0px 10px;
    justify-content: flex-start;
    gap: 10px;
`

export const ContainerProfile = styled.View`
    height: 80px;
    justify-content: space-between;
`

export const NameProfile = styled.Text`
    font-size: 16px;
    font-family: MontserratAlternates_600SemiBold;
    color: #33303E;
    margin-bottom: 5px;
`

export const AgeProfile = styled.Text`
    font-family: Quicksand_400Regular;
    font-size: 14px;
    color: #8C8A97;
`

export const TypeAppointment = styled.Text`
    font-family: Quicksand_500Medium;
    font-size: 14px;
    color: #4E4B59;
`
export const ContainerTime = styled.View`
    width: 100px;
    height: 26px;
    border-radius: 5px;
    background-color: ${(props) => props.situacao == "pendente" ?
    "#E8FCFD" : "#F1F0F5"};
    flex-direction: row;
    align-items: center;
    justify-content: center;
    gap: 6px;
`

export const DataProfileCard = styled.View`

`

export const ViewRow = styled.View`
    flex-direction: row;
    align-items: center;
    gap: 47px;
`

export const DateTime = styled.Text`
    font-family: Quicksand_600SemiBold;
    color: ${(props) => props.situacao == "pendente" ?
    "#49B3BA" : "#4E4B59"};
`

export const ButtonCard = styled.TouchableOpacity`

`

export const ButtonText = styled.Text`
    color: #C81D25;
    text-decoration: underline;
    font-family: MontserratAlternates_500Medium;
    font-size: 12px;
`

export const ButtonTextPront = styled(ButtonText)`
    color: #344F8F;
`