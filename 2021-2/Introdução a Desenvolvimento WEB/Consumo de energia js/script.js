function calc(){
    var qtdKwh = parseFloat(document.getElementById('qtdKwh').value);
    var valorKwh = parseFloat(document.getElementById('valorKwh').value);
    
        var valor = calcConsumo(qtdKwh, valorKwh);
        document.getElementById('res').innerHTML = `<br>O valor do consumo de energia elétrica é R$${valor}`;
    
        if((qtdKwh > '100')&&(qtdKwh < '200')){
            var consumoAcresc = valor * 0.25;
            var valorAcresc = valor + consumoAcresc;
            document.getElementById('res').innerHTML = `<br>O consumo de energia elétrica é R$${valorAcresc}`;
        }
        else if(qtdKwh > '200'){
            var consumoAcresc = valor * 0.50;
            var valorAcresc = valor + consumoAcresc;
            document.getElementById('res').innerHTML = `<br>O consumo de energia elétrica é R$${valorAcresc}`;
        }
    }
    
    
    function calcConsumo(p1, p2){
        return p1 * p2;
    }
    
    
