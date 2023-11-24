//
export const dateFormatDbToView = date => {

    date = date.substr(0,10)
    date = date.split('-')


    return `${date[2]}/${date[1]}/${date[0]}`
}

export const dateFormatDbToViewSimple = date => {
    return new Date(date).toLocaleDateString();
}

export const dateFormatDbToViewBack = date => {

    date = date.substr(0,10)
    date = date.split('-')

    return `${date[0]}-${date[1]}-${date[2]}`
}