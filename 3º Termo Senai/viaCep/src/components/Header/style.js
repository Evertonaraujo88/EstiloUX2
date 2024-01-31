import styled from "styled-components";


//HeaderContainer (view que segura todos componentes)
//HeaderContent (SafeAreaView)
 //TextHeader (Text)

 export const HeaderContainer = styled.View`
    background-color: #FECC2B;
    height: 20%;

    flex-direction: row;
    align-items: center;
    justify-content: center;
    border-radius:0px 0px 15px 15px;
    shadow-color: red;
    shadow-offset:0px 4px;
    shadow-opacity: 0.15;
    shadow-radius: 15px;
    elevation: 5;
       
    box-shadow: 0px 0px 10px red;
 `
 export const HeaderContent = styled.SafeAreaView`
    /* margin-top: 45px; */
 
 `
 export const TextHeader = styled.Text`
    font-size: 24px;
    font-family: 'Roboto_500Medium';
    color: #333E33;
    text-align: center;
 
 `