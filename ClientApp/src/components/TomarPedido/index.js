import React from "react"
import { GlobalContext } from "../../ApiContext";
import Loader from "../Loader";
import { useLocation, useNavigate } from "react-router-dom";


const TomarPedido = () => {
    const { state } = useLocation();

    const nav = useNavigate();

    const {
        db,
        setUrl,
        loading,
        updateWihtUrl,
        createData,
    } = React.useContext(GlobalContext)

    setUrl("/api/cadetepedido")

    const Tomar = (id_cadete, data) => {
        delete data.nombre;
        const cp = {
            CadeteForeingKey: id_cadete,
            PedidoForeingKey: data.id_pedido,
        }
        data.estado = "En camino"
        updateWihtUrl(data, "/api/pedido")
        createData(cp);
        nav("/Cadete")
    }

    return (
        <>
            <div className="col-sm-12 d-flex justify-content-center bg-dark">
                <h1 className="text-center text-white ">Lista de pedidos</h1>
            </div>

            {loading && <Loader />}
            {db && (
                <table className='table table-striped w-75 mx-auto' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Obs</th>
                            <th>Estado</th>
                            <th>Cliente</th>
                            <th>Tomar</th>
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
                                        <button className="btn btn-outline-primary" onClick={() => Tomar(state.id, data)}>Tomar</button>
                                    </td>
                                </tr>
                            )) : (
                                <tr>
                                    <td colSpan="5">Sin datos</td>
                                </tr>
                            )}
                    </tbody>
                </table>
            )}
        </>
    )
}
export default TomarPedido;