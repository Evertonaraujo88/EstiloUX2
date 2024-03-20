import styled, { css } from 'styled-components'

export const ButtonTabsStyle = styled.TouchableHighlight`
    padding: 12px 14px;
    border-radius: 5px;

    /* Se o botao estiver clicado, aplica o fundo azul. Caso contrario, o fundo trasparente */
    ${props => props.clickButton ? css`
        background-color: #496BBA;
    ` : css`
        background-color: transparent;
        border: 2px solid #607EC5;
    `}
`

export const ButtonTextStyle = styled.Text`
    font-size: 12px;
    font-family: MontserratAlternates_600SemiBold;
    
    /* Se click button for true, a cor sera branca. Se nao, sera azul */
    ${props => props.clickButton ? css`
        color: #FBFBFB;
    ` : css`
        color: #607EC5;
    `}
`