import { useState } from 'react';
import styles from './Localizacao.css'

function Localizacao(){
    const [enable, setEnable] = useState(false)
    const [endereco, setEndereco] = useState({})


    function handleClickEnableDetails(){
        fetch('https://viacep.com.br/ws/95560000/json/')
        .then(response => response.json()) //função callback
        .then(data => {
    
        setEndereco(data);
      })
        setEnable(!enable)
    }
    
    
    return(
        <div className="localizacao">
            
            <button className='buttonLocalizacao' onClick={handleClickEnableDetails}>Localização</button>
            {enable &&
                <div className='dadosEndereco'>
                    <h2>CEP: {endereco.cep}</h2>
                    <h2>Cidade: {endereco.localidade} {endereco.uf}</h2>
                    <h2>Rua: Av. Castelo Branco</h2>
                    <h2>N°: 1187</h2>
                    <h2>Bairro: Centro</h2>
                    <h2>Horario: 20h</h2>
                </div>
            }
        </div>

    )
}

export default Localizacao;