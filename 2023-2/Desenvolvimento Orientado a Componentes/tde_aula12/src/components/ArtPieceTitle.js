function ArtPieceTitle({title, sizeList, index}){
    return(
        <div>
            <h1>{title}</h1>
            <p>({index} of {sizeList})</p>
        </div>
    )
}

export default ArtPieceTitle