import React, { useState } from 'react';

function FormularioCadastro({ onCadastro }) {
  const [nome, setNome] = useState('');
  const [telefone, setTelefone] = useState('');
  const [tipo, setTipo] = useState(''); // "Egresso" ou "Convidado"
  const [pago, setPago] = useState(''); // "Sim" ou "Nao"

  const handleSubmit = (e) => {
    e.preventDefault();
    // Validar e salvar os dados
    if (nome && telefone && tipo && pago) {
      onCadastro({ nome, telefone, tipo, pago });
      setNome('');
      setTelefone('');
      setTipo('');
      setPago('');
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        type="text"
        placeholder="Nome"
        value={nome}
        onChange={(e) => setNome(e.target.value)}
      />
      <input
        type="tel"
        placeholder="Telefone"
        value={telefone}
        onChange={(e) => setTelefone(e.target.value)}
      />
      <div>
        <label>
          <input
            type="radio"
            value="Egresso"
            checked={tipo === 'Egresso'}
            onChange={() => setTipo('Egresso')}
          />
          Egresso
        </label>
        <label>
          <input
            type="radio"
            value="Convidado"
            checked={tipo === 'Convidado'}
            onChange={() => setTipo('Convidado')}
          />
          Convidado
        </label>
      </div>
      <div>
        <label>
          <input
            type="radio"
            value="Sim"
            checked={pago === 'Sim'}
            onChange={() => setPago('Sim')}
          />
          Sim
        </label>
        <label>
          <input
            type="radio"
            value="Nao"
            checked={pago === 'Nao'}
            onChange={() => setPago('Nao')}
          />
          Não
        </label>
      </div>
      <button type="submit">Cadastrar</button>
    </form>
  );
}

export default FormularioCadastro;
