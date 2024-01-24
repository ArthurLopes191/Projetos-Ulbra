import Header from "../components/Header"
import ImgMarmore from '../assets/images/marmore.png';
import Formulario from "../components/Formulario";
import styles from './Contato.css'

function Contato(){

    
        
    return(
        <div>
            <Header/>
            <div className="container-contato">
            <img className="background-img" src={ImgMarmore} alt="img-fundo-marmore"></img>
            <div className="containerForm">
            <Formulario/>
            </div>
            </div>
        </div>  
    )
}

export default Contato;