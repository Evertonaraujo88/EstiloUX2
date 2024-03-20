import { Image, Modal, StyleSheet, TouchableOpacity, View } from "react-native";

//import das bibliotecas da camera
import { Camera, CameraType } from "expo-camera";
import * as MediaLibrary from "expo-media-library";
import { useEffect, useRef, useState } from "react";

import { FontAwesome } from "@expo/vector-icons";

export const CameraComp = ({visible, setShowCamera, setUriCameraCapture}) => {
  const [photo, setPhoto] = useState(null);
  const [tipoCamera, setTipoCamera] = useState(Camera.Constants.Type.back);
  const [openModal, setOpenModal] = useState(Camera.Constants.Type.front);
  const cameraRef = useRef(null);

  async function CapturePhoto() {
    if (cameraRef) {
      const photo = await cameraRef.current.takePictureAsync();
      setPhoto(photo.uri);

      setOpenModal(true);

      console.log(photo);
    }
  }

  async function SendFormPhoto() {
        await setUriCameraCapture(SavePhoto())

        setShowCamera(false)

        setOpenModal(false)
  }

  async function ClearPhoto() {
    setPhoto(null);

    setOpenModal(false);
  }

  async function SavePhoto() {
    if (photo) {
      await MediaLibrary.createAssetAsync(photo)
        .then(() => {
          alert("Sucesso", "Foto salva na galeria");
        }, setOpenModal(false))
        .catch((erro) => {
          alert("Erro ao processar foto");
        });
    }
  }

  useEffect(() => {
    (async () => {
      const { status: cameraStatus } =
        await Camera.requestCameraPermissionsAsync();
      const { status: mediaStatus } =
        await MediaLibrary.requestPermissionsAsync();
    })();
  }, []);
  return (
    <Camera
      ref={cameraRef}
      style={styles.camera}
      type={tipoCamera}
      ratio={"16:9"}
    >
      <View style={styles.viewFlip}>
        <TouchableOpacity
          style={styles.btnFlip}
          onPress={() =>
            setTipoCamera(
              tipoCamera == CameraType.front
                ? CameraType.back
                : CameraType.front
            )
          }
        >
          <FontAwesome
            name="refresh"
            size={23}
            color={"#fff"}
            style={styles.textFlip}
          />
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.btnCaptura}
          onPress={() => CapturePhoto()}
        >
          <FontAwesome name="camera" size={23} color={"#fff"} />
        </TouchableOpacity>

        <Modal animationType="slide" transparent={false} visible={openModal}>
          <View
            style={{
              flex: 1,
              alignItems: "center",
              justifyContent: "center",
              padding: 30,
              backgroundColor: "transparent",
            }}
          >
            <Image
              style={{ width: "100%", height: 500, borderRadius: 10 }}
              source={{ uri: photo }}
            />

            <View style={{ margin: 15, flexDirection: "row" }}>
              <TouchableOpacity
                style={styles.btnCancel}
                onPress={() => ClearPhoto()}
              >
                <FontAwesome name="trash" size={30} color={"#ff0000"} />
              </TouchableOpacity>

              <TouchableOpacity
                style={styles.btnUpLoad}
                /* onPress={() => SavePhoto(), } */
                onPress={() => SendFormPhoto()}
              >
                <FontAwesome name="save" size={30} color={"#121212"} />
              </TouchableOpacity>
            </View>
          </View>
        </Modal>
      </View>
    </Camera>
  );
};

const styles = StyleSheet.create({
    camera: {
        flex: 1,
        height: "80%",
        width: "100%",
      },
    
      viewFlip: {
        flex: 1,
        backgroundColor: "trasparent",
        flexDirection: "row",
        alignItems: "flex-end",
        justifyContent: "center",
      },
    
      btnFlip: {
        // position: 'absolute',
        // bottom: 20,
        // left: 20,
        padding: 20,
        alignItems: "center",
        justifyContent: "center",
      },
    
      textFlip: {
        fontSize: 20,
        color: "#ffff",
        marginBottom: 20,
      },
    
      btnCaptura: {
        margin: 20,
        padding: 20,
        borderRadius: 15,
        backgroundColor: "transparent",
    
        alignItems: "center",
        justifyContent: "center",
      },
    
      btnCancel: {
        padding: 20,
        borderRadius: 15,
        backgroundColor: "transparent",
    
        alignItems: "center",
        justifyContent: "center",
      },
    
      btnUpLoad: {
        padding: 20,
        borderRadius: 15,
        backgroundColor: "transparent",
    
        alignItems: "center",
        justifyContent: "center",
      },
    });
    