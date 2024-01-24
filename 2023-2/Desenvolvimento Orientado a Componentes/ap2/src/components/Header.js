import styles from './Header.css'
import MinhaImagem from '../assets/images/ulbra.jpg';

function Header(){
    return(
        <div className="container-header">
            <img src={MinhaImagem} alt='ulbra-logo'/>
            <h1>Entrevero</h1>
        </div>
    )
}


export default Header