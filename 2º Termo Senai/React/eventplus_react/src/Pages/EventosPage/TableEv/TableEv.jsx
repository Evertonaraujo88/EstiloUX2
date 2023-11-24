import React from 'react';

//estilizacao
import './TableEv.css';

//imagens
import edtiPen from '../../../Assets/Images/edit-pen.svg';
import trashDelete from '../../../Assets/Images/trash-delete.svg';
import { dateFormatDbToViewSimple } from '../../../Utils/StringFunction';

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
                        <tr className="table-data__head-row" key={tp.idEvento}>
                            <td className="table-data__data table-data__data--big">
                                {tp.nomeEvento}
                            </td>

                            <td className="table-data__data table-data__data--big">
                                {tp.descricao}
                            </td>

                            <td className="table-data__data table-data__data--big">
                                {tp.tiposEvento.titulo}
                            </td>

                            <td className="table-data__data table-data__data--big">
                                {dateFormatDbToViewSimple(tp.dataEvento)}
                            </td>

                            <td className="table-data__data table-data__data--little"
                                idevento={tp.idEvento}
                            >
                                <img
                                    className="table-data__icon"
                                    src={edtiPen}
                                    alt=""
                                    onClick={() => {
                                        fnUpdate({
                                            idEvento: tp.idEvento,
                                            nomeEvento: tp.nomeEvento,
                                            dataEvento: tp.dataEvento,
                                            descricao: tp.descricao,
                                            idInstituicao: tp.idInstituicao,
                                            idTipoEvento: tp.idTipoEvento,

                                        })
                                    }}
                                />

                            </td>

                            <td className="table-data__data table-data__data--little"

                            >
                                <img
                                    idevento={tp.idEvento}
                                    className="table-data__icon"
                                    src={trashDelete}
                                    alt=""
                                    onClick={(e) => {
                                        fnDelete(e.target.getAttribute('idevento'))
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