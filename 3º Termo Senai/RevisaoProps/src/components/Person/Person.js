import { StyleSheet, Text, View } from "react-native";

//COmponente Person
//Propos : name, age
const Person = ({ name, age }) => {
  return (
    <View style={styles.container}>
      <Text style={styles.txt}>Nome: {name}</Text>
      <Text style={styles.txt}>Idade: {age}</Text>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#d3d3d3",
    padding: 10,
    margin: 10,
    borderRadius: 5,
  },

  txt: {
    fontSize: 18,
    fontWeight: '600'
  }
});

export default Person;
