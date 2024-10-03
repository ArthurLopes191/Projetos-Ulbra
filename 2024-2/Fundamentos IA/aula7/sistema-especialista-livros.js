let perguntas = [
    {
        identificador: "preferencia-genero",
        pergunta: "Qual gênero de livro você prefere?",
        respostas: [
            {
                respostaPossivel: "Ficção",
                redireciona: "preferencia-estilo-ficcao"
            },
            {
                respostaPossivel: "Não-ficção",
                redireciona: "preferencia-estilo-nao-ficcao"
            },
            {
                respostaPossivel: "Fantasia",
                redireciona: "preferencia-estilo-fantasia"
            },
            {
                respostaPossivel: "Suspense",
                redireciona: "preferencia-estilo-suspense"
            },
        ]
    },
    {
        identificador: "preferencia-estilo-ficcao",
        pergunta: "Você prefere ficção clássica ou contemporânea?",
        respostas: [
            {
                respostaPossivel: "Clássica",
                resposta: "Recomendação: 'Orgulho e Preconceito' de Jane Austen"
            },
            {
                respostaPossivel: "Contemporânea",
                resposta: "Recomendação: 'O Conto da Aia' de Margaret Atwood"
            },
        ]
    },
    {
        identificador: "preferencia-estilo-nao-ficcao",
        pergunta: "Você prefere biografias ou temas históricos?",
        respostas: [
            {
                respostaPossivel: "Biografias",
                resposta: "Recomendação: 'Steve Jobs' de Walter Isaacson"
            },
            {
                respostaPossivel: "História",
                resposta: "Recomendação: 'Sapiens: Uma Breve História da Humanidade' de Yuval Noah Harari"
            },
        ]
    },
    {
        identificador: "preferencia-estilo-fantasia",
        pergunta: "Você prefere fantasia épica ou urbana?",
        respostas: [
            {
                respostaPossivel: "Épica",
                resposta: "Recomendação: 'O Senhor dos Anéis' de J.R.R. Tolkien"
            },
            {
                respostaPossivel: "Urbana",
                resposta: "Recomendação: 'American Gods' de Neil Gaiman"
            },
        ]
    },
    {
        identificador: "preferencia-estilo-suspense",
        pergunta: "Você prefere mistério policial ou suspense psicológico?",
        respostas: [
            {
                respostaPossivel: "Mistério policial",
                resposta: "Recomendação: 'O Assassinato no Expresso do Oriente' de Agatha Christie"
            },
            {
                respostaPossivel: "Suspense psicológico",
                resposta: "Recomendação: 'Garota Exemplar' de Gillian Flynn"
            },
        ]
    },
    {
        identificador: "preferencia-formato",
        pergunta: "Você prefere ler em formato físico ou digital?",
        respostas: [
            {
                respostaPossivel: "Físico",
                resposta: "Sugestão: procure o livro na livraria mais próxima ou peça pela internet."
            },
            {
                respostaPossivel: "Digital",
                resposta: "Sugestão: Disponível no Kindle ou outra plataforma de e-book."
            },
        ]
    },
    {
        identificador: "fim",
        pergunta: "Fim das recomendações",
        respostas: []
    }
];


const readline = require('readline');
const respostaInterface = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

async function fazPergunta(pergunta) {
    return new Promise((resolve) => {
        respostaInterface.question(pergunta, (resposta) => {
            resolve(resposta);
        })
    })
}

Object.prototype.hasOwnProperty = function(property) {
    return this[property] !== undefined;
};


// Motor de inferência
async function processNode(node) {
    let opcoes = "\n";
    for (let index = 0; index < node.respostas.length; index++) {
        opcoes += index + " - " + node.respostas[index].respostaPossivel + "\n";
    }
    let respostaEscolhida = await fazPergunta(node.pergunta + opcoes);

    

    if (node.respostas[respostaEscolhida].hasOwnProperty('redireciona'))
    {
        let identificador = node.respostas[respostaEscolhida].redireciona;
        if(identificador === 'fim') {
            return false;
        }
        var otherNode = perguntas.find(item => item.identificador == identificador);
        return await processNode(otherNode);
    }

    if (node.respostas[respostaEscolhida].hasOwnProperty('resposta')){
        console.log(node.respostas[respostaEscolhida].resposta);
        return false;
    }
}

async function iniciarPerguntas(perguntas) {
    resposta = await processNode(perguntas[0]);
    respostaInterface.close();

    
}

iniciarPerguntas(perguntas);
