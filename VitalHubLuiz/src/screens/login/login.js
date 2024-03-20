import { Button, Image, View } from "react-native"
import { Container } from "../../components/container/style"
import { ImageGoogle, Logo } from "../../components/images/style"
import { ButtonTitle, ButtonTitleGoogle, TextAccount, Title } from "../../components/title/style"
import { Input } from "../../components/input/styled"
import { LinkBold, LinkMedium } from "../../components/Links/style"
import { ButtonGoogle, ButtonLogin } from "../../components/button/style"
import { AntDesign } from '@expo/vector-icons';
import { ContainerLogo, ContentAccount } from "./style"

export const Login = ({navigation}) => {

    async function Login() {
        navigation.replace("Main")
    }
    async function LoginDoctor() {
        navigation.replace("MainDoctor")
    }
    return(
        <Container>
            <ContainerLogo>
                <Logo
                    source={require('../../assets/logo.png')}
                />
            </ContainerLogo>


            <Title>Entrar ou criar conta</Title>

            <Input
            placeholder="Usuario ou Email"
            />
            <Input
            placeholder="Senha"
            secureTextEntry={true}
            />

            <LinkMedium onPress={() => navigation.navigate("RecuperarSenha")}>Esqueceu sua senha?</LinkMedium>

            <ButtonLogin onPress={() => Login()}>
                <ButtonTitle>Entrar</ButtonTitle>
            </ButtonLogin>

            <ButtonGoogle onPress={() => LoginDoctor()}>
            <AntDesign name="google" size={18} color="#496BBA" />
                <ButtonTitleGoogle>Entrar com google</ButtonTitleGoogle>
            </ButtonGoogle>

            <ContentAccount>
                <TextAccount>Nao tem conta?</TextAccount>
                <LinkBold onPress={() => navigation.navigate('CriarConta')}>Crie uma conta agora!</LinkBold>
            </ContentAccount>
        </Container>
    )
}