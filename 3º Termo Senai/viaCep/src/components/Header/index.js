import { HeaderContainer, HeaderContent, TextHeader } from "./style";


export function Header() {
  return (
    //HeaderContainer (view que segura todos componentes)
    //HeaderContent (SafeAreaView)
    //TextHeader (Text)

    <HeaderContainer>
      <HeaderContent>
        <TextHeader>Consumo da API ViaCep</TextHeader>
      </HeaderContent>
    </HeaderContainer>
  )
}
