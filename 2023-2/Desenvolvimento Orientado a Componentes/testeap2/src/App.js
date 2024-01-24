import React, { useState } from 'react';
import FormularioCadastro from './components/FormularioCadastro';
import ListaPessoas from './components/ListaPessoas';
import './App.css'; // Estilos CSS para os cards

function App() {
  const [pessoas, setPessoas] = useState([]);

  const handleCadastro = (novaPessoa) => {
    setPessoas([...pessoas, novaPessoa]);
  };

  return (
    <div className="App">
      <h1>Cadastro de Pessoas</h1>
      <FormularioCadastro onCadastro={handleCadastro} />
      <h2>Pessoas Cadastradas</h2>
      <ListaPessoas pessoas={pessoas} />
    </div>
  );
}

export default App;
