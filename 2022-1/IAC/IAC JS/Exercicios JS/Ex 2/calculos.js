//converter decimal para qualquer base


//como faz apra transforar de decimal pra binário?

//10 -> 1010
//10 dividendo
//10/2 = 5  e descborir o resto desta divisão
//guardar o novo quociente
//guardar o resto da divisão e ir concatenando cada resto
// no final eu tenho que inverter o resutado da concatenação
//alerta: temos q considerar somente números inteiros
//dividendo = 10
//result = 0101
function decimalToBinary(numero, base){
  var dividendo =  numero;
  var result = "";
  var i = 0;
  var resto = 0;

  while (i == 0) {
      resto = parseInt(dividendo) % base;
      //console.log(resto);
      if(base === 16){
          resto = decimalToHex(resto)
      }

      result += resto.toString();
      dividendo = parseInt(dividendo / base);
    
      if(dividendo < base){
          i++;
          result+=decimalToHex(dividendo); //Essa aqui
      }
  }
   return reverse(result);
}
function reverse(result){
 var arr = result.split('');
 var resultFinal = '';
 for(i = arr.length - 1; i >= 0; i-- ){
  resultFinal += arr[i];
 }

return resultFinal; 
}

function decimalToHex(num){
  console.log(num);
  var valor = 0;
  switch (num) {
      case 10:
          valor= 'A';
          break;
      case 11:
          valor= "B";
          break;
      case 12:
          valor= "C";
          break;
      case 13:
          valor= "D";
          break;
      case 14:
          valor= "E";
          break;
      case 15:
          valor= "F";
          break;
      default:
          valor = num;
  }

  return valor;
}