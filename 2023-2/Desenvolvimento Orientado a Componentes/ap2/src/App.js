import './App.css';
import React, { useState } from 'react';
import Header from './components/Header';
import Localizacao from './components/Localizacao';
import Formulario from './components/Formulario';
import ListaPessoas from './components/ListaPessoas';
import MensagemBoasVindas from './components/MensagemBoasVindas';

function App() {
  const [pessoas, setPessoas] = useState([]);
  const [nomePessoa, setNome] = useState('');

  const handleCadastro = (novaPessoa) => {
    setPessoas([...pessoas, novaPessoa]);
    setNome(novaPessoa.nome); 
  };

  return (
    <div className="App">
      <Header/>
      <div className="column-flex">
      <Formulario onCadastro={handleCadastro} />
        <div className="column-flex2">
          <MensagemBoasVindas pessoa={nomePessoa}/>
          <Localizacao/>
          <ListaPessoas pessoas={pessoas} />
        </div>
      
      </div>
    </div>
  );
}

export default App;
