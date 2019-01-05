//FUNÇÃO LIMPAR
function limpar(){
	document.getElementById("nEntrevistados").value = "";
	document.getElementById("variavel").value = "";
	document.getElementById("a").checked = true;
	$('html, body').animate({scrollTop:0}, 'fast');
}

//CHAMA A TELA HOME
function chamarIndex(){
	window.self.location.href = "index.html";//CHAMA A PAGINA INICIAL
}

//ADICIONAR INPUTS
function addInputs(){

	var inputs = new Array(); //ARMAZENA OBJETOS INPUTS
	var qtdInputs = document.getElementById("nEntrevistados").value;
	var i;


	for(i = 0; i < parseInt(qtdInputs); i++){//RESPONSAVEL POR CONTAR AS VEZES QUE IRA CRIAR UM OBJETO INPUT

		inputs[i] = "<input name='vetorInputs' type='text' placeholder='Dado: "+(i+1)+"' class='form-control'></input> <br />"//CRIA UM NOVO OBJETO INPUT

	}	

	document.getElementById("telaInput").innerHTML = inputs.join("");
	

	exibirLista2();

}

//ORGANIZAÇÃO DOS DADOS
function orgDados(){

	var objetoInputs = document.getElementsByName("vetorInputs");
	var valoresInputs = new Array();
	var i;	
	var medidas = "";
	var m;
	var v;
	var dp;
	var cv;

	for(i = 0; i < objetoInputs.length; i++){

		valoresInputs[i] = objetoInputs[i].value; //ATRIBUI O VALOR DA PROPRIEDA VALUE DO OBJETO HTML INPUT

	}

	valoresInputs.sort(cres);	

	exibirLista3();

	m = media(valoresInputs);
	v = variancia(valoresInputs, m);
	dp = desvioPadrao(v);
	cv = coeficienteVariacao(dp,m);

	medidas += "Media = " + parseFloat(m.toFixed(2)) + "<br />";
	medidas += "Moda = " + moda(valoresInputs) + "<br />";
	medidas += "Mediana = " + parseFloat(mediana(valoresInputs).toFixed(2)) + "<br />";	
	medidas += "Variancia = " + parseFloat(v.toFixed(2)) + "<br />";
	medidas += "Desvio Padrão = " +parseFloat(dp.toFixed(2)) + "<br />";
	medidas += "Coeficiente de Variação = " + parseFloat(cv.toFixed(2)) + "<br />";

	document.getElementById("resultado").innerHTML = medidas;
	document.getElementById("rol").innerHTML = valoresInputs.join(" ");

}

//MEDIDAS DE TENDENCIA CENTRAL E DE DISTRIBUIÇÃO
//MEDIA
function media(valoresInputs){

	var i;
	//MEDIA
	var media = 0;

	//FINAL
	var medidas = "";

	//MEDIA
	for(i = 0; i < valoresInputs.length; i++){

		media += parseFloat(valoresInputs[i]);

	}

	media = media/valoresInputs.length;

	return media;

}

//MEDIANA
function mediana(valoresInputs){

	var mediana;
	var p1;

	if(valoresInputs.length % 2 == 0){

		p1 = valoresInputs.length / 2;
		var p2 = valoresInputs.length / 2 + 1;

		mediana = (parseFloat(valoresInputs[p1 - 1]) + parseFloat(valoresInputs[p2 - 1])) / 2;

	}

	else{

		p1 = (valoresInputs.length + 1) / 2;

		mediana = parseFloat(valoresInputs[p1 - 1]);

	}

	return mediana;

}

//MODA
function moda(valoresInputs){

	var i;
	var frequencia = new Array(); //FREQUENCIA DE REPETIÇÃO DE CADA ELEMENTO DO ROL/VETOR
	var variavel = new Array(); //VALOR DO ELEMENTO/VARIAVEL
	var qtd = 0;
	var aux = valoresInputs[0];
	var f = 1; //VARIAVEL AUXILIAR PARA O VETOR FREQUENCIA
	var m = "";

	for(i = 1; i < valoresInputs.length; i++){

		if(aux == valoresInputs[i]){

			f++;

		}
		else{

			frequencia[qtd] = f;
			variavel[qtd] = aux;
			f = 1;
			aux = valoresInputs[i];
			qtd++;

		}

	}

	frequencia[qtd] = f;
	variavel[qtd] = aux;

	aux = frequencia[0];
	for(i = 0; i < frequencia.length; i++){

		if(aux <= frequencia[i]){

			if(aux < frequencia[i]){

				m = variavel[i];
				aux = frequencia[i];

			}

			else if(aux == frequencia[i] && i == 0){

				m = variavel[i];

			}

			else if(aux == frequencia[i]){

				m += ", " + variavel[i];

			}

		}

	}

	return m;

}

//VARIANCIA
function variancia(valoresInputs, m){

	var i;
	var resp = 0;

	for(i = 0; i < valoresInputs.length; i++){

		resp += Math.pow((parseFloat(valoresInputs[i]) - m), 2);

	}

	if(document.getElementById("a").checked){

		resp = resp / (valoresInputs.length - 1);

	}

	else{

		resp = resp / valoresInputs.length;

	}

	

	return resp;

}

//DESVIO PADRAO
function desvioPadrao(v){

	return Math.sqrt(v);

}

//COEFICIENTE DE VARIAÇÃO
function coeficienteVariacao(dp, m){

	return (dp / m) * 100;

}

//FUNÇOES CONTROLE DAS LISTAS
function exibirLista2(){

	document.getElementById("lista1").style.display = "none";
	document.getElementById("lista2").style.display = "";//EXIBI A LISTA 2
	document.getElementById("lista3").style.display = "none";
	document.getElementById("lista4").style.display = "none";

}

function exibirLista3(){

	document.getElementById("lista1").style.display = "none";
	document.getElementById("lista2").style.display = "none";
	document.getElementById("lista3").style.display = "";//EXIBI A LISTA 3
	document.getElementById("lista4").style.display = "none";

}

function exibirLista4(){

	document.getElementById("lista1").style.display = "none";
	document.getElementById("lista2").style.display = "none";
	document.getElementById("lista3").style.display = "none";
	document.getElementById("lista4").style.display = "";//EXIBI A LISTA 4

}

//FUNÇÃO CRESCENTE
function cres(pr1, pr2){
	return pr1-pr2;
}