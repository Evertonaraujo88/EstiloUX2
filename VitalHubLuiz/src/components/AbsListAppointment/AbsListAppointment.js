import { ButtonTabsStyle, ButtonTextStyle } from "./Style"

export const AbsListAppointment = ({textButton, clickButton=false, onPress}) => {
    return(
        // botao
        // texto do botao
        <ButtonTabsStyle clickButton={clickButton} onPress={onPress}>
            <ButtonTextStyle clickButton={clickButton}>{textButton}</ButtonTextStyle>
        </ButtonTabsStyle>
        
    )
}