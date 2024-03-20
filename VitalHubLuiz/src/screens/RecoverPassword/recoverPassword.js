import { AntDesign } from '@expo/vector-icons';

import { ArrowIcon } from '../../components/ArrowIcon/arrowIcon';
import { Logo } from '../../components/images/style';
import { Container, ContainerBanner, ContainerInput, ContainerLogo, ContentRP, LogoContainer } from '../../components/container/style';
import { ButtonTitle, RegularTextRP, Title } from '../../components/title/style';
import { Input } from '../../components/input/styled';
import { ButtonLogin } from '../../components/button/style';
import { ButtonArrow } from './style';

export const RecoverPassword = ({navigation}) => {
    return (
        <Container>
            <ContainerBanner>
                <ButtonArrow onPress={ () => navigation.navigate('Login')}>
                    <ArrowIcon 
                        rota='Login'
                    />
                </ButtonArrow>
                <LogoContainer>
                    <Logo
                        source={require('../../assets/logo.png')}
                    />
                </LogoContainer>
            </ContainerBanner>

            <Title>Recuperar senha</Title>

            <RegularTextRP>Digite abaixo seu email cadastrado que enviaremos um link para recuperação de senha</RegularTextRP>


            <ContainerInput>
                <Input
                    placeholder="Usuario ou Email"
                />
            </ContainerInput>


            <ButtonLogin
                title='Vai para verificar email'
                onPress={() => navigation.navigate('VerifyEmail')}
            >
                <ButtonTitle>CONTINUAR</ButtonTitle>
            </ButtonLogin>



        </Container>

    )
}