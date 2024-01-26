import { StatusBar } from 'expo-status-bar';
import { Image, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';

const imgSenai = require('./src/assets/images/imagem_senai.png')

export default function App() {
  return (
    <View style={styles.container}>
      <Text style={styles.text1}>Hello World Senai!!</Text>
     {/*  <Text>Introdução React Native</Text> */}

      <TextInput
        style = {styles.input}
        defaultValue='exemplo de input'
      />

      <Image
      style={styles.image}
      source={imgSenai}
      />

      <TouchableOpacity style= {styles.btn}>
        <Text style= {styles.txt_btn}>Exemplo botão</Text>
      </TouchableOpacity>

     
      <StatusBar style="auto" />
    </View>
    
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'orange',
    color: 'white',
    alignItems: 'center',
    justifyContent: 'center',
    gap: 30
  },

    text1:{
      color: 'white',
      fontSize: 40,
      fontWeight: '500'
    },

  input:{
    width: '90%',
    height: 40,
    borderWidth: 1,
    borderColor: 'white',
    borderRadius: 8,
    backgroundColor: 'white',
    padding: 10
    
  },

  image: {
    width:100,
    height:100,
    marginBottom: 50

  },

  btn: {
    borderColor: 'red',
    borderRadius: 8,
    width: '80%',
    height: 40,
    borderWidth: 1,
    backgroundColor: 'red',
    justifyContent: 'center',
    alignItems: 'center'

  },

    txt_btn: {
      fontSize: 20,
      color: 'white'
    }

  

});
