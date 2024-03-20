import styled, { css } from "styled-components"

export const Title = styled.Text`
 font-size: 20px;
 color: #33303e;
 font-family: MontserratAlternates_600SemiBold;
 margin-bottom: 5px;
`

export const TitleModal = styled(Title)`
    margin: 30px 0px;
`

export const TitleM = styled(TitleModal)`
    margin-top: 30px;
    margin-bottom: 0px;
`

export const TitleModalRecord = styled(TitleModal)`
    margin-top: 20px;
`

export const ButtonTitle = styled.Text`
    font-family: MontserratAlternates_700Bold;
    font-size: 14px;
    color: white;
    text-transform: uppercase;
`

export const ButtonTitleGoogle = styled(ButtonTitle)`
    color: #496BBA;
`
export const TextAccount = styled.Text`
    font-family: MontserratAlternates_600SemiBold;
    font-size: 14px;
    color: #4e5e59;
`

export const TitleProfile = styled(TextAccount)`
    font-size: 20px;
    ${props => props.darkTheme ? css`
        color: #FFFFFF;
        opacity: 0.8;
    ` : css`
        color: #33303E;
    `}
    
    margin-top: 20px;
`

export const ProfileName = styled(TitleProfile)`
    text-align: center;
`

export const RegularText = styled.Text`
    font-family: Quicksand_500Medium;
    font-size: 16px;
    text-align: center;
`

export const ConfirmationText = styled(RegularText)`
    margin-top: 16px;
`

export const RegularTextModal = styled(RegularText)`
    width: 278px;
    text-align: center;
    line-height: 22px;
    margin-top: 15px;
`

export const InfoTextProfile = styled(RegularText)`
    font-size: 14px;
    color: #5F5C6B;
`

export const InfoProfile = styled(InfoTextProfile)`
    margin-top: 10px;
`

export const RegularTextVE = styled(RegularText)`
    margin-top: 10px;
    margin-bottom: 20px;
    width: 90%;
`

export const RegularTextRP = styled(RegularText)`
    margin-top: 15px;
    margin-bottom: 5px;
    width: 90%;
`


export const RegularTextBlue = styled(RegularText)`
    color: #496BBA;
`

export const ContainerText = styled.View`
    margin-top: 15px;
    margin-bottom: 5px;
    width: 90%;
`

export const InputTitle = styled.Text`
    font-family: Quicksand_600SemiBold;
    font-size: 16px;
    margin-top: 24px;
    width: 90%;
`

export const TitleTextInfo = styled(InputTitle)`
    width: 100%;
    color: #33303E;
    margin-top: 0px;
`

export const LabelLocal = styled(TitleTextInfo)`
    ${props => props.darkTheme ? css`
        color: #FFFFFF;
        opacity: 0.6;
    ` : css`
        
    `}
    width: auto;
`

export const TextDefault = styled.Text`
    color: #4E4B59;
    font-family: Quicksand_500Medium;
    font-size: 14px;
`

export const NameUser = styled(InputTitle)`
    margin-top: 0px;
    width: auto;
    color: #FBFBFB;
`

export const AgeModalRecord = styled.Text`
    font-family: Quicksand_500Medium;
    font-size: 14px;
    color: #4E4B59;
`

export const SubtextModal = styled(AgeModalRecord)`
    color: #8C8A97;
`

export const EmailModalRecord = styled.Text`
    font-family: Quicksand_500Medium;
    font-size: 14px;
    color: #5F5C6B;
`

export const ScheduleModalText = styled.Text`
    font-family: Quicksand_600SemiBold;
    font-size: 14px;
    line-height: 17px;
    color: black;
    margin-top: 23px;
`

export const DateText = styled(ScheduleModalText)`
    margin-top: 53px;
    
`

export const SubtextCard = styled(ScheduleModalText)`
    color: #4E4B59;
    margin-top: 5px;
`

export const SubtextLocal = styled(SubtextCard)`
    ${props => props.darkTheme ? css`
        color: #FFFFFF;
        opacity: 0.6;
    ` : css`
        
    `}
    margin-top: 8px;
`

export const TextPhoto = styled.Text`
    font-family: MontserratAlternates_500Medium;
    font-size: 14px;
    line-height: 20px;
    color: #4E4B59;
`