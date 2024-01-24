import React, { useState } from 'react';
import styles from "./Formulario.css"

function Formulario({ onCadastro }) {
  const [nome, setNome] = useState('');
  const [telefone, setTelefone] = useState('');
  const [tipo, setTipo] = useState('');
  const [pago, setPago] = useState(''); 
  const [foto, setFoto] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    // Validar e salvar os dados
    if (nome && telefone && tipo && pago && foto) {
      onCadastro({ nome, telefone, tipo, pago, foto });
      setNome('');
      setTelefone('');
      setTipo('');
      setPago('');
      setFoto('');
    }
  };

  return (
    <div className='container'>
    <h1>Cadastro de Pessoas</h1>

    <form className='form-container' onSubmit={handleSubmit}>

      <h3>Nome</h3>
      <input className='input-data' type="text" placeholder="Nome" value={nome} onChange={(e) => setNome(e.target.value)}/>

      <h3>Telefone</h3>
      <input className='input-data' type="tel" placeholder="Telefone" value={telefone} onChange={(e) => setTelefone(e.target.value)}/>
      
      <div className='container-input-radio'>
        <h3>Aluno</h3>
        <label>
          <input className='input-radio' type="radio" value="Egresso" checked={tipo === 'Egresso/Convidado'} onChange={() => setTipo('Egresso/Convidado')}/> Egresso/Convidado
        </label>
        <label>
          <input className='input-radio' type="radio" value="Convidado" checked={tipo === 'Aluno'} onChange={() => setTipo('Aluno')}/>Aluno
        </label>
        <h3>Pago</h3>
        <label>
          <input className='input-radio' type="radio" value="Sim" checked={pago === 'Sim'} onChange={() => setPago('Sim')}/>Sim
        </label>
        <label>
            <input className='input-radio' type="radio" value="Nao" checked={pago === 'Nao'} onChange={() => setPago('Nao')}/>Não
        </label>
        <h3>Foto</h3>
        <label>
            <input  className='input-data' type="url" placeholder='URL' value={foto} onChange={(e) => setFoto(e.target.value)}/>
        </label>
      </div>
      
      <button className='buttonEnviar' type="submit">Cadastrar</button>
    </form>
    </div>
  );
}

export default Formulario;
