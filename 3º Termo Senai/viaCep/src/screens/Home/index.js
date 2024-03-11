import { useEffect, useState } from "react";
import { BoxInput } from "../../components/BoxInput";
import {
  RowContainer,
  ContainerForm,
  ContainerScroll,
  ScrollForm,
} from "./style";

import axios from "axios";
import api from "../../service/API";

export function Home() {
  //Hooks - states e variaveis
  const [cep, setCep] = useState();
  const [endereco, setEndereco] = useState({});

  // ao carregar do componente
 /*  useEffect(() => {

  }, []);//array dependências */

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


  //chamada da API
  async function getCep() {

    try {

      if (cep != "") {

          const promise = await axios.get(`https:viacep.com.br/ws/${cep}/json`)
       /* const promise = await api.get(`/${cep}/json/`) */

      
       setEndereco(promise.data)

      }

    } catch (error) {
        console.log("Erro ao buscar o CEP.");
        /* console.log(error); */
        alert(error)
    }
  }

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
            onchangeText={tx => setCep(tx)}
            onBlur={getCep}
          />
          <BoxInput
            textLable="Logradouro:"
            placeholder="Logradouro..."
            KeyType="string"
            fieldValue={endereco.logradouro}
          />
          <BoxInput
            textLable="Bairro:"
            placeholder="Bairro..."
            KeyType="string"
            fieldValue={endereco.bairro}
          />
          <BoxInput
            textLable="Cidade:"
            placeholder="Cidade..."
            KeyType="string"
            fieldValue={endereco.cidade}
          />

          <RowContainer>
            <BoxInput
              fieldWidth="70"
              textLable="Estado:"
              placeholder="Estado..."
              KeyType="string"
              fieldValue={endereco.uf}
            />
            <BoxInput
              fieldWidth="20"
              textLable="UF:"
              placeholder="UF..."
              KeyType="string"
              fieldValue={endereco.uf}
            />
          </RowContainer>
        </ContainerForm>
      </ScrollForm>
    </ContainerScroll>
  );
}
