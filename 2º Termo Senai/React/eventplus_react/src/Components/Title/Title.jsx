import React from 'react';

//estilizacao
import '../Title/Title.css'

const Title = ({ titleText, color = "", potatoClass = "" }) => {
    return (
        <div>
            <h1 className={`title ${potatoClass}`} style={ {color: color} }>
                {titleText}

                <hr 
                
                className="title__underscore"
                style={
                    color !== "" ? {borderColor: color} : {}

                }

                />
            </h1>
        </div>
    );
};

export default Title;