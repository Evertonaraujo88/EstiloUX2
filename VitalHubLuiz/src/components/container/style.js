import styled from 'styled-components'
import { LinearGradient } from 'expo-linear-gradient'

export const Container = styled.SafeAreaView`
    flex: 1;
    align-items: center;
    background-color: #FAFAFA;
`

export const ContainerBanner = styled.View`
    flex-direction: row;
    margin-top: 20px;
    margin-bottom: 25px;
    width: 100%;
    padding-left: 20px;
`

export const ContainerLogo = styled.View`
    width: 100%;
    margin-left: 5.5%;
`

export const LogoContainer = styled.View`
    width: 100%;
`

export const ContainerLogoTipo = styled.View`
    margin-top: 20px;
    margin-bottom: 20px;
`

export const ContentRP = styled.View`
    align-items: center;
    width: 90%;
`

export const ContainerInput = styled.View`
    flex-direction: row;
    margin-bottom: 15px;
`

export const ContainerInputRP = styled(ContainerInput)`
    margin-bottom: 0px;
` 

export const ContainerHeader = styled(LinearGradient).attrs({
    colors: ['#60BFC5', '#496BBA'],
    start: {x: -0.05, y: 1.08},
    end: {x: 1, y: 0}
})`
    width:100%;
    height: 102px;
    border-radius: 0px 0px 15px 15px;
    flex-direction: row;
    align-items: center;
    justify-content: space-between;
`

export const ContainerModal = styled(Container)`
    height: 100%;
    width: 100%;
    position: absolute;
    z-index: 10;
    background-color: rgba(0,0,0,0.6);
    justify-content: center;
    
`

export const DoubleContentBox = styled.View`
    flex-direction: row;
    width: 100%;
    gap: 32px;
    justify-content: center;
    margin-top: 24px;   
`

export const SmallBox = styled.View`
    width: 40%;
    gap: 6px;
`


export const AlignContainer = styled.View`
    width: 88%;
    justify-content: center;
    align-items: center;
`

