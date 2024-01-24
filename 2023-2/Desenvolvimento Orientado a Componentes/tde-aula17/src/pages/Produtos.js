import { useContext, useEffect, useState } from "react"
import Header from "../components/Header"
import styles from "./Produtos.css"
import { useNavigate } from "react-router-dom"
import {ProductContext} from "../contexts/productContext"
import useFetch from "../hooks/useFetch"
import Slider from 'react-slick';
import 'slick-carousel/slick/slick.css';
import 'slick-carousel/slick/slick-theme.css';

function Produtos(){

    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 4,
        slidesToScroll: 4,

      };

    //const [products, setProducts] = useState();
    
    const [data, request] = useFetch("http://localhost:3001/products")
    const productContext = useContext(ProductContext)
    productContext.setProduct(data)

    const navigate = useNavigate()

    useEffect(()=>{

        request()
        // const fetchProducts = async() =>{
        // const result  = await fetch("http://localhost:3001/products") 
        // const products = await result.json()
        // setData(products)
        // productContext.setProducts(products)
        // }
        // fetchProducts()
        
    }, [request])

    function handleClick(id){
        navigate(`${id}`)
    }


    return(
        
        <div>
            <Header/>
            <h1>Produtos</h1>
            
            <Slider {...settings}>
                {data && data.map((product) =>{
                    return <div className="cardProduto" > 
                    <img src={product.photo_url} onClick={() => handleClick(product.id)} alt=""/> 
                        <div className="productContent">
                            <h1 onClick={() => handleClick(product.id)}>{product.name} </h1>
                            <p>R${product.price}</p>
                        </div>
                    </div>
                })}
            </Slider>    
            
        </div>
    )
}

export default Produtos;