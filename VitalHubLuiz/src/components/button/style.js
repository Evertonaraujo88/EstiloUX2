import styled from "styled-components";

export const ButtonLogin = styled.TouchableOpacity`
    background-color: #496BBA;
    width: 90%;
    height: 44px;
    border-radius: 5px;
    margin-top: 15px;

    align-items: center;
    justify-content: center;
    border: #496BBA;
`

export const ButtonLoginVE = styled(ButtonLogin)`
    margin-top: 30px;
    margin-bottom: 27px;
`

export const ButtonGrayEdit = styled(ButtonLoginVE)`
    margin-top: 0px;
    background-color: #ACABB7;
    border: 0px;
`

export const ButtonBlue = styled(ButtonGrayEdit)`
    background-color: #496BBA;
`

export const ButtonEdit = styled(ButtonLogin)`
    margin-top: 30px;
    width: 100%;
`
export const ButtonSendProfile = styled(ButtonLogin)`
    width: 53.7%;
    background-color: #49B3BA;
    border: none;
    flex-direction: row;
    gap: 10px;
    margin: 0px;
`

export const ButtonLeave = styled(ButtonLogin)`
    margin-top: 30px;
    width: 59%;
    background-color: #ACABB7;
    border: none;
`

export const ButtonSchedule = styled(ButtonLoginVE)`
    width: 100%;
    margin-bottom: 30px;
`

export const ButtonModal = styled(ButtonLoginVE)`
    width: 285px;
`

export const ButtonCancel = styled.TouchableOpacity`
   width: 100%;
   align-items: center;
`

export const ButtonCancelProfile = styled.TouchableOpacity`
    width: 50%;
    height: 44px;
    align-items: center;
    justify-content: center;
`

export const ButtonBox = styled(ButtonCancel)`
    margin-bottom: 23px;
`

export const ButtonGoogle = styled(ButtonLogin)`
    background-color: white;
    border: 1px solid #496BBA;
    flex-direction: row;
    gap: 27px;
`