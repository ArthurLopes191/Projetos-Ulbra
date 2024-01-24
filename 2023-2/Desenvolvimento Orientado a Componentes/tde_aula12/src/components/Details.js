import { useState } from "react"

function Details({description}){
    const [enable, setEnable] = useState(false)

    function handleClickEnableDetails(){
        setEnable(!enable)
    }
    return(
        <div>
            {enable && <p>{description}</p>}
            <button onClick={handleClickEnableDetails}>{enable ? "Hide details" : "Show details"}</button>
        </div>

    )
}

export default Details