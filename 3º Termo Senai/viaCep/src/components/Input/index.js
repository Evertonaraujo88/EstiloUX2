import { InputText } from "./style";

export function Input({
    placeholder,
    editable,
    fieldValue,
    onchangeText,
    KeyType,
    maxLenght
    })  {
    return(
        <InputText
            placeholder = {placeholder}
            editable = {editable}
            KeyboardType = {KeyType}
            maxLenght = {maxLenght}
            value = {fieldValue}
            onchangeText= {onchangeText}
        />
    )
}