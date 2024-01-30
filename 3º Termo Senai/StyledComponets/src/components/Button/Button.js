import styled from "styled-components";

export const Button = styled.TouchableOpacity`

    width: 80%;
    height: 40px;
    background-color: blue;
    margin-top: 20px;
    align-items: center;
    justify-content : center;
    border-radius: 8px;

`;

export const GreenBtn = styled(Button)`
    background-color: green;
    border-color: green

`