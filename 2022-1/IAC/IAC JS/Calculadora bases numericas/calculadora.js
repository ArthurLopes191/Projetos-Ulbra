
/*
function binaryToDecimal(numero){
  var arrNumero = numero.split('');
  var posicao = arrNumero.length-1;
  var resultFormulaNoAlgarismo = 0 ;
  var resultFinal = 0;


  for(var i = 0 ; i < arrNumero.length ; i++){
    resultFormulaNoAlgarismo = (arrNumero[i] * (2  ** posicao));
    resultFinal = resultFinal + resultFormulaNoAlgarismo;
    posicao--;
  }

  return resultFinal;
}
*/


function convertToDecimal(numero, base){
  var posicao = 0;
  var resultFormulaNoAlgarismo = 0 ;
  var resultFinal = 0;
  var numeroReal = 0;

  var arrNumero = numero.split('');
  posicao = arrNumero.length-1;

  for(var i = 0 ; i < arrNumero.length ; i++){
    if(isNaN(arrNumero[i]))
      numeroReal = hexadecimalToDecimal(arrNumero[i]);
    else
      numeroReal = arrNumero[i];
    resultFormulaNoAlgarismo = (numeroReal * (base  ** posicao));
    resultFinal = resultFinal + resultFormulaNoAlgarismo;
    posicao--;
  }

  return resultFinal;
}

function hexadecimalToDecimal(letra){
  console.log(letra);
  var valor = 0;
  switch (letra) {
    case "A":
        valor = 10;
    break;

    case "B":
      valor=11;
    break;

    case "C":
      valor=11;
    break;

    case "D":
      valor=11;
    break;

    case "E":
      valor=11;
    break;

    case "F":
      valor=11;
    break;
          

      
    default:
      break;
  }

  return valor;
}