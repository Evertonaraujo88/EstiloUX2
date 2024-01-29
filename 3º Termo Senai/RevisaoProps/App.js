import { FlatList, SafeAreaView, StatusBar } from "react-native";

//import Components
import Person from "./src/components/Person/Person";
import {
  useFonts,
  Poppins_800ExtraBold_Italic,
} from "@expo-google-fonts/poppins";

export default function App() {
  let [fontsLoaded, fontError] = useFonts({
    Poppins_800ExtraBold_Italic,
  });

  if (!fontsLoaded && !fontError) {
    return null;
  }

  const peopleList = [
    { id: "1", name: "Eventon", age: "35" },
    { id: "2", name: "Luis", age: "20" },
    { id: "3", name: "Carlos", age: "37" },
    { id: "4", name: "Eduardo", age: "47" },
  ];

  return (
    <SafeAreaView>
      <StatusBar />

      {/* Usando flatLis */}
      <FlatList
        data={peopleList}
        keyExtractor={(item) => item.id}
        //leitura da lista
        renderItem={({ item }) => (
          //exibir cada item da lista
          <Person name={item.name} age={item.age} />
        )}
      />
    </SafeAreaView>
  );
}
