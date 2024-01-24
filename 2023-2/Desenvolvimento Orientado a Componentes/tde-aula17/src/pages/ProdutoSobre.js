import { useContext, useEffect, useState } from "react";
import { Link, useParams } from "react-router-dom";
import {ProductContext} from "../contexts/productContext"
import styles from "./ProdutosSobre.css"
import Header from "../components/Header";

function ProdutoSobre(){
    const parms = useParams()
    const [data, setData] = useState([])
    const productContext = useContext(ProductContext)

    useEffect(()=>{
        
        // const fetchProducts = async() =>{
        // const result  = await fetch("http://localhost:3001/products")
        // const products = await result.json()

         const produtoClicado = productContext.products.filter((product)=> product.id == parms.id)

         setData(produtoClicado[0])
        // }
        // fetchProducts()
        
    }, [])

    return(
        <>
        {data &&
            <div>
                <Header/>
                <div className="containerCard" >
                    <div className="cardSobre">
                        <img src={data.photo_url}/>
                        <h1>Sobre o produto {data.id} - {data.name} - R${data.price}</h1>
                        <h1>{data.description}</h1>
                        <Link className="linkVoltar" to="/produtos">Voltar</Link>
                    </div>
                </div>
            </div>
            
        }
        
        </>
    )
}

export default ProdutoSobre;