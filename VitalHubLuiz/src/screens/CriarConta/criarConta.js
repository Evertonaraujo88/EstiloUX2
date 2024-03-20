import { LinkCancel } from "../../components/Links/style"
import { ButtonLoginVE } from "../../components/button/style"
import { Container, ContainerLogoTipo } from "../../components/container/style"
import { Logo } from "../../components/images/style"
import { Input } from "../../components/input/styled"
import { ButtonTitle, RegularTextRP, Title } from "../../components/title/style"

export const CriarConta = ({navigation}) => {
    return(
        <Container>
            <ContainerLogoTipo>
                <Logo
                    source={require('../../assets/logo.png')}
                />
            </ContainerLogoTipo>

            <Title>Entrar ou criar conta</Title>

            <RegularTextRP>Insira seu endereço de e-mail e senha para realizar seu cadastro.</RegularTextRP>

            <Input
            placeholder="Usuario ou Email"
            />

            <Input
            placeholder="Senha"
            secureTextEntry={true}
            />

            <Input
            placeholder="Confirmar senha"
            secureTextEntry={true}
            />
            <ButtonLoginVE
                title='Volta para login'
                onPress={() => navigation.navigate('Login')}
            >
                <ButtonTitle>CADASTRAR</ButtonTitle>
            </ButtonLoginVE>

            <LinkCancel
                title='Volta para login'
                onPress={() => navigation.navigate('Login')}
            >Cancelar</LinkCancel>
            
        </Container>
    )
}