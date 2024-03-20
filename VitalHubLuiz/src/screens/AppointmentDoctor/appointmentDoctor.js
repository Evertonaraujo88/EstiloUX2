import { HeaderProfile } from "../../components/HeaderProfile/HeaderProfile";
import { Container } from "../../components/container/style";
import CalendarStrip from 'react-native-calendar-strip';
import { ContainerCalendar, ContainerFilter, ContainerList, FilterAppointment } from "./style";
import { StyledCalendarStrip } from "../../components/StyledCalendarStrip/styledCalendarStrip";
import { StyleSheet } from "react-native";
import moment from "moment";
import { AbsListAppointment } from "../../components/AbsListAppointment/AbsListAppointment";
import { useState } from "react";
import { AppointmentCard } from "../../components/AppointmentCard/AppointmentCard";
import { ListComponent } from "../../components/List/Style";
import { CancelAppointmentModal } from "../../components/CancelAppointmentModal/CancelAppointmentModal";
import { MedicalRecordModal } from "../../components/MedicalRecordModal/MedicalRecordModal";

const Consultas = [
    {id: 1, nome: "Carlos", situacao: "pendente"},
    {id: 2, nome: "Luiz", situacao: "realizado"},
    {id: 3, nome: "Eduardo", situacao: "cancelado"},
    {id: 4, nome: "Joao", situacao: "realizado"},
    {id: 5, nome: "Maria", situacao: "cancelado"}
];

const User = {id: 1, nome: "Dr Drauzio", sourceImage: '../../assets/eduProfileImage.png'};

export const AppointmentDoctor = ({navigation}) => {

    //State para os modais

    const [showModalCancel, setShowModalCancel] = useState(false);
    const [showModalAppointment, setShowModalAppointment] = useState(false);

    const[statusLista, setStatusLista] = useState("pedente"); 

    //define padrão pt-br para calendário
    moment.updateLocale("pt-br", {

        //meses
        months:
            "Janeiro_Fevereiro_Março_Abril_Maio_Junho_Julho_Agosto_Setembro_Outubro_Novembro_Dezembro".split(
                "_"
            ),

        //abreviação de meses
        monthsShort: "jan_fev_mar_abr_mai_jun_jul_ago_set_out_nov_dez".split("_"),

        //dias da semana
        weekdays:
            "domingo_segunda-feira_terça-feira_quarta-feira_quinta-feira_sexta-feira_sábado".split(
                "_"
            ),

        //abreviação dias da semana
        weekdaysShort: "Dom_Seg_Ter_Qua_Qui_Sex_Sáb".split("_"),

        //abreviação dias da semana 
        weekdaysMin: 'dom_2ª_3ª_4ª_5ª_6ª_sáb'.split('_'),
    });

    //instância da data atual
    const currentDate = new Date();

    //define a data inicial como sendo o primeiro dia do mês
    const startingDate = new Date(currentDate.getFullYear(), currentDate.getMonth(), 1);

    //define a data final como sendo o último dia do mês
    const endingDate = new Date(currentDate.getFullYear(), currentDate.getMonth() + 1, 0);
    return (
        <Container>
            {/* Queria passar props com o nome e a URL da imagem, mas nao consegui */}
            {/* Update: O react native nao consegue renderizar imagens dinamicamente, quero ver como o professor vai fazer isso */}
            <HeaderProfile
            />

            <StyledCalendarStrip
                // animação e seleção de cada data
                calendarAnimation={{ type: "sequence", duration: 30 }}
                daySelectionAnimation={styles.selectedAnimationStyle}

                // seta esquerda e direita para avançar e voltar(aqui como display none)
                iconLeftStyle={styles.iconsStyle}
                iconRightStyle={styles.iconsStyle}

                // deixa uma marcação default - data atual
                selectedDate={currentDate}
                // dia que começamos a visualizar a barra
                startingDate={moment()}

                //data min e max - início do mês e final do mês
                minDate={startingDate}
                maxDate={endingDate}

                //estilização dos itens que não estão selecionados
                calendarHeaderStyle={styles.calendarHeaderStyle}
                dateNumberStyle={styles.numberDateStyle}
                dateNameStyle={styles.nameDateStyle}

                // estilização do item que está selecionado - efeito do item marcado
                highlightDateNameStyle={styles.selectedDateNameStyle}
                highlightDateNumberStyle={styles.selectedDateNumberStyle}
                highlightDateContainerStyle={styles.selectedContainerStyle}

                //tamanho do container
                iconContainer={{ flex: 0.1 }}

                //scroll da barra
                scrollable={true}
            />

            {/* Container */}
            <FilterAppointment>

                {/* Botao agendado */}
                <AbsListAppointment
                    textButton={"Agendadas"}
                    clickButton={statusLista === "pendente"}
                    onPress={() => setStatusLista("pendente")}
                />
                {/* Botao realizado */}
                <AbsListAppointment
                    textButton={"Realizadas"}
                    clickButton={statusLista === "realizado"}
                    onPress={() => setStatusLista("realizado")}
                />
                {/* Botao cancelado */}
                <AbsListAppointment
                    textButton={"Canceladas"}
                    clickButton={statusLista === "cancelado"}
                    onPress={() => setStatusLista("cancelado")}
                />

            </FilterAppointment>

            <ContainerList>
            <ListComponent
                data={Consultas}
                keyExtractor={(item) => item.id}

                renderItem={({item}) => 
                statusLista == item.situacao && (
                    <AppointmentCard
                        situacao={item.situacao}
                        onPressCancel={() => setShowModalCancel(true)}
                        onPressAppointment={() => setShowModalAppointment(true)}
                    />
                )
            }
            />
            </ContainerList>

            <CancelAppointmentModal
                visible={showModalCancel}
                onPressConfirmation={() => setShowModalCancel(false)}
                setShowModalCancel={setShowModalCancel}
            />

            <MedicalRecordModal
                visible={showModalAppointment}
                setShowModalAppointment={setShowModalAppointment}
            />

            {/* <AppointmentCard/> */}
                
        </Container>
    )



}
const styles = StyleSheet.create({
    iconsStyle: {
        display: 'none'
    },
    calendarHeaderStyle: {
        fontSize: 22,
        textAlign: "center",
        alignSelf: 'flex-start',
        color: '#4E4B59',
        fontFamily: "MontserratAlternates_600SemiBold",
        paddingHorizontal: 16
    },
    nameDateStyle: {
        color: "#ACABB7",
        fontSize: 12,
        textTransform: 'capitalize'
    },
    numberDateStyle: {
        color: "#5F5C6B",
        fontSize: 16
    },
    selectedDateNameStyle: {
        color: "white",
        fontSize: 12,
        fontWeight: "bold",
        textTransform: 'capitalize'
    },
    selectedDateNumberStyle: {
        color: "white",
        fontSize: 14
    },
    selectedContainerStyle: {
        backgroundColor: `#60BFC5`
    },
    selectedAnimationStyle: {
        type: "border",
        duration: 200,
        borderWidth: 2,
        borderHighlightColor: "#49B3BA"
    }
})
