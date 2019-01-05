//FUNÇÃO LIMPAR
function limpar(){	
	document.getElementById("n").value = "";
	document.getElementById("p").value = "";
	document.getElementById("q").value = "";
	document.getElementById("x").value = "";
	document.getElementById("a").checked = true;
	$('html, body').animate({scrollTop:0}, 'fast');
}

//FUNÇÕES EXIBIR ELEMENTOS DIV
//EXIBIR DIV INPUT X
function divInputX(){
	if(document.getElementById("d").checked){
		document.getElementById("divInputX").style.display = "none";
	}
	else{
		document.getElementById("divInputX").style.display = "";
	}
}
//EXBIR DIV LISTA 2
function controleLista2(){
	document.getElementById("lista1").style.display = "none";
	document.getElementById("lista2").style.display = "";
}

//FUNÇÕES DE CALCULOS
//CONCLUIR
function concluir(){
	//VARIAVEIS
	var n = parseFloat(document.getElementById("n").value);//ELEMENTOS
	var p = parseFloat(document.getElementById("p").value) / 100;//OBJETO DE PESQUISA
	var q = parseFloat(document.getElementById("q").value) / 100;//RESTO DO OBJETO DE PESQUISA
	var x = parseFloat(document.getElementById("x").value);
	var k = new Array();//EVENTO
	var ac;//ANALISE COMBINATORIA
	var probParcial = new Array();//PROBABILIDADE DE CADA EVENTO
	var prob = 0;//PROBABILIDADE
	var i;//VARIAVEL INDICE
	var media;//MEDIA
	var desvioPadrao;//DESVIO PADRAO
	var variancia;//VARIANCIA
	var resultado = "";

	//SE A HIPOTESE FOR DIFERENTE DE TODOS ELEMENTOS
	if(document.getElementById("b").checked || document.getElementById("c").checked){
		if(document.getElementById("b").checked){//HIPOTESE NO MAXIMO X
			for(i = 0; i <= x; i++){
				k[i] = i;	
				ac = analiseCombinatoria(n, k[i]);	
				probParcial[i] = ac * Math.pow(p, k[i]) * Math.pow(q, (n-k[i]));
				probParcial[i] *= 100;
				prob +=	probParcial[i];	
			}
			resultado = "Probabilidade: "+ prob.toFixed(2) + "%";
		}

		if(document.getElementById("c").checked){//HIPOTESE NO MINIMO X
			for(i = x; i <= n; i++){
				k[i] = i;
				ac = analiseCombinatoria(n, k[i]);
				probParcial[i] = ac * Math.pow(p, k[i]) * Math.pow(q, (n-k[i]));
				probParcial[i] *= 100;
				prob +=	probParcial[i];
			}
			resultado = "Probabilidade: "+ prob.toFixed(2) + "%";
		}

	}
	else if(document.getElementById("a").checked){//HIPOTESE EXATAMENTE X
		k[0] = x;
		ac = analiseCombinatoria(n, k[0]);
		prob = ac * Math.pow(p, k[0]) * Math.pow(q, (n-k[0])); 
		prob *= 100;
		resultado = "Probabilidade: "+ prob.toFixed(2) + "%";
	}
	else if(document.getElementById("d").checked){
		media = n*p;
		desvioPadrao = Math.sqrt(n*p*q);
		variancia = Math.pow(desvioPadrao,2);
		resultado += "Media: " + media.toFixed(2) + "<br />";
		resultado += "Desvio Padrão: " + desvioPadrao.toFixed(2) + "<br />";
		resultado += "Variância: " + variancia.toFixed(2);
	}

	//ATRIBUI O RESULTADO DA PROBABILIDADE NA DIV RESULTADO
	document.getElementById("resultado").innerHTML = resultado;

	//EXIBI A DIV LISTA 2
	controleLista2();
}

//FUNÇÃO ANALISE COMBINATORIA
function analiseCombinatoria(n , k){
	//VARIAVEIS
	var fatN = 1;
	var fatK = 1;
	var fatNK = 1;
	var ac;
	var i;

	//FATORIAL DE N
	for(i = n; i > 0; i--){
		fatN *= i;
	}

	//FATORIAL DE K
	for(i = k; i > 0; i--){
		fatK *= i;
	}

	//FATORIAL DE N - K
	for(i = n-k; i > 0; i--){
		fatNK *= i;
	}

	ac = fatN / (fatK * fatNK);

	return ac;
}