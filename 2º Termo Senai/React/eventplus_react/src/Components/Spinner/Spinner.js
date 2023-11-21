import React from 'react';
import spinner from '../../Assets/Images/spinner-loading.svg';

//estilizacao
import './Spinner.css';

function Spinner({ alt = '', width = '35x', height = '35px' }) {
    return (
        <img 
            className='spinner' 
            src={spinner} 
            alt={alt}
            width={width}
            height={height}
        />
    );
}

export default Spinner;