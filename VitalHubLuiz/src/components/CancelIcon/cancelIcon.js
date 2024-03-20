import { FontAwesome6 } from '@expo/vector-icons';
import { CircleWithin, ContainerIcon, Icon } from './style';

export const CancelIcon = () => {
    return(
        <ContainerIcon>
            <Icon>
                <FontAwesome6 name="xmark" size={19} color="#34898F" />
            </Icon>
            <CircleWithin/>
        </ContainerIcon>
    )
}