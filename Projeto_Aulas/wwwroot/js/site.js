//Obtendo o valor do parâmetro de qual botão foi clicado
var parametro = new URLSearchParams(window.location.search);
var acaoDoBotao = parametro.get("botao");
if (acaoDoBotao == "Relatorio"){
    window.print();
}

var parametros = new URLSearchParams(window.location.search);
var acaoDoBotao = parametros.get("bot");
if (acaoDoBotao == "Relatorio") {
window.print();
}