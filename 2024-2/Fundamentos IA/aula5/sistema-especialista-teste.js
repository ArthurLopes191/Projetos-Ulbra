const perguntas = [
    {
        pergunta: "É Homem?",
        subElemento: {
            sim: {
                pergunta: "Ele joga futebol?",
                subElemento: {
                    sim: {
                        pergunta: "Ele é do Brasil?",
                        subElemento: {
                            sim: "Neymar",
                            nao: "Messi"
                        }
                    },
                    nao: {
                        pergunta: "Ele é piloto profissional?",
                        subElemento: {
                            sim: "Airton Senna",
                            nao: {
                                pergunta: "Ele é cantor?",
                                subElemento: {
                                    sim: "Michael Jackson",
                                    nao: "Leonardo DiCaprio"
                                }
                            }
                        }
                    }
                }
            }
        }
    },
    {
        pergunta: "É Mulher?",
        subElemento: {
            sim: {
                pergunta: "Ela é modelo?",
                subElemento: {
                    sim: "Gisele Bündchen",
                    nao: "Margot Robbie"
                }
            }
        }
    },
    {
        pergunta: "É Personagem animado?",
        subElemento: {
            sim: {
                pergunta: "Ele é do Dragon Ball?",
                subElemento: {
                    sim: "Goku",
                    nao: "Naruto"
                }
            }
        }
    },
    {
        pergunta: "É um animal?",
        subElemento: {
            sim: {
                pergunta: "Ele late?",
                subElemento: {
                    sim: "Cachorro",
                    nao: "Gato"
                }
            },
            nao: "Ratiou no que eu pedi"
        }
    }
];

arrayDeRespostasPossiveis = ["Neymar", "Messi", "Airton Senna", "Michael Jackson", "Leonardo DiCaprio", "Gisele Bunchen", "Margot Robbie", "Goku", "Naruto", "Cachorro", "Gato"];

//Informa ao usuário para ele pensar em uma das opções válidas
console.log("Pense em uma das opções abaixo para eu tentar adivinhar");
arrayDeRespostasPossiveis.forEach(resposta => {
    console.log(resposta);
});

const { resolve } = require('path');
//motor de inferencia
const readline = require('readline');

const respostaInterface = readline.createInterface(
    {
        input: process.stdin,
        output: process.stdout
    }
);

async function fazPergunta(pergunta) {
    return new Promise((resolve) => {
        respostaInterface.question(pergunta, (resposta) => {
            resolve(resposta);
        })
    })
}

async function processaNodo(nodo){
    if(typeof nodo === 'string'){
        console.log("A resposta é: " + nodo);
        return true;
    } else if(typeof nodo === 'object' && nodo.pergunta){
        let resposta = await fazPergunta(nodo.pergunta + "(Digite 1 para SIM, 2 para Não)\n");
        if(resposta == 1 && nodo.subElemento && nodo.subElemento.sim){
            return await processaNodo(nodo.subElemento.sim);
        }else if(resposta == 2 && nodo.subElemento && nodo.subElemento.nao){
            return await processaNodo(nodo.subElemento.nao);
        } else {
            return false;
        }
        
    }
}

async function iniciarPerguntas(perguntas) {
    for(const pergunta of perguntas) {
        let resposta = await processaNodo(pergunta);
        if(resposta){
            break;
        }
    }
    respostaInterface.close();
  
}

iniciarPerguntas(perguntas);