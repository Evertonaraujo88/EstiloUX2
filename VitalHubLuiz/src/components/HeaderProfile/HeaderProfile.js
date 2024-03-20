import { Octicons } from '@expo/vector-icons';
import { ContainerHeader } from '../container/style';
import { BoxBell, BoxUser, DataUser, ImageUser } from '../../screens/AppointmentDoctor/style';
import { NameUser, TextDefault } from '../title/style';
import { useNavigation } from '@react-navigation/native';

//Queria passar props com o nome e a URL da imagem, mas nao consegui
//Update: O react native nao consegue renderizar imagens dinamicamente, quero ver como o professor vai fazer isso

export const HeaderProfile = () => {
    const navigation = useNavigation();
    return(
        <ContainerHeader>
            <BoxUser onPress={() => navigation.navigate("Profile")}>
                <ImageUser
                    source={require('../../assets/drauzioImage.webp')}
                />

                <DataUser>
                    <TextDefault>Bem vindo</TextDefault>
                    <NameUser>Dr Drauzio</NameUser>
                </DataUser>

                
            </BoxUser>
            <BoxBell>
                <Octicons name="bell-fill" size={22} color="#FFFFFF" />
            </BoxBell>
        </ContainerHeader>
    )
}