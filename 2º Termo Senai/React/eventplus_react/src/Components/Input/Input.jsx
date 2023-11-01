import React from 'react';

const Input = ({type, name, id, placeholder,value,onChange}) => {

    //numero1 eh o que esta gravado no campo e o setNumero1 eh o valor que foi digitado no form
   /*  const [numero1, setNumero1] = useState(); */
    return (
        <div>
            <input 
            type={type }
            name={name}
            id={id} 
            placeholder={placeholder}
            value={value}
            //onchange eh o campo de digitacao do input, (e)a props do input e pega o valor do setNumer para transmitir
            onChange ={onChange}
                                   
            />
            <span>{value}</span>
        </div>
    );
   /*  return (
        <div>
            <input 
            type={props.type }
            name={props.name}
            id={props.id} 
            placeholder={props.placeholder}
            
            />
        </div>
    ); */
};

export default Input;