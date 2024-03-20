import { CancelIcon } from "../../components/CancelIcon/cancelIcon"
import { LinkCancel } from "../../components/Links/style"
import { OtpInput } from "../../components/OtpInput/otpInput"
import { ButtonLogin, ButtonLoginVE } from "../../components/button/style"
import { Container, ContainerBanner, ContainerLogo, ContentRP } from "../../components/container/style"
import { Logo } from "../../components/images/style"
import { ButtonTitle, RegularText, RegularTextBlue, RegularTextVE, Title } from "../../components/title/style"
import { ButtonArrow } from "../RecoverPassword/style"

export const VerifyEmail = ({navigation}) => {
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


            <Title>Verifique seu email</Title>

            <RegularTextVE>Digite o código de 4 dígitos enviado para <RegularTextBlue>username@email.com</RegularTextBlue></RegularTextVE>

            <OtpInput />

            <ButtonLoginVE
                title='Vai para Redefinir senha'
                onPress={() => navigation.navigate('ResetPassword')}
            >
                <ButtonTitle>ENTRAR</ButtonTitle>
            </ButtonLoginVE>

            <LinkCancel>Reenviar Código</LinkCancel>




        </Container>
    )
}