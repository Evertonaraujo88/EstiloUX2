
import { BoxInput } from "../../components/BoxInput";
import { ContainerForm, ScrollForm } from "./style";

export function Home(){

    //Hooks - states
    //Hooks - effect
        //chamada da API

    return(

        //ScrollForm - View
        //COntainerForm
        //BoxInput
            //Label
            //Input

        <ScrollForm>
            <ContainerForm>
                <BoxInput
                    textLable= "informe o cep:"
                    placeholder= "Cep..."
                    KeyType= 'numeric'
                    maxLenght={9}
                />
            </ContainerForm>
        </ScrollForm>
     
    )
}