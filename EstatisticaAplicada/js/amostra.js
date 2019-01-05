//FUNÇÃO LIMPAR
function limpar(){//FUNÇÃO RETORNA OS VALORES DE TODOS OS CAMPOS PARA NULL
	document.getElementById("populacao").value = "";
	document.getElementById("amostra").value = "";
	document.getElementById("extratos").value = "";
	document.getElementById("resultado").value = "";
	document.getElementById("escolha").value = "";
	document.getElementById("a").checked = true;

    $('html, body').animate({scrollTop:0}, 'fast');
}



//FUNÇÂO VERIFICAÇÂO
function verificacao(){

	//EXIBIRA MENSAGEM DE ERRO QUANDO UMA DA OPÇÕES ESTRATIFICADA ESTIVEREM SELECIONADAS
	if(document.getElementById("b").checked || document.getElementById("c").checked){
		if(document.getElementById("populacao").value == "" || document.getElementById("extratos").value == ""){
			alert("Preencha todos os dados");
			return 0;
		}	

	}
	//EXIBIRA MENSAGEM DE ERRO QUANDO A OPÇAO ALEATORIO OU SISTEMATICA SELECIONADA
	else{
		if(document.getElementById("populacao").value == "" || document.getElementById("amostra").value == ""){
			alert("Preencha todos os dados");
			return 0;
		}
	}
}

//FUNÇÃO ESTRATIFICADA UNIFORME
function estratificada(){	
	controleDosDados();
	controleLista3();
}

//FUNÇÃO SISTEMATICA
function sistematica(){
	controleLista2();
	//VARIAVEIS
	var populacao = document.getElementById("populacao").value;
	var amostra = document.getElementById("amostra").value;
	var intervalo = parseInt(populacao) / parseInt(amostra);
	var nInicial = document.getElementById("escolha").value;
	var tabela = new Array();//OBJETO HTML
	var resultado = new Array();
	var i;

	//INICIALIZAÇÃO DO VETOR RESULTADO COM O NUMERO DIGITADO PELO USUARIO
	resultado[0] = nInicial;

	//OBTENÇÃO DOS NUMEROS
	for(i = 1; i < amostra; i++){
		nInicial = parseInt(nInicial) + parseInt(intervalo);
		resultado[i] = nInicial;
	}

	//INICIO DA TABELA
	tabela.push("<table id='tabelaSistematica' class='heavyTable table-hover'>",
					"<tr>",
						"<th>Quantidade</th>",
						"<th>Codigo</th>",						
					"</tr>"
	);

	//MEIO DA TABELA
	for(i = 0; i< resultado.length; i++){
		tabela.push("<tr>",
						"<td>"+(i+1)+"</td>",
						"<td>"+resultado[i]+"</td>",						
					"</tr>"
		);
	}

	//FIM DA TABELA
	tabela.push("</table>");
	document.getElementById("resultado").innerHTML = tabela.join("\n");
}

//FUNÇÃO ALEATORIA
function aleatoria(){//FUNÇÃO GERA UM NUMERO ALEATORIO NO INTERVALO DE 1 AO NUMERO DA AMOSTRA
	controleLista2();
	var populacao = document.getElementById("populacao").value;
	var amostra = document.getElementById("amostra").value;
	var tabela = new Array();//OBJETO HTML
	var numerosAleatorios = new Array();//VETOR QUE ARMAZENA OS NUMEROS ALEATORIOS

	numerosAleatorios = gerarAleatorios(amostra, populacao);
	
	//INICIO DA TABELA
	tabela.push("<table id='tabelaAleatoria' class='heavyTable table-hover'>",
					"<tr>",
						"<th>Quantidade</th>",
						"<th>Codigo</th>",						
					"</tr>"
	);

	//MEIO DA TABELA
	for(i = 0; i < numerosAleatorios.length; i++){
		tabela.push("<tr>",
						"<td>"+(i+1)+"</td>",
						"<td>"+numerosAleatorios[i]+"</td>",						
					"</tr>"
		);
	}

	//FIM DA TABELA
	tabela.push("</table>");
	document.getElementById("resultado").innerHTML = tabela.join("\n");
}

//FUNÇÂO CONCLUIR
function concluir(){

	if(verificacao() != 0){

		//OPÇAO ALEATORIA SELECIONADA
		if(document.getElementById("a").checked){
			aleatoria();			
		}
		//OPÇÃO ESTRATIFICAD UNIFORME SELECIONADA
		else if(document.getElementById("b").checked){
			estratificada();
		}
		//OPÇÃO ESTRATIFICADA PROPORCIONAL SELECIONADA
		else if(document.getElementById("c").checked){
			estratificada();
		}
		//OPÇÃO SISTEMATICA SELECIONADA
		else if(document.getElementById("d").checked){
			sistematica();
		}

	}

}

//FUNÇÃO MOSTRAR LISTA2
function controleLista2(){
	document.getElementById("lista2").style.display = "";
	document.getElementById("lista1").style.display = "none";
	document.getElementById("lista3").style.display = "none";
}

//FUNÇÃO MOSTRAR LISTA3
function controleLista3(){
	document.getElementById("lista3").style.display = "";
	document.getElementById("lista2").style.display = "none";
	document.getElementById("lista1").style.display = "none";
}

//FUNÇÃO MOSTRA LISTA1
function controleLista1(){	
	document.getElementById("lista1").style.display = "";	
}

//FUNÇÃO MOSTRAR DIV
function mostrarDiv(){

	if(document.getElementById("a").checked){
		document.getElementById("divExtrato").style.display = "none";
		document.getElementById("divEscolha").style.display = "none";
	}
	else if(document.getElementById("b").checked || document.getElementById("c").checked){
		document.getElementById("divExtrato").style.display = "";
		document.getElementById("divEscolha").style.display = "none";
	}
	else if(document.getElementById("d").checked){
		document.getElementById("divEscolha").style.display = "";
		document.getElementById("divExtrato").style.display = "none";
		
	}

}

//FUNÇÃO DADOS EXTRATOS
function add(){//ADICONA INPUTS DENTRO DA DIV DADOS EXTRATOS

	var nome = document.getElementsByName("nomes");
	var i;
	var aux = nome.length;
	var conc = new Array();

	for(i=0;i< aux ;i++){
		conc.push("<input id='input"+i+"' type='text' name='nomes' placeholder='Extrato "+(i+1)+"' class='form-control'/><br />");
	}

	conc.push("<input id='input"+i+"' type='text' name='nomes' placeholder='Extrato "+(i+1)+"' class='form-control'/><br />");
	var elementos = conc.join("");

	document.getElementById("dadosExtratos").innerHTML = elementos;
	document.getElementById("dadosExtratos").style.display = "";
}

//FUNÇÃO CONTROLE DOS DADOS
function controleDosDados(){//FUNÇÃO RESPONSAVEL PELO NUMERO DE INPUTS QUE SERAO CRIADOS

	var i;
	var qtdExtratos = document.getElementById("extratos").value;

	for(i = 1; i < qtdExtratos; i++){
		add();
	}

}

//FUNÇÃO CALCULAR EXTRATOS
function calcularExtratos(){//FUNÇÃO RESPONSAVEL POR CALCULAR QUANTAS PESSOAS DE CADA EXTRATOS FORAM SELECIONADAS
	var i;
	var resultado = document.getElementById("resultado").value;
	var concatenar;
	var novoR = "";

	for(i = 0; i <= document.getElementById("extratos").value; i ++){

		concatenar = document.getElementById("input"+i).value *= resultado;	

		novoR = novoR + "Extrato " + (i+1) + ": " + concatenar + " ";
		document.getElementById("resultado").value = novoR;

		controleLista2();	

	}		
}

//FUNÇÃO RESPOSTA EXTRATIFICADA UNIFORME
function respostaExtratificadUniforme(amostra, nExtratos){//FUNÇÃO RESPONSAVEL POR MOSTRAR O RESULTADO FINAL ESPERADA DA AMOSTRAGEM ESTRATIFICADA UNIFORME
	
	var resposta = 0;
	var resultado = "";	
	var i;

	resposta = amostra / nExtratos;


	for(i = 0; i < document.getElementById("extratos").value; i++){
		resultado = resultado + "Extrato "+ (i + 1) + ": " + resposta.toFixed(2) + "<br />";
		document.getElementById("resultado").innerHTML = resultado;
		controleLista2();
	}

}

//FUNÇÃO RESPOSTA ESTRATIFICADA PROPORCIONAL
function respostaExtratificadaProporcional(amostra){

	var resposta = 0;
	var resultado = "";
	var extrato = 0;
	var i;
	var populacao = document.getElementById("populacao").value;

	resposta = amostra / populacao;

	for(i = 0; i < document.getElementById("extratos").value; i++){
		extrato = parseFloat(document.getElementById("input"+i).value) * resposta;
		resultado = resultado + "Extrato " + (i+1) + ": " + extrato.toFixed(2) + "<br />";
		document.getElementById("resultado").innerHTML = resultado;
		controleLista2();
	}
}

//FUNÇÃO VALIDAÇAO DOS EXTRATOS
function validacaoExtratos(){//FUNÇÃO QUE ÍRA VERIFICAR SE A QTD DOS EXTRATOS E COMPATIVEL COM A AMOSTRA DIGITADA

	var i;
	var amostra = 0;
	var nExtratos = 0;

	nExtratos = document.getElementById("extratos").value;

	amostra = document.getElementById("amostra").value;

	if(document.getElementById("b").checked){
		respostaExtratificadUniforme(amostra, nExtratos);
	}
	else if(document.getElementById("c").checked){
		respostaExtratificadaProporcional(amostra);
	}
}

//FUNÇÕES SECUNDARIAS ----------------------------------------------------------------------------
//FUNÇÃO GERAR NUMEROS ALEATORIOS
function gerarAleatorios(amostra, populacao){	
	var numerosAleatorios = new Array();
	var i = 0;
	var auxNumeros;
	var aux;	

	//INICIALIZAÇÃO DO VETOR DE NUMEROS ALEATORIOS
	numerosAleatorios[i] = Math.floor((Math.random() * populacao) + 1);
	i++;

	//GERA NUMERO ALEATORIOS SEM REPETIÇÃO
	while(numerosAleatorios.length < amostra){
		auxNumeros = Math.floor((Math.random() * populacao) + 1);

		for(j = 0; j < numerosAleatorios.length; j++){
			if(auxNumeros == numerosAleatorios[j]){
				aux = 1;
			}
		}

		if(aux != 1){
			numerosAleatorios[i] = auxNumeros;
			i++;
		}

		aux = 0;
	}


	return numerosAleatorios;
}

//FUNÇAO CHAMAR SERIES ESTATISTICAS
function chamarSeries(){
	window.self.location.href = "seriesEstatisticas.html";
}

//FUNÇÃO CHAMAR INDEX
function chamarIndex(){
	window.self.location.href = "index.html";
}