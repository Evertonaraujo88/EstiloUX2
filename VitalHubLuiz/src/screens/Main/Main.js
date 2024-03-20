import { ContentIcon, TextIcon } from "./Style"

//Importar recursos do bottom tabs
import { createBottomTabNavigator } from "@react-navigation/bottom-tabs"
import { AppointmentDoctor } from "../AppointmentDoctor/appointmentDoctor"
import { Profile } from "../Profile/profile"
import { EditProfile } from "../EditProfile/EditProfile"

import { FontAwesome, FontAwesome5 } from '@expo/vector-icons'
import { AppointmentPacient } from "../AppointmentPacient/AppointmentPacient"
const BottomTab = createBottomTabNavigator()

export const Main = () => {
    return(

        <BottomTab.Navigator
            initialRouteName="Home"
            screenOptions={ ({ route }) => ({
                tabBarStyle: {backgroundColor: "#FFFFFF", height: 80, paddingTop: 10},
                tabBarActiveBackgroundColor: "Transparent",
                tabBarShowLabel: false,
                headerShow: false,

                tabBarIcon: ({ focused }) => {
                    if(route.name === "Home"){
                        return(
                            <ContentIcon
                                tabBarActiveBackgroundColor = { focused ? "#ECF2FF" : "tranparent"}
                            >
                                <FontAwesome name="calendar" size={18} color="#4E4B59"/>
                                { focused && <TextIcon>Agenda</TextIcon>}
                            </ContentIcon>
                        )
                    }else{
                        return(
                            <ContentIcon
                                tabBarActiveBackgroundColor = { focused ? "#ECF2FF" : "tranparent"}
                            >
                                <FontAwesome name="user-circle" size={18} color="#4E4B59"/>
                                { focused && <TextIcon>Perfil</TextIcon>}
                            </ContentIcon>
                        )
                    }
                }
            })}
        >
            {/* Criar a rota da home */}
            <BottomTab.Screen
                name='Home'
                component={ AppointmentPacient }
            />

            {/* Criar rota do perfil */}

            <BottomTab.Screen
                name='Perfil'
                component={ EditProfile }
            />

        </BottomTab.Navigator>

    )
}