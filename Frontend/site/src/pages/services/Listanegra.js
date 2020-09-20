
import axios from 'axios'

const api = axios.create({
    baseURL: 'http://localhost:5000'
})


export default class ListaNegraAPI{


    async Cadastrar(ln){
        const x = await api.post('/listanegra', ln);
        return x;
    }

    async Consultar(){
        const x = await api.get('/listanegra');
        return x.data;
    }

}