

import React, { useState } from 'react'


import { ToastContainer, toast} from "react-toastify";
import 'react-toastify/dist/ReactToastify.css';

import ListaNegraApi from '../services/Listanegra';
const api = new ListaNegraApi();

function Cadastrar(){

    
    const   [nome,setNome] = useState('')
    const   [motivo,setMotivo] = useState('')

    const salvarClick = async() =>{

        const resp = await 
            api.Cadastrar(
                {
                    nome:nome,
                    motivo:motivo
                }
            )

        toast.success('🚀 Salvo com sucesso')
    }

    return(
        <div>
            
            
            <header>
                <h1>Cadastrar na lista negra</h1>
            </header>

            <div>
                <label>Nome:</label>
                <input type="text" value={nome} onChange={e => setNome(e.target.value)}></input>
            </div>
            <div>
                <label>Motivo:</label>
                <input type="text" value={motivo} onChange={e => setMotivo(e.target.value)}></input>
            </div>

            <button onClick={salvarClick}>Cadastrar</button>

            <ToastContainer />

        </div>


    )

}

export default Cadastrar;