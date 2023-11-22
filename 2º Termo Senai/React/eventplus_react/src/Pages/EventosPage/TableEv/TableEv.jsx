import React from 'react';

//estilizacao
import './TableEv.css';

//imagens
import edtiPen from '../../../Assets/Images/edit-pen.svg';
import trashDelete from '../../../Assets/Images/trash-delete.svg';

const TableEv = ({ dados, fnDelete = null, fnUpdate = null }) => {
    return (
        <table className='table-data'>

            {/*cabecalho */}

            <thead className="table-data__head">
                <tr className="table-data__head-row">
                    <th className="table-data__head-title table-data__head-title--big">Evento</th>
                    <th className="table-data__head-title table-data__head-title--big">Descrição</th>
                    <th className="table-data__head-title table-data__head-title--big">Tipo Evento</th>
                    <th className="table-data__head-title table-data__head-title--big">Data</th>
                    <th className="table-data__head-title table-data__head-title--little">Editar</th>
                    <th className="table-data__head-title table-data__head-title--little">Deletar</th>
                </tr>
            </thead>

            {/*corpo */}
            <tbody>
                {dados.map((tp) => {
                    return (
                        <tr className="table-data__head-row" key={tp.idTipoEvento}>
                            <td className="table-data__data table-data__data--big">
                                {tp.titulo}
                            </td>

                            <td className="table-data__data table-data__data--little"
                                idtipoevento={tp.idTipoEvento}
                            >
                                <img
                                    className="table-data__icon"
                                    src={edtiPen}
                                    alt=""
                                    onClick={() => {
                                        fnUpdate(tp.idTipoEvento)
                                    }}
                                />

                            </td>

                            <td className="table-data__data table-data__data--little"

                            >
                                <img
                                    idtipoevento={tp.idTipoEvento}
                                    className="table-data__icon"
                                    src={trashDelete}
                                    alt=""
                                    onClick={(e) => {
                                        fnDelete(e.target.getAttribute('idtipoevento'))
                                    }}
                                />
                            </td>
                        </tr>
                    );
                })}

            </tbody>

        </table>
    );
};

export default TableEv;