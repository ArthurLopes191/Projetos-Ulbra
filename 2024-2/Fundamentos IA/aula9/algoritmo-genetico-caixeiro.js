let cidades = [
    [-5,-5],
    [-2,-3],
    [3,-3],
    [-3,-2],
    [1, 0],
    [4, 2],
    [5, 5],
    [2, 4],
    [-1, 4],
    [-5, 5]
];

const tamanhoPopulacao = 500;
const mutationRate = 0.01;
const geracoes = 1000;

function calculoDistanciaEntrePontos(cidadeA, cidadeB){
    let d = Math.sqrt(Math.pow((cidadeB[0] - cidadeA[0]), 2) +  Math.pow((cidadeB[1] - cidadeA[1]),2));
    return d;
}

function criarIndividuo() {
    let individuo = cidades.slice(); 
    for (let i = individuo.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [individuo[i], individuo[j]] = [individuo[j], individuo[i]];
    }
    return individuo;
}

function criarPopulacao(tamanho){
    const populacao = [];
    for (let i = 0; i < tamanho; i++) {
        populacao.push(criarIndividuo());
    }

    return populacao;
}

function aptidao(individuo){
    let distancia = 0.0;
    for (let i = 0; i < individuo.length; i++) {
        let proximoIndice = i+1;
        if(proximoIndice >=  individuo.length) {
            proximoIndice = 0;
        }

        distancia += calculoDistanciaEntrePontos(individuo[i], individuo[proximoIndice]);
    }
    return 100 / distancia;
}

function selecao(populacao) {
    const torneio = [];
    for (let i = 0; i < 5; i++) {
        const randIndividuo = populacao[Math.floor(Math.random() * populacao.length)];
        torneio.push(randIndividuo);
    }
    torneio.sort((a, b) => aptidao(b) - aptidao(a));
    return [torneio[0], torneio[1]];
}

function cruzamento(individuo1, individuo2) {
    const start = Math.floor(Math.random() * individuo1.length);
    const end = Math.floor(Math.random() * (individuo1.length - start)) + start;

    const filho = individuo1.slice(start, end);
    individuo2.forEach(cidade => {
        if (!filho.includes(cidade)) {
            filho.push(cidade);
        }
    });

    return filho;
}

function mutacao(individuo) {
    for (let i = 0; i < individuo.length; i++) {
        if (Math.random() < mutationRate) {
            const j = Math.floor(Math.random() * individuo.length);
            [individuo[i], individuo[j]] = [individuo[j], individuo[i]];
        }
    }
    return individuo;
}


function algoritmoGenetico() {
    let populacao = criarPopulacao(tamanhoPopulacao);
    let melhorIndividuo = populacao[0];
    let melhorAptidao = aptidao(melhorIndividuo);

    let geracoesSemMudanca = 0;
    const limiteGeracoes = 50; 

    for (let geracao = 0; geracao < geracoes; geracao++) {
        const novaPopulacao = [];
        for (let i = 0; i < populacao.length; i++) {
            const [paiA, paiB] = selecao(populacao);
            let filho = cruzamento(paiA, paiB);
            filho = mutacao(filho);
            novaPopulacao.push(filho);
        }

        populacao = novaPopulacao;

        let novaMelhorAptidao = melhorAptidao;
        populacao.forEach(individuo => {
            const aptidaoIndividuo = aptidao(individuo);
            if (aptidaoIndividuo > novaMelhorAptidao) {
                melhorIndividuo = individuo;
                novaMelhorAptidao = aptidaoIndividuo;
            }
        });

        if (novaMelhorAptidao === melhorAptidao) {
            geracoesSemMudanca++;
        } else {
            melhorAptidao = novaMelhorAptidao;
            geracoesSemMudanca = 0;
        }

        console.log(`Geração ${geracao + 1}, melhor indivíduo: ${JSON.stringify(melhorIndividuo)}, distância: ${(100 / melhorAptidao).toFixed(2)}`);

        if (geracoesSemMudanca >= limiteGeracoes) {
            console.log(`Finalizando após ${geracao + 1} gerações.`);
            break;
        }
    }

    console.log('Melhor rota encontrada:');
    melhorIndividuo.forEach(cidade => console.log(cidade));
    console.log('Distância total:', (100 / melhorAptidao).toFixed(2));
}

algoritmoGenetico();










