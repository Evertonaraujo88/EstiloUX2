//
export const dateFormatDbToView = data => {

    //exemplo: 2023-11-15T00:00:00 para 15/11/2023
    data = data.substr(0,10); //retorna apenas os 10 primeiros caracteres da data retornada
    data = data.split("-"); //passou a ser da seguinte forma  =[2023][11][15]


    return `${data[2]}/${data[1]}/${data[0]}`;
} 