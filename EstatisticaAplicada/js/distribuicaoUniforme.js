//FUNÇÂO LIMPAR
function limpar(){	
	$('html, body').animate({scrollTop:0}, 'fast');
	document.getElementById("pontoMinimo").value = "";
	document.getElementById("pontoMaximo").value = "";
	document.getElementById("x").value = "";
	document.getElementById("x1").value = "";
	document.getElementById("y").value = "";
	document.getElementById("pontoEquilibrio").value = "";
	document.getElementById("media").value = "";
	document.getElementById("maximo").value = "";
	document.getElementById("minimo").value = "";
	document.getElementById("a").checked = true;
}

//CALCULOS
//MEDIA
function media(pontoMinimo, pontoMaximo){	
	return (pontoMinimo + pontoMaximo) / 2;
}
//DESVIO PADRAO
function desvioPadrao(pontoMinimo, pontoMaximo){
	return Math.sqrt(Math.pow(pontoMaximo - pontoMinimo, 2) / 12);
}
//PROBABILIDADE DE PREJUIZO EM UM DETERMINADO DIA
function probD(pontoMinimo, pontoMaximo, pontoEquilibrio){
	var intervaloPrejuizo = pontoEquilibrio - pontoMinimo;

	return (intervaloPrejuizo/(pontoMaximo - pontoMinimo)) * 100;
}
//PROBABILIDADE MAIOR QUE UM NUMERO X
function probA(pontoMinimo, pontoMaximo, x){
	var intervalo = pontoMaximo - x;

	return (intervalo/(pontoMaximo - pontoMinimo)) * 100;
}
//PROBABILIDADE MENOR QUE UM NUMERO X
function probB(pontoMinimo, pontoMaximo, x){
	var intervalo = x - pontoMinimo;

	return (intervalo/(pontoMaximo - pontoMinimo)) * 100;
}
//PROBABILIDADE ENTRE UM NUMERO X E UM NUMERO Y
function probC(pontoMinimo, pontoMaximo, x, y){
	var intervalo = y - x;

	return (intervalo/(pontoMaximo - pontoMinimo)) * 100;
}
//DETERMINAR VALOR MAXIMO OU VALOR MINIMO
function probEF(valor, mediaE){
	return (2*mediaE) - valor;
}

//FUNÇÂO PRINCIPAL
function concluir(){
	//VARIAVEIS
	var pontoMinimo = document.getElementById("pontoMinimo").value;
	var pontoMaximo = document.getElementById("pontoMaximo").value;	
	var pontoEquilibrio;
	var x;
	var y;
	var valor;
	var mediaE;
	var valorEncontrado;
	//VALOR MÉDIO
	var valorMedio = media(parseFloat(pontoMinimo), parseFloat(pontoMaximo));
	//DESVIO PADRAO
	var dp = desvioPadrao(parseFloat(pontoMinimo), parseFloat(pontoMaximo));
	var variancia = Math.pow(dp, 2);
	var prob;
	//VARIAVEL COM TODAS AS RESPOSTAS 
	var resp = "";

	if(document.getElementById("e").checked || document.getElementById("f").checked){
		if(document.getElementById("e").checked){
			valor = document.getElementById("minimo").value;
			mediaE = document.getElementById("media").value;
			valorEncontrado = probEF(valor, mediaE);
			resp = "Valor Máximo: " + valorEncontrado;
		}
		else if(document.getElementById("f").checked){
			valor = document.getElementById("maximo").value;
			mediaE = document.getElementById("media").value;
			valorEncontrado = probEF(valor, mediaE);
			resp = "Valor Mínimo: " + valorEncontrado;
		}
	}
	else{
		if(document.getElementById("d").checked){
			pontoEquilibrio = document.getElementById("pontoEquilibrio").value;
			prob = probD(pontoMinimo, pontoMaximo, pontoEquilibrio);
		}
		else if(document.getElementById("a").checked){
			x = document.getElementById("x").value;
			prob = probA(pontoMinimo, pontoMaximo, x);
		}
		else if(document.getElementById("b").checked){
			x = document.getElementById("x").value;
			prob = probB(pontoMinimo, pontoMaximo, x);
		}
		else if(document.getElementById("c").value){
			x = document.getElementById("x1").value;
			y = document.getElementById("y").value;
			prob = probC(pontoMinimo, pontoMaximo, x, y);
		}

		resp = "Valor Médio: " + valorMedio.toFixed(2) + "<br />";
		resp += "Variância: " + variancia.toFixed(2) + "<br />";
		resp += "Desvio Padrão: " + dp.toFixed(2) + "<br />";
		resp += "Probabilidade: " + prob.toFixed(2) + "% <br />";
	}

	//ELEMENTO HTML RECEBE OS VALORES OBTIDOS
	document.getElementById("resultado").innerHTML = resp;

	//EXIBE O ELEMENTO HTML COM AS RESPOSTAS
	controleLista2();
}

//ELEMENTOS HTML
//EXIBE A LISTA 2- DIV COM AS RESPOSTAS
function controleLista2(){
	document.getElementById("lista1").style.display = "none";
	document.getElementById("lista2").style.display = "";
}

//CONTROLE DAS DIV DAS PROBABILIDADES
function mostraDiv(){
	controleMaxima();
	if(document.getElementById("a").checked || document.getElementById("b").checked){
		document.getElementById("divUmElemento").style.display = "";
		document.getElementById("divDoisElementos").style.display = "none";
		document.getElementById("divPontoEquilibrio").style.display = "none";
	}
	else if(document.getElementById("c").checked){
		document.getElementById("divUmElemento").style.display = "none";
		document.getElementById("divDoisElementos").style.display = "";
		document.getElementById("divPontoEquilibrio").style.display = "none";
	}
	else if(document.getElementById("d").checked){
		document.getElementById("divUmElemento").style.display = "none";
		document.getElementById("divDoisElementos").style.display = "none";
		document.getElementById("divPontoEquilibrio").style.display = "";		
	}
}

//CONTROLE DA DIV DETERMINAR VENDA MAXIMA OU MINIMA
function controleMaxima(){
	if(document.getElementById("e").checked || document.getElementById("f").checked){
		document.getElementById("probabilidadesUniforme").style.display = "none";
		document.getElementById("divMaximaMinima").style.display = "";

		if(document.getElementById("e").checked){
			document.getElementById("divMaxima").style.display = "";
			document.getElementById("divMinima").style.display = "none";
		}
		else if(document.getElementById("f").checked){
			document.getElementById("divMaxima").style.display = "none";
			document.getElementById("divMinima").style.display = "";
		}
	}
	else{
		document.getElementById("probabilidadesUniforme").style.display = "";
		document.getElementById("divMaximaMinima").style.display = "none";
	}
}