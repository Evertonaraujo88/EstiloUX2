import styled, { css } from "styled-components";

export const MapImage = styled.Image`
    width: 100%;
    height: 45%;
`

export const ContainerBackground = styled.View`
    ${props => props.darkTheme ? css`
        background-color: #121212;
    ` : css`
        background-color: #F5F3F3;
    `}
    
    width: 100%;
    height: 100%;
`

export const ContentAL = styled.View`
    ${props => props.darkTheme ? css`
        background-color: #121212;
    ` : css`
        background-color: white;
    `}
    
    width: 100%;
    height: 100%;
    border-top-right-radius: 10px;
    border-top-left-radius: 10px;
    padding-top: 10px;
    align-items: center;
`

export const AddressBox = styled.View`
    margin-top: 20px;
    width: 88%;
    align-items: start;
`

export const AlignButton = styled.View`
    margin-top: 24px;
`

export const AlingnButtonProfile = styled.View`
    margin: 30px 0px;
`