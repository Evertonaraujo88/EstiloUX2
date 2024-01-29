import { StatusBar } from "expo-status-bar";
import { useState, useEffect } from "react";
import { StyleSheet, Text, TouchableOpacity, View } from "react-native";

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

  return (
    <View style={styles.container}>

      <View style={styles.cont}>
        <Text style={styles.txt_cont}>Contador : {count} </Text>
      </View>
      

      <TouchableOpacity style={styles.btn} onPress={incremet}>
        <Text style={styles.text}>Incrementar</Text>
      </TouchableOpacity>

      <TouchableOpacity style={styles.btn} onPress={decremet}>
        <Text  style={styles.text}>Decrementar</Text>
      </TouchableOpacity>

      <StatusBar style="auto"/>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },

  cont:{
    width: '80%',
    height: 200,
    alignItems: 'center',
    justifyContent: "center",
  },

  txt_cont:{
    fontSize: 40,

  },

  btn: {
    width: "80%",
    height: 40,
    backgroundColor: "blue",
    marginTop: 20,
    alignItems: 'center',
    justifyContent: "center",
    borderRadius: 8
  },

  text: {
    fontSize: 18,
    color: 'white'
 }
});
