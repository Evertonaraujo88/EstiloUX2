import { CircleWithin, ContainerIcon, Icon } from "./style"
import { AntDesign } from '@expo/vector-icons';

export const ArrowIcon = () => {
    return(
        <ContainerIcon>
            <Icon>
                <AntDesign name="arrowleft" size={14} color="#34898F"/>
            </Icon>
            <CircleWithin/>
        </ContainerIcon>
    )
}