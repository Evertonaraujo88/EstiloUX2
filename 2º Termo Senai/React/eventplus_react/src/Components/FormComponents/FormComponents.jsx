import React from 'react';

//Estilizacao
import './FormComponents.css';

//exportacao
export const Input = ({
    type,
    id,
    value,
    required,
    additionalClass = "",
    name,
    placeholder,
    manipulationFunction
}) => {
    return (

        <input
            type={type}
            id={id}
            value={value}
            required={required ? "required" : ""}
            className={`input-component ${additionalClass}`}
            name={name}
            placeholder={placeholder}
            onChange={manipulationFunction}
            autoComplete='off'
        />
    );
};

export const Label = ({ htmlFor, labelText }) => {
    return <label htmlFor={htmlFor}>{labelText}</label>
};

export const Button = (props) => {
    return (
        <button
            id={props.id}
            name={props.name}
            type={props.type}
            className={`button-component ${props.additionalClass}`}
            onClick={props.onClick}
        >
            {props.textButton}
        </button>
    );
}

export const Select = ({
    required,
    id,
    name,
    options,
    additionalClass = "",
    manipulationFunction,
    defaultValue

}) => {
    return (
        <select
            name={name}
            id={id}
            required={required ? "required" : ""}
            className={`input-component ${additionalClass}`}
            onChange ={manipulationFunction}
            value = {defaultValue}
        >

            {/* <option value=""> Selecione </option> */}

            {options.map((o) => {
                return(
                    <option key={Math.random()} value ={o.value}>{o.text}</option>
                    );
            })}

        </select>
    );
}

/* const FormComponents = () => {
    return (
        
    );
};

export default FormComponents; */