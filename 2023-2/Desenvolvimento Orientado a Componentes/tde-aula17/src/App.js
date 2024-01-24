import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Home from './pages/Home';
import Produtos from './pages/Produtos';
import Contato from './pages/Contato';
import ProdutoSobre from './pages/ProdutoSobre';
import { useState } from 'react';
import {ProductContext} from './contexts/productContext';

function App() {

  const [products, setProduct] = useState()

  

  return (
    <ProductContext.Provider value={{products, setProduct}}>
    <div className='App'>
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home/>}/>
        <Route path='/produtos' element={<Produtos/>}/>
        <Route path='/produtos/:id/*' element={<ProdutoSobre/>}/>
        <Route path='/contato' element={<Contato/>}/>
      </Routes>
    </BrowserRouter>
    </div>
    </ProductContext.Provider>

  );
}

export default App;
