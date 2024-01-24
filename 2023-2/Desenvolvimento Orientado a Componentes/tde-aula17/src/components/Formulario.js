import React, { useState } from 'react';
import styles from "./Formulario.css"
import usePost from "../hooks/usePost"


function Formulario() {
  

  const initialFormData = {
    name: '',
    price: '',
    description: '',
    photo_url: ''
  };

  const [formData, setFormData] = useState(initialFormData);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

const HandleSubmit = async (e) => {
    e.preventDefault();
      await usePost(formData);
      setFormData(initialFormData);
  };

    
  return (
    <div className='container'>

    <form className='form-container' onSubmit={HandleSubmit}>
      <h1>Novo Produto</h1>
      <h3>Nome</h3>
      <input className='input-data' type="text" placeholder="Nome" name="name" value={formData.name} onChange={handleChange} required/>

      <h3>Preço</h3>
      <input className='input-data' type="text" placeholder="Preço" name="price" value={formData.price}
          onChange={handleChange} required/>

      <h3>Descrição</h3>
      <input className='input-data' type="text"  placeholder="Descricao"  name="description" value={formData.description}
          onChange={handleChange} required/>

      <h3>Foto</h3>
      <input className='input-data' type="text" placeholder="URL Foto" name="photo_url" value={formData.photo_url}
          onChange={handleChange} required/>
      
      
      
      <button className='buttonEnviar' type="submit">Cadastrar</button>
    </form>
    </div>
  );
}

export default Formulario;
