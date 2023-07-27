import React, { useEffect } from "react";
import Loader from "../Loader";
import Form from '../Form';
import { GlobalContext } from "../../ApiContext";
import { useNavigate } from "react-router-dom";

const InitialForm = {
    nombreCad: "",
    direccion: "",
    telefono: "",
    id: null,
}
const Cadete = () => {

    const navigate = useNavigate();
    const {
        db,
        url,
        setUrl,
        dataToEdit,
        setDataToEdit,
        loading,
        createData,
        deleteData,
        updateData,
    } = React.useContext(GlobalContext)

    setUrl("/api/cadete")

    const handelRedirect = (id) => {
        navigate("/TomarPedido", { state: { id } })
    }
    const handelRedirectTo = (id) => {
        //pedido cancelado/completado
        navigate("/actionPedido", { state: { id } })
    }

    return (
        <>
            <div className="col-sm-12 d-flex justify-content-center bg-dark">
                <h1 className="text-center text-white ">Seccion de cadetes</h1>.
            </div>

            {loading && <Loader />}
            {db && (
                <div className="table-responsive-md mt-5">
                    <table className='table ' aria-labelledby="tabelLabel">
                        <thead className="table-borderless bg-dark bg-gradient">
                            <tr className=" text-white">
                                <th>Nombre</th>
                                <th>Direccion</th>
                                <th>Telefono</th>
                                <th>Asignar pedido</th>
                                <th>Completar/Cancelar</th>
                                <th>Actualizar</th>
                                <th>Borrar</th>
                            </tr>
                        </thead>
                        <tbody>
                            {db.length > 0 ?
                                (db.map((data) =>
                                    <tr key={data.nombreCad}>
                                        <td>{data.nombreCad}</td>
                                        <td>{data.direccion}</td>
                                        <td>{data.telefono}</td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => handelRedirect(data.id_cadete)}>Obtener</button>
                                        </td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => handelRedirectTo(data.id_cadete)}>Completar/Cancelar</button>
                                        </td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => setDataToEdit(data)}>Editar</button>
                                        </td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => deleteData(data.id_cadete)}>Eliminar</button>
                                        </td>
                                    </tr>
                                )) : (
                                    <tr>
                                        <td colSpan="6">Sin datos</td>
                                    </tr>
                                )}
                        </tbody>
                    </table>
                </div>
            )}
            <Form
                InitialForm={InitialForm}
                createData={createData}
                updateData={updateData}
                dataToEdit={dataToEdit}
                setDataToEdit={setDataToEdit}
                url={url}
            />
        </>
    );
}

export default Cadete;