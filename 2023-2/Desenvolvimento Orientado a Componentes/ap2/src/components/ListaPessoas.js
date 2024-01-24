import React from 'react';
import styles from './ListaPessoas.css';

function ListaPessoas({ pessoas }) {
  // Ordenar o array de pessoas em ordem alfabética pelo nome
  const pessoasOrdenadas = pessoas.sort((a, b) => a.nome.localeCompare(b.nome));

  return (
    <div className='container-lista-pessoas'>
      <h1 className='pessoas-title'>Pessoas Cadastradas:</h1>
      <div className="lista-pessoas">
        {pessoasOrdenadas.map((pessoa, index) => (
          <div key={index} className="card">
            <img className='img-pessoa' src={pessoa.foto} alt='foto-perfil'/>
            <h2>{pessoa.nome}</h2>
            <p>Telefone: {pessoa.telefone}</p>
            <p>Tipo: {pessoa.tipo}</p>
            <p>Pago: {pessoa.pago}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default ListaPessoas;
