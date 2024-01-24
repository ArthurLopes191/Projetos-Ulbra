function calcImc(){
    var name = document.getElementById('name').value;
    var gender = document.getElementById('gender').value;
    var weight = parseFloat(document.getElementById('weight').value);
    var height = parseFloat(document.getElementById('height').value);

    var imc = weight / (height^2);
    var term;
    if(gender == 'm'){
        term = 'Sr.'
    }else if(gender == 'f'){
        term = 'Sra.'
    }

    var divResult = document.getElementById('result')
    if(imc < 18.5){
        divResult.innerHTML = `${term}  ${name} você está abaixo do peso.`;
        divResult.className = 'alert alert-warning';
    }else if(imc >= 18.5 && imc < 25){
        divResult.innerHTML = `${term} ${name} você está no peso ideal.` ;
        divResult.className = 'alert alert-success';
    }else if(imc >= 25 && imc <30){
        divResult.innerHTML = `${term} ${name} você está acima do peso.` ;
        divResult.className = 'alert alert-warning';
    }else if(imc >= 30){
        divResult.innerHTML = `${term} ${name} você está com sobrepeso.` ;
        divResult.className = 'alert alert-danger';
    }
    
}