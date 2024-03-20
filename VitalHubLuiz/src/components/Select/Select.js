import RNPickerSelect from 'react-native-picker-select';
import { SelectComponent, ViewSelect } from './Style';
import { StyleSheet, View } from 'react-native';

export const Select = () => {
    return(
        <ViewSelect>
            <RNPickerSelect
                placeholder={{
                    label: 'Selecionar horário',
                    value: null,
                    color: '#34898F',
                  }}
                useNativeAndroidPickerStyle={false} 
                onValueChange={(value) => console.log(value)}
                items={[
                    { label: '7h00', value: '7h00' },
                    { label: '10h00', value: '10h00' },
                    { label: '15h00', value: '15h00' },
                ]}
    
                style={{
                    ...pickerSelectStyles,
                    iconContainer: {
                        top: 28,
                        right: 16,
                      },
                    placeholder: {
                        color: '#34898F',
                        fontSize: 14,
                        fontFamily: 'MontserratAlternates_600SemiBold',
                    }
                }}

                Icon={() => {
                    return (
                      <View
                        style={{
                          backgroundColor: 'transparent',
                          borderTopWidth: 10,
                          borderTopColor: '#34898F',
                          borderRightWidth: 10,
                          borderRightColor: 'transparent',
                          borderLeftWidth: 10,
                          borderLeftColor: 'transparent',
                          width: 0,
                          height: 0,
                        }}
                      />
                    );
                  }}
    
                
            />
        </ViewSelect>
    )
}

const pickerSelectStyles = StyleSheet.create({
    inputIOS: {
      fontSize: 16,
      paddingVertical: 12,
      paddingHorizontal: 10,
      borderWidth: 1,
      borderColor: 'gray',
      borderRadius: 4,
      color: 'pink',
      paddingRight: 30, // to ensure the text is never behind the icon
    },
    inputAndroid: {
      fontSize: 16,
      paddingHorizontal: 16,
      paddingVertical: 16,
      borderWidth: 2,
      borderColor: '#60BFC5',
      borderRadius: 5,
      color: '#34898F',
      paddingRight: 30, // to ensure the text is never behind the icon
    },
  });
  