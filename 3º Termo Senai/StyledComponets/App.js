import { StatusBar } from "expo-status-bar";
import { useState, useEffect } from "react";
import { Container } from "./src/components/Container/Container";
import { Title, Title2 } from "./src/components/Title/Title";
import { Button, GreenBtn } from "./src/components/button/button";
import { Fundo } from "./src/components/Fundo/Fundo";

import {
  useFonts,
  Poppins_800ExtraBold_Italic,
} from "@expo-google-fonts/poppins";

const imagem = require("./src/assets/images/numeros.jpg");

export default function App() {
  //hook (useState)
  const [count, setcount] = useState(0);

  //funcao que incrementa
  const incremet = () => {
    setcount(count + 1);
  };

  const decremet = () => {
    setcount(count - 1);
  };

  //hook (useEffect)
  useEffect(() => {
    console.warn(`Contador atualizado: ${count}`);
  }, [count]);

  let [fontsLoaded, fontError] = useFonts({
    Poppins_800ExtraBold_Italic,
  });

  if (!fontsLoaded && !fontError) {
    return null;
  };

  return (
    <Container>
      <Fundo source={imagem}>
        <Title>Contador :</Title>
        <Title>{count}</Title>

        <Button onPress={incremet}>
          <Title2>Incrementar</Title2>
        </Button>

        <GreenBtn onPress={decremet}>
          <Title2>Decrementar</Title2>
        </GreenBtn>
      </Fundo>
      <StatusBar style="auto" />
    </Container>
  );
}
