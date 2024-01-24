function calc(){
    var num1 = parseFloat(document.getElementById('num1').value);
    var num2 = parseFloat(document.getElementById('num2').value);

    var soma = somaValue(num1, num2);
    var sub = subValue(num1, num2);
    var mult = multValue(num1, num2);
    var div = diValue(num1, num2);

    var select = document.getElementById('op');
    var op = select.options[select.selectedIndex].value;

    if(op =='+'){
        document.getElementById('res').innerHTML = `<br>O resultado da soma é ${soma}`;
    }
    else if(op == '-'){ 
        document.getElementById('res').innerHTML = `<br>O resultado da subtração é ${sub}`;
    } 
    else if(op == '*'){ 
        document.getElementById('res').innerHTML = `<br>O resultado da multiplicação é ${mult}`;
    } 
    else if(op == '/'){ 
        document.getElementById('res').innerHTML = `<br>O resultado da divisão é ${div}`; 
    }
}


function somaValue(p1, p2){
    return p1 + p2;
}
function subValue(p1, p2){
    return p1 - p2;
}

function multValue(p1, p2){
    return p1 * p2;
}

function diValue(p1, p2){
    return p1 / p2;
}
