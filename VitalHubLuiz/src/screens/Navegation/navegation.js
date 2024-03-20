import { Button, View } from "react-native";

export const Navegation = ({navigation}) => {
    return(
        <View style={{flex:1, alignItems:"center", justifyContent:"center"}}>
            <Button
                title="Login"
                onPress={() => navigation.navigate("Login")}
            />
            <Button
                title="Recuperar senha"
                onPress={() => navigation.navigate("RecuperarSenha")}
            />
            <Button
                title="Verificar Email"
                onPress={() => navigation.navigate("VerifyEmail")}
            />
            <Button
                title="Redefinir senha"
                onPress={() => navigation.navigate("ResetPassword")}
            />
            <Button
                title="Criar conta"
                onPress={() => navigation.navigate("CriarConta")}
            />
            <Button
                title="Perfil"
                onPress={() => navigation.navigate("Profile")}
            />
            <Button
                title="Consulta doutor"
                onPress={() => navigation.navigate("AppointmentDoctor")}
            />
            <Button
                title="Consulta paciente"
                onPress={() => navigation.navigate("AppointmentPacient")}
            />
            <Button
                title="Selecionar clinica"
                onPress={() => navigation.navigate("SelectClinic")}
            />
            <Button
                title="Selecionar medico"
                onPress={() => navigation.navigate("SelectDoctor")}
            />
            <Button
                title="Selecionar data"
                onPress={() => navigation.navigate("SelectDate")}
            />
            <Button
                title="Ver local"
                onPress={() => navigation.navigate("AppointmentLocation")}
            />
            <Button
                title="Editar perfil"
                onPress={() => navigation.navigate("EditProfile")}
            />
            <Button
                title="Editar prontuário"
                onPress={() => navigation.navigate("EditMedicalRecord")}
            />
        </View>
    );
} 