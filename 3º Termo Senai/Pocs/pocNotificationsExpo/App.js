import { StatusBar } from 'expo-status-bar';
import { Button, StyleSheet, Text, TouchableOpacity, View } from 'react-native';

//importar os recursos da biblioteca do notifications
import * as Notifications from 'expo-notifications';

//solicitar as permissoes de notificacao ao iniciar o app
Notifications.requestPermissionsAsync();

//definir como as notificacoes devem ser tratadas quando recebidas
Notifications.setNotificationHandler({
  handleNotification: async() => ({
    
    //mostra o alerta quando a notificacao for recebida
    shouldShowAlert: true,

    //reproduz ou nao alerta sonoro ao receber notificacao
    shouldPlaySound: true,

    //configura numero de notificacoes no icone do app (exemplo: noticacoes de conversas no zap..no icone fica uma bolinha indicando que tem notificacao)
    shouldSetBadge: true,

  })
})

export default function App() {

    //funcao para lidar com a chamada da notificacao
    const handleCallNotifications = async () => {

      //aguarda resposta se o usuario autorizou ou nao a permissao de acesso
      const {status} = await Notifications.getPermissionsAsync();

      //verifica se o usuario concedeu permissao para notificacao
      if (status !== "granted") {
        alert("Voce não deixou as notificações ativas");
        return;
      }

      /* //Obter o token de envio de notificação
      const token = await Notifications.getExpoPushTokenAsync();

      console.log(token); */

      //agendar uma notificacao para ser exibida apos 5 segundos
      await Notifications.scheduleNotificationAsync({
        content: {
          title: 'Hello World!!',
          body: 'Criando uma poc para implementar expo notifications no aplicativo',
          
        },
        trigger: {
          seconds: 2
        }

      })




    }

  return (
    <View style={styles.container}>
      <TouchableOpacity style={styles.button} /* onPress={handleCallNotifications} */>
        <Text style={styles.text}>Notificação</Text>
      </TouchableOpacity>
      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },

  button: {
    width: '80%',
    height: 80,
    backgroundColor: 'blue',
    borderRadius: 15,
    alignItems: "center",
    justifyContent: "center"
  },

  text: {
    color: '#FFF',
    fontSize: 18,
    fontWeight: "bold"
  }
});
