import React from 'react';

function ListaPessoas({ pessoas }) {
  return (
    <div className="lista-pessoas">
      {pessoas.map((pessoa, index) => (
        <div key={index} className="card">
          <h2>{pessoa.nome}</h2>
          <p>Telefone: {pessoa.telefone}</p>
          <p>Tipo: {pessoa.tipo}</p>
          <p>Pago: {pessoa.pago}</p>
        </div>
      ))}
    </div>
  );
}

export default ListaPessoas;
