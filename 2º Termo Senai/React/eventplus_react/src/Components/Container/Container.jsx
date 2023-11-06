import React from 'react';

//import css
import '../Container/Container.css';

const Container = ({children}) => {
    return (
        <div className='container'>
            {children}
        </div>
    );
};

/* const Container = (props) => {
    return (
        <div className='container'>
            {props.children}
        </div>
    );
}; */



export default Container;