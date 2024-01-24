import './Button.css'

function Button({click, name}){
    return(
        <div className='container-button'>
            <button type="button" onClick={click}>{name}</button>
        </div>
    )
}

export default Button;
