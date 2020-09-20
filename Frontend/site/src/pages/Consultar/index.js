
import React, { useState, useRef } from 'react'
import './index.css'
import ListaNegraAPI from '../services/Listanegra'
import LoadingBar from 'react-top-loading-bar'

const api = new ListaNegraAPI();

export default function Consultar(){
    
    const loadingBar = useRef();

    const[listanegra, setRegistros] = useState([])
    
    const COnsultarClick = async () =>{

        loadingBar.current.continuousStart();

        const lns = await api.Consultar()
        setRegistros([...lns])

        loadingBar.current.complete();
    }

    return(
        <div>   
            <LoadingBar
                height={4}
                color='#f11946'
                ref={loadingBar}
            />

            <header>
                <h1 className="a">Consultar na lista negra</h1>
            </header>

        <div>
            <button onClick = {COnsultarClick}> Consultar</button>
        </div>

            <div>
                <table className="table">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Nome</th>
                            <th>Motivo</th>
                            <th>Inclusao</th>
                        </tr>
                    </thead>

                    <tbody>

                        {listanegra.map(item =>
                            <tr key={item.id}>
                                <th># {item.id} </th>
                                <td> {item.nome} </td>
                                <td> {item.motivo} </td>
                                <td> {new Date(item.inclusao).toLocaleString() } </td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        </div>
    )
}