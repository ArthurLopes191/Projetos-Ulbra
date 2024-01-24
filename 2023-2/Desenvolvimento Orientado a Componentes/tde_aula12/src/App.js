import './App.css';
import Button from './components/Button';
import ArtPieceTitle from './components/ArtPieceTitle';
import Details from './components/Details';
import ArtImage from './components/ArtImage';
import { useState } from 'react';
import { data } from "./data";

function App() {
  const [index, setIndex] = useState(0)

  function handleBackClickIndex(){
    if(index - 1 >= 0){
      setIndex(index - 1)
    }
  }
  
  function handleClickIndex(){
    if(index + 1 !== data.length){
      setIndex(index + 1)
    }

   

  }
  let galleryData = data[index]
  return (
    <div className='App'>
     <ArtPieceTitle title={galleryData.name} sizeList={data.length} index={index + 1}/>
     <Details description={galleryData.description}/>
     <ArtImage urlImage={galleryData.url} alt={galleryData.alt}/>
     <Button name="next" click={handleClickIndex}/>
     <Button name="back" click={handleBackClickIndex} />
    </div>
  )
}

export default App;
