import React from "react"
import { GlobalContext } from "../../ApiContext";
import Loader from "../Loader";
import { useNavigate } from "react-router-dom";

const Pedido = () => {
    const navigate = useNavigate();

    const {
        db,
        setUrl,
        loading,
        deleteData,
    } = React.useContext(GlobalContext)

    setUrl("/api/pedido")

    const HandelEdit = (data) => {
        delete data.nombre
        navigate("/formPedido", { state: { data } })
    }

    return (
        <>
            <div className="col-sm-12 d-flex justify-content-center bg-dark">
                <h1 className="text-center text-white">Seccion de pedidos</h1>
            </div>

            {loading && <Loader />}
            {db && (
                <div className="table-responsive-md mt-5">
                    <table className='table ' aria-labelledby="tabelLabel">
                        <thead className="table-borderless bg-dark bg-gradient">
                            <tr className=" text-white">
                                <th>Obs</th>
                                <th>Estado</th>
                                <th>Cliente</th>
                                <th>Editar</th>
                                <th>Eliminar</th>
                            </tr>
                        </thead>
                        <tbody>
                            {db.length > 0 ?
                                (db.map((data) =>
                                    <tr key={data.obs}>
                                        <td>{data.obs}</td>
                                        <td>{data.estado}</td>
                                        <td>{data.nombre}</td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => HandelEdit(data)}>Editar</button>
                                        </td>
                                        <td>
                                            <button className="btn btn-outline-primary" onClick={() => deleteData(data.id_pedido)}>Eliminar</button>
                                        </td>
                                    </tr>

                                )) : (
                                    <tr>
                                        <td colSpan="5">Sin datos</td>
                                    </tr>
                                )}
                        </tbody>
                    </table>
                </div>
            )}
        </>
    )
}
export default Pedido;