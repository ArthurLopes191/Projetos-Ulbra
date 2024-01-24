import { Link } from "react-router-dom"
import styles from "./Header.css"

function Header({title}){
    return(
        <div className="container-header">       
            <nav>
               <Link className="nav-link" to={"/"}>Home</Link>
               <Link className="nav-link" to={"/produtos"}>Produtos</Link>
               <Link className="nav-link" to={"/contato"}>Cadastrar Produto</Link>
            </nav>
        </div>
    )
}

export default Header