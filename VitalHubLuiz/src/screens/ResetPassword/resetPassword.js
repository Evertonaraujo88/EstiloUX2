import { CancelIcon } from "../../components/CancelIcon/cancelIcon"
import { ButtonLoginVE } from "../../components/button/style"
import { Container, ContainerBanner, ContainerInput, ContainerInputRP, ContainerLogo } from "../../components/container/style"
import { Logo } from "../../components/images/style"
import { Input } from "../../components/input/styled"
import { ButtonTitle, RegularTextRP, Title } from "../../components/title/style"
import { ButtonArrow } from "../RecoverPassword/style"

export const ResetPassword = ({navigation}) => {
    return (
        <Container>
            <ContainerBanner>

                <ButtonArrow onPress={ () => navigation.navigate('Login')}>
                    <CancelIcon />
                </ButtonArrow>

                <ContainerLogo>
                    <Logo
                        source={require('../../assets/logo.png')}
                    />
                </ContainerLogo>
            </ContainerBanner>

            <Title>Redefinir senha</Title>

            <RegularTextRP>Insira e confirme a sua nova senha</RegularTextRP>

            <ContainerInputRP>
                <Input
                    placeholder="Nova Senha"
                />
            </ContainerInputRP>
            
            <ContainerInputRP>
                <Input
                    placeholder="Confirmar nova senha"
                />
            </ContainerInputRP>

            <ButtonLoginVE
                title='Volta para login'
                onPress={() => navigation.navigate('Login')}
            >
                <ButtonTitle>CONFIRMAR NOVA SENHA</ButtonTitle>
            </ButtonLoginVE>
        </Container>
    )
}