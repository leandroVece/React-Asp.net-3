import React, { useState } from "react";
import { useAuth } from "../Auth";
import * as bootstrap from 'bootstrap';
import Parte1 from "./parte1";
import Parte2 from "./parte2";
import Parte3 from "./parte3";

const Home = () => {
    const auth = useAuth();

    const triggerTabList = document.querySelectorAll('#myTab button')
    triggerTabList.forEach(triggerEl => {
        const tabTrigger = new bootstrap.Tab(triggerEl)

        triggerEl.addEventListener('click', event => {
            event.preventDefault()
            tabTrigger.show()
        })
    })



    return (
        <>
            <div className="d-flex justify-content-center bg-dark">
                <h1 className="text-center text-white">Proyecto cadeteria con ASP.Net y React.js </h1>.
            </div>
            <h2 className="text-center">Bienvenido {auth.cookies.get('name') ? auth.cookies.get("name") : "inicie sesion para continuar"}</h2>



            {/* <!-- Nav tabs --> */}

            <ul className="nav nav-tabs border-danger" id="myTab" role="tablist">
                <li className="nav-item" role="presentation">
                    <button className="nav-link active" id="parte1-tab" data-bs-toggle="tab" data-bs-target="#parte1" type="button" role="tab" aria-controls="parte1" aria-selected="true">Parte 1</button>
                </li>
                <li className="nav-item" role="presentation">
                    <button className="nav-link" id="parte2-tab" data-bs-toggle="tab" data-bs-target="#parte2" type="button" role="tab" aria-controls="parte2" aria-selected="false">Parte 2</button>
                </li>
                <li className="nav-item" role="presentation">
                    <button className="nav-link" id="parte3-tab" data-bs-toggle="tab" data-bs-target="#parte3" type="button" role="tab" aria-controls="parte3" aria-selected="false">Parte 3</button>
                </li>
            </ul>

            <div className="tab-content">
                <div className="tab-pane active" id="parte1" role="tabpanel" aria-labelledby="parte1-tab" tabindex="0">
                    <Parte1 />
                </div>
                <div className="tab-pane" id="parte2" role="tabpanel" aria-labelledby="parte2-tab" tabindex="0">
                    <Parte2 />
                </div>
                <div className="tab-pane" id="parte3" role="tabpanel" aria-labelledby="parte3-tab" tabindex="0">
                    <Parte3 />
                </div>
            </div>
        </>
    )
}


export default Home;