import React from "react"
import { GlobalContext } from "../../ApiContext";
import Loader from "../Loader";
import { useLocation, useNavigate } from "react-router-dom";


const ActionPedido = () => {
    const { state } = useLocation();
    const {
        db,
        setUrl,
        loading,
        CreateWihtUrl,
        updateWihtUrl,
        deleteWihtUrl
    } = React.useContext(GlobalContext)

    setUrl("/api/cadetepedido/action")
    const nav = useNavigate();

    const Entregar = (data) => {
        delete data.nombre;
        delete data.id_cadPed
        data.estado = "Entregado"
        const CC = {
            CadeteForeingKey: state.id,
            ClienteForeingKey: data.clienteForeingKey,
        }

        CreateWihtUrl(CC, "api/cadetecliente")
        updateWihtUrl(data, "api/pedido")
        nav("/Cadete")
    }
    const Cancelar = (data) => {
        let isDelete = window.confirm(
            `¿Estás seguro de cancelar el pedido con el id '${data.id_cadPed}'?`
        );
        if (isDelete) {
            deleteWihtUrl(data.id_cadPed, "/api/cadetepedido")

            delete data.nombre;
            delete data.id_cadPed
            data.estado = "Pendiente"

            updateWihtUrl(data, "api/pedido")
            nav("/Cadete")
        } else {
            return;
        }
    }

    return (
        <>
            <div className="col-sm-12 d-flex justify-content-center bg-dark">
                <h1 className="text-center text-white">Lista de pedidos</h1>
            </div>
            {loading && <Loader />}
            {db && (
                <table className='table table-striped w-75 mx-auto' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Obs</th>
                            <th>Estado</th>
                            <th>Cliente</th>
                            <th>Entregar/Cancelar</th>
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
                                        <button className="btn btn-outline-primary" onClick={() => Entregar(data)}>Entregar</button>
                                        <button className="btn btn-outline-primary" onClick={() => Cancelar(data)}>Cancelar</button>
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
export default ActionPedido;