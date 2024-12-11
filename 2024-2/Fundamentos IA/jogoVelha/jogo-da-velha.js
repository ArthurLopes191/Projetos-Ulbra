const prompt = require("prompt-sync")();

function inicializarTabuleiro() {
    return [" ", " ", " ", " ", " ", " ", " ", " ", " "];
}

function mostrarTabuleiro(tabuleiro) {
    console.clear();
    console.log(`${tabuleiro[0]} | ${tabuleiro[1]} | ${tabuleiro[2]}`);
    console.log("--+---+--");
    console.log(`${tabuleiro[3]} | ${tabuleiro[4]} | ${tabuleiro[5]}`);
    console.log("--+---+--");
    console.log(`${tabuleiro[6]} | ${tabuleiro[7]} | ${tabuleiro[8]}`);
}

function checarVitoria(tabuleiro, jogador) {
    const combinacoesDeVitoria = [
        [0, 1, 2], [3, 4, 5], [6, 7, 8],
        [0, 3, 6], [1, 4, 7], [2, 5, 8],
        [0, 4, 8], [2, 4, 6]
    ];
    return combinacoesDeVitoria.some(combinacao => combinacao.every(indice => tabuleiro[indice] === jogador));
}

function movimentosRestantes(tabuleiro) {
    return tabuleiro.includes(" ");
}

function avaliarEstado(tabuleiro) {
    let score = 0;
    const linhas = [
        [0, 1, 2], [3, 4, 5], [6, 7, 8],
        [0, 3, 6], [1, 4, 7], [2, 5, 8],
        [0, 4, 8], [2, 4, 6]
    ];
    linhas.forEach(([a, b, c]) => {
        if (tabuleiro[a] === "X" && tabuleiro[b] === "X" && tabuleiro[c] === " ") score += 10;
        if (tabuleiro[a] === "O" && tabuleiro[b] === "O" && tabuleiro[c] === " ") score -= 10;
    });
    return score;
}

function minimax(tabuleiro, profundidade, isMaximizando, alpha, beta) {
    if (checarVitoria(tabuleiro, "X")) return 10 - profundidade;
    if (checarVitoria(tabuleiro, "O")) return profundidade - 10;
    if (!movimentosRestantes(tabuleiro)) return 0;

    let melhorValor = isMaximizando ? -Infinity : Infinity;
    for (let i = 0; i < 9; i++) {
        if (tabuleiro[i] === " ") {
            tabuleiro[i] = isMaximizando ? "X" : "O";
            const valor = minimax(tabuleiro, profundidade + 1, !isMaximizando, alpha, beta);
            tabuleiro[i] = " ";
            melhorValor = isMaximizando ? Math.max(melhorValor, valor) : Math.min(melhorValor, valor);
            if (isMaximizando) alpha = Math.max(alpha, melhorValor);
            else beta = Math.min(beta, melhorValor);
            if (beta <= alpha) break;
        }
    }
    return melhorValor;
}

function melhorMovimento(tabuleiro) {
    let melhorValor = -Infinity;
    let movimento = -1;
    for (let i = 0; i < 9; i++) {
        if (tabuleiro[i] === " ") {
            tabuleiro[i] = "X";
            const valor = minimax(tabuleiro, 0, false, -Infinity, Infinity);
            tabuleiro[i] = " ";
            if (valor > melhorValor) {
                melhorValor = valor;
                movimento = i;
            }
        }
    }
    return movimento;
}

function jogarContraIA() {
    let tabuleiro = inicializarTabuleiro();
    console.log("Você é o 'O' e a IA é o 'X'");
    mostrarTabuleiro(tabuleiro);

    const movimentoIA = melhorMovimento(tabuleiro);
    tabuleiro[movimentoIA] = "X";

    while (true) {

        mostrarTabuleiro(tabuleiro);

        if (!movimentosRestantes(tabuleiro)) {
            console.log("Empate!");
            break;
        }

        let movimentoJogador = parseInt(prompt("Escolha sua posição de (0-8): "));
        while (isNaN(movimentoJogador) || movimentoJogador < 0 || movimentoJogador > 8 || tabuleiro[movimentoJogador] !== " ") {
            console.log("Movimento inválido!");
            movimentoJogador = parseInt(prompt("Escolha sua posição de (0-8): "));
        }

        tabuleiro[movimentoJogador] = "O";
        if (checarVitoria(tabuleiro, "O")) {
            mostrarTabuleiro(tabuleiro);
            console.log("Você venceu!");
            break;
        }

        const movimentoIA = melhorMovimento(tabuleiro);
        tabuleiro[movimentoIA] = "X";
        if (checarVitoria(tabuleiro, "X")) {
            mostrarTabuleiro(tabuleiro);
            console.log("A IA venceu!");
            break;
        }
        mostrarTabuleiro(tabuleiro);
    }
}

jogarContraIA();
