
import { StatusBar } from 'react-native';

//import Fonte
import { useFonts, Roboto_500Medium, Roboto_700Bold } from '@expo-google-fonts/roboto';

//import componentes
import { ContainerApp } from './styles';
import { Header } from './src/components/Header';

//import Screens
import { Home } from './src/screens/Home';

export default function App() {

  //Hooks para useFonts (fontes)
  const [fontLoaded, fontError] = useFonts({
    Roboto_500Medium, Roboto_700Bold
  })

  //validacao de carregamentp de fontes
  if (!fontLoaded && !fontError) {
    return null;
  }

  return (
    <ContainerApp>

      <Header/>
      <Home/>
      <StatusBar/>
     

    </ContainerApp>
  );
}

