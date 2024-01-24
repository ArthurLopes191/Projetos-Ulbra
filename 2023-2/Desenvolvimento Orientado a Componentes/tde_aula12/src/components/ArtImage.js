import './ArtImage.css'

function ArtImage({urlImage, alt}){
    return(
        <div>
            <img src={urlImage} alt={alt}/>
        </div>
    )
}

export default ArtImage