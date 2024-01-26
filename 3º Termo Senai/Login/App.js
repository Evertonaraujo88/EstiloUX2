import { useFonts } from "expo-font";
import { StatusBar } from "expo-status-bar";
import {
  Image,
  StyleSheet,
  Text,
  TextInput,
  TouchableOpacity,
  View,
} from "react-native";

const logo = require("./src/assets/images/logo.jpeg");

/* const  pops = require('./src/assets/fonts/src/assets/fonts/Poppins-SemiBold.ttf') */

export default function App() {
  return (
    <View style={styles.container}>
      <Image style={styles.image} source={logo} />

      <Text style={styles.login}>Login</Text>

      <View style={styles.view_inputs}>
        <View>
          <Text style={styles.label}>E-mail:</Text>

          <TextInput style={styles.input} placeholder="Digite seu e-mail:" />
        </View>

        <View>
          <Text style={styles.label}>Senha:</Text>

          <TextInput
            style={styles.input}
            placeholder="Digite sua senha:"
            secureTextEntry={true}
          />
        </View>
      </View>

      <TouchableOpacity style={styles.btn}>
        <Text style={styles.txt_btn}>ENTRAR</Text>
      </TouchableOpacity>

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "",
    gap: 60,
    padding: 20,
    backgroundColor: "black",
    maxWidth: "100%",
    maxHeight: "100%",
  },

  image: {
    width: 200,
    height: 200,
    marginTop: 70,
  },

  login: {
    fontSize: 40,
    fontWeight: "700",
    color: "#ecd453",
  },

  input: {
    borderWidth: 1,
    borderColor: "black",
    borderRadius: 8,
    backgroundColor: "white",
    padding: 10,
  },

  view_inputs: {
    gap: 15,
    width: "80%",
  },

  label: {
    fontSize: 16,
    fontWeight: "400",
    color: "#ecd453",
  },

  btn: {
    borderColor: "#ffd700",
    borderRadius: 8,
    width: "80%",
    height: 50,
    borderWidth: 1,
    backgroundColor: "#ecd453",
    justifyContent: "center",
    alignItems: "center",
  },

  txt_btn: {
    fontSize: 20,
    fontWeight: "600",
    color: "black",
  },
});
