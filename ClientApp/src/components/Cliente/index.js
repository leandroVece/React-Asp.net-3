import React from "react"
import Form from '../Form';
import { GlobalContext } from "../../ApiContext";
import Loader from "../Loader";
import { useNavigate } from "react-router-dom";

const InitialForm = {
    id: null,
    nombre: "",
    direccion: "",
    telefono: "",
    referencia: ""
}


const Cliente = () => {
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

    setUrl('/api/cliente')

    const handelRedirect = (data) => {
        //hacer un pedido
        navigate("/FormPedido", { state: { data } })
    }

    return (
        <>
            <div className="col-sm-12 d-flex justify-content-center bg-dark">
                <h1 className="text-center text-white">Seccion de clientes</h1>
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
                                <th>Pedido</th>
                                <th>Editar</th>
                                <th>Eliminar</th>
                            </tr>
                        </thead>
                        <tbody>
                            {db.length > 0 ?
                                (db.map((data) =>
                                    <tr key={data.nombre}>
                                        <td>{data.nombre}</td>
                                        <td>{data.direccion}</td>
                                        <td>{data.telefono}</td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => handelRedirect(data)}>Nuevo</button>
                                        </td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => setDataToEdit(data)}>Editar</button>
                                        </td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => deleteData(data.id_cliente)}>Eliminar</button>
                                        </td>
                                    </tr>

                                )) : (
                                    <tr>
                                        <td colSpan="3">Sin datos</td>
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
export default Cliente;