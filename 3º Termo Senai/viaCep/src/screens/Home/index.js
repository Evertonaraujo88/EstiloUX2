import { useEffect, useState } from "react";
import { BoxInput } from "../../components/BoxInput";
import {
  RowContainer,
  ContainerForm,
  ContainerScroll,
  ScrollForm,
} from "./style";
import axios from "axios";

export function Home() {
  //Hooks - states e variaveis
  const [cep, setCep] = useState();
  const [logradouro, setLogradouro] = useState("");
  const [bairro, setBairro] = useState("");
  const [cidade, setCidade] = useState("");
  const [estado, setEstado] = useState("");
  const [uf, setUf] = useState("");

  // ao carregar do componente
  useEffect(() => {

  }, []);//array dependências

/* // ao carregar do componente
// ao alterar do xpto
  useEffect(() => {

  }, [xpto]);//array dependências

  // ao carregar do componente
// ao alterar do xpto
// ao desmontar do componente
  useEffect(() => {
    return alert("fui desmontado,morri!!");
  }, [xpto]);//array dependências



  // ao carregar do componente
// loop infinito
  useEffect(() => {
    return alert("fui desmontado,morri!!");
  });//sem array dependências - programador esqueceu! */

  //Hooks - effect e functions
  useEffect(async () => {
    //chamada da API
    try {

      if (cep != "" && cep.lenght === 8) {
       const endereco = await axios.get(`https://viacep.com.br/ws/${cep}/json/`);

       if (endereco.error) {
            alert("Verifique o CPE");
            return;
       }

       setLogradouro(endereco.data.logradouro);
       setBairro(endereco.data.bairro);
       setCidade(endereco.data.localidade);
       setEstado(endereco.data.uf);
       setUf(endereco.data.uf);

      }
    } catch (error) {
        console.log("Erro ao buscar o CEP.");
        console.log(error);
    }
  }, [cep]);

  return (
    //ScrollForm - View
    //COntainerForm
    //BoxInput
    //Label
    //Input
    <ContainerScroll>
      <ScrollForm>
        <ContainerForm>
          <BoxInput
            textLable="Informe o cep:"
            placeholder="Cep..."
            KeyType="numeric"
            maxLenght={9}
            fieldValue={cep}
            editable={true}
            onchangeText={(tx) => {
              return setCep(tx);
            }}
          />
          <BoxInput
            textLable="Logradouro:"
            placeholder="Logradouro..."
            KeyType="string"
            fieldValue={logradouro}
          />
          <BoxInput
            textLable="Bairro:"
            placeholder="Bairro..."
            KeyType="string"
            fieldValue={bairro}
          />
          <BoxInput
            textLable="Cidade:"
            placeholder="Cidade..."
            KeyType="string"
            fieldValue={cidade}
          />

          <RowContainer>
            <BoxInput
              fieldWidth="70"
              textLable="Estado:"
              placeholder="Estado..."
              KeyType="string"
              fieldValue={estado}
            />
            <BoxInput
              fieldWidth="20"
              textLable="UF:"
              placeholder="UF..."
              KeyType="string"
              fieldValue={uf}
            />
          </RowContainer>
        </ContainerForm>
      </ScrollForm>
    </ContainerScroll>
  );
}
