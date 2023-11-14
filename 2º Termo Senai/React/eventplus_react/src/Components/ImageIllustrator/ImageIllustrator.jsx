import React from 'react';

//estilizacao
import './ImageIllustrator.css';

//imagens
import defaultImage from '../../Assets/Images/default-image.jpeg';


const ImageIlustrator = ({altText, additionalClass, imageRender = defaultImage}) => {
    
   /*  let imageResource;

    switch (imageName) {

        case 'evento':
            imageResource = eventoImage
            break;

        case 'tipoEvento':
            imageResource = tipoEventoImagem
            break;
    
        default:
            imageResource = defaultImage
            break;

    } */
    
    return (
        <figure className='illustrator-brox'>
            <img 
            src={imageRender}
            alt={altText}
            className={`illustrator=box__image ${additionalClass}`}
            />


        </figure>
    );
};

export default ImageIlustrator;