import { StatusBar } from "expo-status-bar";
import { ActivityIndicator, StyleSheet, Text, View } from "react-native";
import { useEffect, useState, useRef } from "react";

// import da dependencia do mapa
import MapView, { Marker, PROVIDER_GOOGLE } from "react-native-maps";

import {
  //solicita o acesso a localização atual do ususario
  requestForegroundPermissionsAsync,

  //recebe a localizacao atual do usuario
  getCurrentPositionAsync,

  //monitorar o posicionamento
  watchPositionAsync,

  //Pega o valor da localizacao
  LocationAccuracy
} from "expo-location";

// import de distancia entre dois pontos
import MapViewDirections from "react-native-maps-directions";

//import APIKEY
import {mapskey} from "./util/mapsApiKey"

//USEref



export default function App() {
  const mapReference = useRef(null);

  const [initialPosition, setInitialPosition] = useState(null);
  const [finalPosition, setFinalPosition] = useState(
    {
      latitude : -23.68037,
      longitude : -46.49932
    }
  );

  async function CapturarLocalizacao() {
    const { granted } = await requestForegroundPermissionsAsync();

    if (granted) {
      const captureLocation = await getCurrentPositionAsync();

      setInitialPosition(captureLocation);

      console.log(initialPosition);
    }
  }

  useEffect(() => {
    CapturarLocalizacao()

    watchPositionAsync({
      accuracy : LocationAccuracy.Highest,
      timeInterval : 1000,
      distanceInterval : 1,

    }, async (response) => {

      //recebe e aguarda a nova localizacao
      await setInitialPosition (response)

      mapReference.current?.animateCamera({
        pitch: 60,
        center: response.coords
      })

      console.log(response);
    })

  }, [1000]);

  useEffect(() => {
    RecarregarVisualizacaoMapa();
  }, [initialPosition]);

  async function RecarregarVisualizacaoMapa() {
      if (mapReference.current && initialPosition) {
        await mapReference.current.fitToCoordinates(
          [{ latitude: initialPosition.coords.latitude,
             longitude: initialPosition.coords.longitude},

             {latitude: finalPosition.latitude, longitude: finalPosition.longitude}
          ],
          {
            edgePadding: { top: 60, right: 60, bottom: 60, left:60},
            animated: true
          }
        )
      }
  }

  return (
    <View style={styles.container}>
      {initialPosition != null ? (
        <MapView
          style={styles.map}

          ref={mapReference}

          //marcar o ponto de inicio
          initialRegion={{
            latitude: initialPosition.coords.latitude,
            longitude: initialPosition.coords.longitude,
            latitudeDelta: 0.005,
            longitudeDelta: 0.005,
          }}

          provider={PROVIDER_GOOGLE}
          customMapStyle={grayMapStyle}
        >
          <Marker
            coordinate={{
              latitude: initialPosition.coords.latitude,
              longitude: initialPosition.coords.longitude,
            }}
            title="Posição Inicial"
            description="Estou aqui"
            pinColor={'Red'}
          />

          <MapViewDirections
            origin={ initialPosition.coords }
            destination={ {
              latitude: -23.68037,
              longitude: -46.49932,
              latitudeDelta: 0.005,
              longitudeDelta: 0.005,
            }}

            strokeWidth={5}
            strokeColor="#496BBa"
            apikey={mapskey}
          />

          <Marker
            coordinate={{
              latitude: -23.68037,
              longitude: -46.49932,
            }}
            title="Destino final"
            description="Meu destino"
            pinColor={'yellow'}
          />
        </MapView>
      ) : (
        <>
          <Text>localização nao encontrada</Text>

          <ActivityIndicator />
        </>
      )}
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

  map: {
    width: "100%",
    flex: 1,
  },
});



const grayMapStyle = [
  {
    elementType: "geometry",
    stylers: [
      {
        color: "#E1E0E7",
      },
    ],
  },
  {
    elementType: "geometry.fill",
    stylers: [
      {
        saturation: -5,
      },
      {
        lightness: -5,
      },
    ],
  },
  {
    elementType: "labels.icon",
    stylers: [
      {
        visibility: "on",
      },
    ],
  },
  {
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#FBFBFB",
      },
    ],
  },
  {
    elementType: "labels.text.stroke",
    stylers: [
      {
        color: "#33303E",
      },
    ],
  },
  {
    featureType: "administrative",
    elementType: "geometry",
    stylers: [
      {
        color: "#fbfbfb",
      },
    ],
  },
  {
    featureType: "administrative.country",
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#fbfbfb",
      },
    ],
  },
  {
    featureType: "administrative.land_parcel",
    stylers: [
      {
        visibility: "on",
      },
    ],
  },
  {
    featureType: "administrative.locality",
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#fbfbfb",
      },
    ],
  },
  {
    featureType: "poi",
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#fbfbfb",
      },
    ],
  },
  {
    featureType: "poi.business",
    stylers: [
      {
        visibility: "on",
      },
    ],
  },
  {
    featureType: "poi.park",
    elementType: "geometry",
    stylers: [
      {
        color: "#66DA9F",
      },
    ],
  },
  {
    featureType: "poi.park",
    elementType: "labels.text",
    stylers: [
      {
        visibility: "on",
      },
    ],
  },
  {
    featureType: "poi.park",
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#fbfbfb",
      },
    ],
  },
  {
    featureType: "poi.park",
    elementType: "labels.text.stroke",
    stylers: [
      {
        color: "#1B1B1B",
      },
    ],
  },
  {
    featureType: "road",
    stylers: [
      {
        visibility: "on",
      },
    ],
  },
  {
    featureType: "road",
    elementType: "geometry.fill",
    stylers: [
      {
        color: "#C6C5CE",
      },
    ],
  },
  {
    featureType: "road",
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#FBFBFB",
      },
    ],
  },
  {
    featureType: "road.arterial",
    elementType: "geometry",
    stylers: [
      {
        color: "#ACABB7",
      },
    ],
  },
  {
    featureType: "road.highway",
    elementType: "geometry",
    stylers: [
      {
        color: "#8C8A97",
      },
    ],
  },
  {
    featureType: "road.highway.controlled_access",
    elementType: "geometry",
    stylers: [
      {
        color: "#8C8A97",
      },
    ],
  },
  {
    featureType: "road.local",
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#fbfbfb",
      },
    ],
  },
  {
    featureType: "transit",
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#fbfbfb",
      },
    ],
  },
  {
    featureType: "water",
    elementType: "geometry",
    stylers: [
      {
        color: "#8EA5D9",
      },
    ],
  },
  {
    featureType: "water",
    elementType: "labels.text.fill",
    stylers: [
      {
        color: "#fbfbfb",
      },
    ],
  },
];

