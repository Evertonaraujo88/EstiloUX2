import { SafeAreaView, StatusBar, StyleSheet, Text, View } from "react-native";

//import Components
import Person from "./src/components/Person/Person";

export default function App() {
  return (
    <SafeAreaView>
      <StatusBar />

      <Person name="Everton" age={35} />
      <Person name="Luiz" age={20} />
      <Person name="CArlos" age={37} />
      <Person name="Eduardo" age={47} />
      <Person name="Lucas" age={27} />
      
    </SafeAreaView>
  );
}
