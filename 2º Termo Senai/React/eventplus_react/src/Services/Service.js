import axios from "axios";

/**
 * Rota para o recurso Evento
 */
export const eventsResource = '/Evento';
/**
 * Rota para o recurso meu eventos
 */
export const myEventsResource = '/PresencasEvento/ListarMinhas';

/**
 * Rota para o recurso de cadastrar presencas Eventos
 */
export const presencesEventsResource = '/PresencasEvento';
/**
 * Rota para o recurso listar Minhas presencas
 */
export const commentaryEventIdResource = '/ComentariosEvento/BuscarPorId'

/**
 * Rota para o recurso listar Minhas presencas
 */
export const commentaryEventResource = '/ComentariosEvento'

/**
 * Rota para o recurso Proximos Eventos
 */
export const nextEventsResource = '/Evento/ListaProximos';

/** 
 * Rota para o recurso Tipos de Eventos
 */
export const eventsTypeResource = '/TiposEvento';

/**
 * Rota para o recurso Instituição
 */
export const instituicaoResource = '/Instituicao';
/**


/** 
 * Rota para o recurso Login
 */
export const loginResource = '/Login';

const apiPort = '7118';
const localApiUri = `https://localhost:${apiPort}/api`;
/* const externalApiUri = null; */

const api = axios.create({
    baseURL: localApiUri
});

export default api;