import logo from './logo.svg';
import './App.css';
import { useEffect, useRef } from 'react';

function App() {
  const labelRef = useRef('')
  const inputRef = useRef('')

  useEffect(()=>{
    labelRef.current.innerHTML = "NOME DO USUARIO";
    labelRef.current.style.fontStyle = 'italic'
  }, [])

  const enviarFormulario = (evento) => {
    evento.preventDefault()
    inputRef.current.focus()
  }

  return (
    <div className="App">
      <form onSubmit={enviarFormulario}>
        <div>
            <label ref={labelRef}>Nome</label>
        </div>
        <div>
          <input placeholder='Digite seu nome...' ref={inputRef}/>
        </div>
        <div>
            <label>Email</label>
        </div>
        <div>
          <input placeholder='Digite seu e-mail...' type='email'/>
        </div>
        <button>Salvar</button>
      </form>
    </div>
  );
}

export default App;
