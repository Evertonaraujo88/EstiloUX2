import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, TouchableOpacity, Modal, Image } from 'react-native';

//Import da camera
import { Camera, CameraType, FlashMode } from 'expo-camera';
import { useEffect, useState, useRef } from 'react';

import {FontAwesome} from '@expo/vector-icons';

import * as MediaLibrary from 'expo-media-library'

export default function App() {

  /* Desafio:

    - Quando salvar a foto - poder apagar da galeria
    - Botao para ativar o flash
    - forma de recarregar o autofocus

    - aplicando o Video no projeto
   */
  

  //Coloca se vai ser a camera da frente(front) ou de traz(back)
  
  const cameraRef = useRef(null);
  const [photo, setPhoto] = useState(null);
  const [ openModal, setOpenModal] = useState (Camera.Constants.Type.front)
  const [ tipoCamera, setTipoCamera ] = useState(Camera.Constants.Type.back);
  const [flash, setFlash] = useState(Camera.Constants.FlashMode.off)


  async function CapturePhoto() {
    if (cameraRef) {
      const photo = await cameraRef.current.takePictureAsync();
      setPhoto( photo.uri)

      setOpenModal(true)

      console.log(photo)

    }
  }

  async function PowerFlash() {

    if (flash === Camera.Constants.FlashMode.off) {
      
      // Verifica se o dispositivo suporta flash
      const { isAvailable } = await Camera.getAvailableCameraTypesAsync();
      if (!isAvailable(Camera.Constants.Type.back)) {
        alert("Este dispositivo não suporta o uso de flash.");
        return;
      }
      setFlash(Camera.Constants.FlashMode.on);
    } else {
      setFlash(Camera.Constants.FlashMode.off);
    }
  }
  

  async function ClearPhoto() {

    setPhoto(null)

    setOpenModal(false)
  }

  async function SavePhoto() {
    
    if ( photo) {
      
        await MediaLibrary.createAssetAsync(photo)
        .then( () => { alert('Sucesso', 'Foto salva na galeria')}, setOpenModal(false))
        .catch( erro => { alert('Erro ao processar foto')
      })
    }
  }

  useEffect(() => {
    ( async () => {
      const { status: cameraStatus } = await Camera.requestCameraPermissionsAsync();

      const {status: mediaStatus} = await MediaLibrary.requestPermissionsAsync();
    })(); 
  }, [])

  return (
    <View style={styles.container}>
      <Camera
      ref={cameraRef}
        type={tipoCamera}
        style={styles.camera}
        ratio={'16:9'}
        flashMode={flash}
      >
        <View style={styles.viewFlip}>
          <TouchableOpacity style={styles.btnFlip} onPress={() => setTipoCamera(tipoCamera == CameraType.front ? CameraType.back : CameraType.front)}>
            <FontAwesome name='refresh' size={23} color={'#fff'} style={styles.textFlip}/>
           {/*  <Text style={styles.textFlip}>
              Trocar
            </Text> */}
          </TouchableOpacity>
          <TouchableOpacity style={styles.btnCaptura} onPress={() => CapturePhoto()}>
            <FontAwesome name='camera' size={23} color={'#fff'} />
          </TouchableOpacity>

          <TouchableOpacity style={styles.btnCaptura} onPress={() => PowerFlash()}>
            <FontAwesome name='flash' size={23} color={'#fff'} />
          </TouchableOpacity>

          <Modal animationType='slide' transparent={false} visible={openModal} >
            <View style={{flex: 1, alignItems:'center', justifyContent: 'center', padding:30}}>
              <Image style={{width: '100%', height: 500, borderRadius: 10}}
                    source= {{uri: photo}}
              />

              <View style={{margin: 15, flexDirection: 'row'}}>
                {/* <TouchableOpacity onPress={() => setOpenModal(false)}>
                  <Text style={{ fontSize:24}}>
                    Fechar
                  </Text>
              </TouchableOpacity> */}
               <TouchableOpacity 
                style={styles.btnCancel} 
                onPress={() => ClearPhoto()}>
                  <FontAwesome name='trash' size={30} color={'#ff0000'} />
              </TouchableOpacity>

              <TouchableOpacity 
                style={styles.btnUpLoad} 
                onPress={() => SavePhoto()}>
                  <FontAwesome name='save' size={30} color={'#121212'} />
              </TouchableOpacity>

              </View>

              
            </View>

           
          </Modal>
        </View>
      
      </Camera>

      {/* <TouchableOpacity style={styles.btnCaptura} onPress={() => CapturePhoto()}>
        <FontAwesome name='camera' size={23} color={'#fff'}/>
      </TouchableOpacity> */}
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
  camera: {
    flex: 1,
    height: '80%',
    width: '100%'
  },

  viewFlip: {
    flex: 1,
    backgroundColor: 'trasparent',
    flexDirection: 'row',
    alignItems: 'flex-end',
    justifyContent: 'center'
  },

  btnFlip: {
    // position: 'absolute',
    // bottom: 20,
    // left: 20,
    padding:20,
    alignItems: 'center',
    justifyContent: 'center'
  },

  textFlip: {
    fontSize: 20,
    color: '#ffff',
    marginBottom: 20
  },

  btnCaptura:{
    margin: 20,
    padding: 20,
    borderRadius: 15,
    backgroundColor: 'transparent',

    alignItems: "center",
    justifyContent: "center"
  },

  btnCancel: {
    padding: 20,
    borderRadius: 15,
    backgroundColor: 'transparent',

    alignItems: "center",
    justifyContent: "center"
  },

  btnUpLoad: {
    padding: 20,
    borderRadius: 15,
    backgroundColor: 'transparent',

    alignItems: "center",
    justifyContent: "center"
  },


});
