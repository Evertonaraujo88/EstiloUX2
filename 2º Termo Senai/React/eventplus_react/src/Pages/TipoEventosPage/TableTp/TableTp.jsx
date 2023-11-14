import React from 'react';

//estilizacao
import './TableTp.css';

//imagens
import edtiPen from '../../../Assets/Images/edit-pen.svg';
import trashDelete from '../../../Assets/Images/trash-delete.svg';

const TableTp = ({ dados, fnDelete = null, fnUpdate = null }) => {
    return (
        <table className='table-data'>

            {/*cabecalho */}

            <thead className="table-data__head">
                <tr className="table-data__head-row">
                    <th className="table-data__head-title table-data__head-title--big">Título</th>
                    <th className="table-data__head-title table-data__head-title--little">Editar</th>
                    <th className="table-data__head-title table-data__head-title--little">Deletar</th>
                </tr>
            </thead>

            {/*corpo */}
            <tbody>
                {dados.map((tp) => {
                    return (
                        <tr className="table-data__head-row">
                            <td className="table-data__data table-data__data--big">
                                Texto do tipo
                            </td>

                            <td className="table-data__data table-data__data--little">
                                <img className="table-data__icon" src={edtiPen} alt="" />
                            </td>

                            <td className="table-data__data table-data__data--little">
                                <img className="table-data__icon" src={trashDelete} alt="" />
                            </td>
                        </tr>
                    );
                })}

            </tbody>

        </table>
    );
};

export default TableTp;