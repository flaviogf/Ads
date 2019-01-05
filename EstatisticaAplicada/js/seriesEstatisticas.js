//FUNÇÃO LIMPAR
function limpar(){
	document.getElementById("nEntrevistados").value = "";
	document.getElementById("variavel").value = "";
	document.getElementById("a").checked = true;
	$('html, body').animate({scrollTop:0}, 'fast');
}

//FUNÇÃO QUE ADICONAR INPUTS
function add(){

	var vetorH = document.getElementsByName("vetorH");
	var aux = vetorH.length;
	var vetor = new Array();
	var i;
	var elementos;

	for(i = 0; i < aux; i++){
		vetor.push("<input name='vetorH' type='text' id='input'"+i+"' placeholder='Entrevistado: "+(i+1)+"' class='form-control' ></input> <br />");
	}

	vetor.push("<input name='vetorH' type='text' id='input'"+i+"' placeholder='Entrevistado: "+(i+1)+"' class='form-control' ></input> <br />");
	elementos = vetor.join("");

	document.getElementById("divInputsEntrevistados").innerHTML = elementos;
	document.getElementById("divInputsEntrevistados").style.display = "";

}

//FUNÇÃO QUE CONTROLA A CRIAÇÃO DA QUANTIDADE DE INPUTS
function controleNumeroInputs(){

	controleLista1();
	var i;
	var qtd = document.getElementById("nEntrevistados").value;

	for(i = 1; i < qtd; i++){
		add();
	}

}

//FUNÇÃO QUE CONTROLA QUAL LISTA SERA EXIBIDA
function controleLista1(){

	document.getElementById("lista1").style.display = "none";
	document.getElementById("lista2").style.display = "";

}

//FUNÇÃO QUE CONTROLA A LISTA 2
function controleLista2(){	

	document.getElementById("lista2").style.display = "none";
	document.getElementById("lista3").style.display = "";

}

//FUNÇÃO QUE CONTROLA A LISTA 3
function controleLista3(){	

	document.getElementById("lista3").style.display = "none";
	document.getElementById("lista4").style.display = "";

}

//FUNÇÃO QUANTITATIVA DISCRETA
function cres(pr1, pr2){
	return pr1-pr2;
}

//FUNÇÃO ORGANIZAR DADOS
function orgDados(){	

	controleLista2();

	var vetorH = document.getElementsByName("vetorH");
	var novoVetor = new Array();
	var i;
	var repeticao = 0;
	var aux;

	for(i = 0; i < vetorH.length; i++){
		novoVetor[i] = vetorH[i].value;
	}

	novoVetor.sort(cres);

	aux = novoVetor[0];
	for(i = 0; i < novoVetor.length; i++){
		if(aux != novoVetor[i]){
			aux = novoVetor[i];
			repeticao++;
		}

	}

	repeticao++;

	if(repeticao > 10){	

		qContinua(novoVetor);

	}
	else{

		qDiscreta(novoVetor);

	}

	document.getElementById("resultado").innerHTML = novoVetor.join("\n");
}

//FUNÇÃO QUANTITATIVA DISCRETA
function qDiscreta(novoVetor){

	var f = 0;//Variavel que conta a quantidade de elementos iguais
	var F = 0;
	var vetorFrequencia = new Array();//Vetor responsavel por armazenar a quantidade de repetição de um dado encontrado dentro do novoVetor
	var iVetorFrequencia = 0;//Variavel indice do vetor da Frequencia
	var aux;
	var i;
	var vetorTabela = new Array();
	var vetorVariavel = new Array();//Vetor responsavel por armazenar os dadods da variavel pesquisada primeira coluna
	var vetorFrequenciaP = new Array();
	var vetorF = new Array();
	var vetorFP = new Array();
	var vetorMedia = new Array();
	var nEntrevistados = document.getElementById("nEntrevistados").value;

	//MEDIDA DE TENDENCIA CENTRAL
	var Efi = 0;
	var medidas = "";

	//MEDIA
	var media = 0;

	//MEDIANA 
	var p1 = 0, p2 = 0, mediana = 0;

	//MODA
	var moda = "";
	var auxModa = 0;

	aux = novoVetor[0];
	vetorF[0] = 0;

	//MEDIDAS DE DISPERSAO
	var variancia = 0;
	var dp = 0;
	var cv = 0;


	//ENCONTRA OS VALORES DA COLUNA DA TABELA
	for(i = 0; i < novoVetor.length; i++){

		if(aux == novoVetor[i]){

			f++;
			F++;

		}

		else{		

			vetorVariavel[iVetorFrequencia] = aux;
			vetorFrequencia[iVetorFrequencia] = f;
			vetorFrequenciaP[iVetorFrequencia] = (f/nEntrevistados) * 100;
			vetorF[iVetorFrequencia] = F;  
			vetorFP[iVetorFrequencia] = (F/nEntrevistados) * 100;
			vetorMedia[iVetorFrequencia] = aux * f;

			iVetorFrequencia++;
			aux = novoVetor[i];
			f = 1;
			F++;

		}
	}

	vetorVariavel[iVetorFrequencia] = aux;
	vetorFrequencia[iVetorFrequencia] = f;
	vetorFrequenciaP[iVetorFrequencia] = (f/nEntrevistados) * 100;
	vetorF[iVetorFrequencia] = F; 
	vetorFP[iVetorFrequencia] = (F/nEntrevistados) * 100; 
	vetorMedia[iVetorFrequencia] = aux * f;

	//CRIAÇÃO INICIAL DA TABELA
	vetorTabela.push(

		"<table class='heavyTable table-hover'>",

			"<tr>",
				"<th>"+document.getElementById("variavel").value+"</th>",
				"<th> f </th>",
				"<th> f% </th>",
				"<th> F </th>",
				"<th> F% </th>",
				"<th> xi * fi </th>",
			"</tr>"

	);

	//DADOS DAS COLUNAS DA TABELA
	for(i = 0; i < vetorFrequencia.length; i++){

		//MEDIDAS

		//SOMA DO FI
		Efi += parseFloat(vetorFrequencia[i]);

		//MEDIA
		media += parseFloat(vetorMedia[i]);

		vetorTabela.push("<tr>",
							"<td>" +vetorVariavel[i]+ "</th>",
							"<td>" +vetorFrequencia[i]+ "</td>",
							"<td>" +parseFloat(vetorFrequenciaP[i].toFixed(2))+ "%" + "</td>",
							"<td>" +vetorF[i]+ "</td>",
							"<td>" +parseFloat(vetorFP[i].toFixed(2))+ "%" + "</td>",
							"<td>" +vetorMedia[i]+ "</td>",
						"</tr>"
						);
	}

	//FINALIZA A TABELA
	vetorTabela.push("</table>");

	//MEDIDAS

	//MEDIA
	media = media / Efi;

	//MEDIANA
	if(Efi % 2 == 0){
		p1 = Efi / 2;
		p2 = (Efi / 2) + 1;
		mediana = (parseFloat(novoVetor[p1 - 1]) + parseFloat(novoVetor[p2 - 1])) / 2;
	}
	else{
		p1 = (Efi + 1) / 2;
		mediana = novoVetor[p1 - 1];
	}

	//MODA
	auxModa = vetorFrequencia[0];
	for(i = 0; i < vetorVariavel.length; i ++){

		if(auxModa <= vetorFrequencia[i]){

			if(auxModa < vetorFrequencia[i]){

				moda = vetorVariavel[i];
				auxModa = vetorFrequencia[i];

			}

			else if(auxModa == vetorFrequencia[i] && i == 0){

				moda = vetorVariavel[i];

			}

			else if(auxModa == vetorFrequencia[i]){

				moda += ", " + vetorVariavel[i];

			}

		}

	}

	//MEDIDAS DE DISPERSAO
	for(i = 0; i < vetorVariavel.length; i++){

		variancia += (Math.pow(parseFloat(vetorVariavel[i]) - parseFloat(media), 2)) * vetorFrequencia[i];

	}

	if(document.getElementById("a").checked){

		variancia = variancia / (Efi - 1);
		
	}
	else{

		variancia = variancia / Efi;

	}

	dp = Math.sqrt(variancia);
	cv = (dp / media) * 100;

	//FINAL
	medidas += "<br /> <br />";
	medidas += "Media = " + parseFloat(media.toFixed(2)) + "<br />";//MEDIA
	medidas += "Moda = " + moda + "<br />";
	medidas += "Mediana = " + mediana + "<br />";//MEDIANA
	medidas += "Variância = " + parseFloat(variancia.toFixed(2)) + "<br />";
	medidas += "Desvio Padrão = " + parseFloat(dp.toFixed(2)) + "<br />";
	medidas += "Coeficiente de Variação = " + parseFloat(cv.toFixed(2)) + "%<br />";

	//ATRIBUI A TABELA CRIADA AO CORPO DO DOCUMENTO HTML
	var elementos = vetorTabela.join("\n");
	document.getElementById("tabelaHtml").innerHTML = elementos;
	document.getElementById("medidas").innerHTML = medidas;
}

//FUNÇÃO QUANTITATIVA CONTINUA
function qContinua(novoVetor){

	var amplitude;
	var k;
	var intervalo;
	var i, j;//VARIAVEL INDICE
	var aux = 0;
	var xmax = maiorElemento(novoVetor);
	var xmin = menorElemento(novoVetor);
	var vetorTabela = new Array();
	var vetorClasses = new Array();
	var vetorVariavel = new Array();
	var vetorFrequencia = new Array();
	var vetorFrequenciaP = new Array();
	var vetorF = new Array();
	var vetorFP = new Array();
	var xf = 0;
	var xff = 0;
	var xi = xmin;
	var f = 0;
	var F = 0;
	var nEntrevistados = document.getElementById("nEntrevistados").value;

	//MEDIDAS
	var vetorMediaXi = new Array();
	var vetorMediaXiFi = new Array();
	var mediaXi = 0;
	var mediaXiFi = 0;
	var medidas = "";

	//MODA
	var classeMoldal = ""; // NAO È CLASSE E SIM A MODA
	var auxClasseMoldal = 0;

	//MEDIA
	var media = 0;
	var Efi = 0;

	//MEDIANA
	var mediana = 0;
	var posicao = 0;
	var vetorLimiteInferior = new Array();
	var limiteInferior = 0;
	var fant = 0;
	var fiNd = 0;


	//MEDIDAS DE DISPERSAO
	var variancia = 0;
	var dp = 0;
	var cv = 0;


	k = Math.sqrt(document.getElementById("nEntrevistados").value);//RESPONSAVEL POR ENCONTRAR O K
	k = parseInt(k);	
	amplitude = (xmax - xmin) + 1;//RESPONSAVEL POR ENCONTRAR A AMPLITUDE

	
	while(aux != 1){//FUNÇÃO RESPONSAVEL POR ENCONTRAR O INTERVALO

		if(amplitude % k == 0){
			intervalo = amplitude / k;
			aux = 1;
		}

		else if(amplitude % (k-1) == 0){
			k--;
			intervalo = amplitude / k;
			aux = 1;
		}

		else if(amplitude % (k+1) == 0){
			k++;
			intervalo = amplitude / k;
			aux = 1
		}

		amplitude++;

	}

	//CRIAÇÃO INICIAL DA TABELA
	vetorTabela.push(

	"<table class='heavyTable table-hover'>",

		"<tr>",
			"<th> C </th>",
			"<th>"+document.getElementById("variavel").value+"</th>",
			"<th> f </th>",
			"<th> f% </th>",
			"<th> F </th>",
			"<th> F% </th>",
			"<th> xi </th>",
			"<th> xi * fi </th>",
		"</tr>"

	);


	//VETOR FREQUENCIA
	for(i = 0; i < k; i++){

		xf += intervalo;
		xff = parseInt(xmin) + parseInt(xf);

		for(j = 0; j < novoVetor.length; j++){

			if((parseInt(novoVetor[j]) >= xi) && (parseInt(novoVetor[j]) < xff)) {
				f++;
				F++;
			}

		}

		vetorFrequencia[i] = f;
		vetorFrequenciaP[i] = (f/nEntrevistados) * 100;
		vetorF[i] = F;
		vetorFP[i] = (F/nEntrevistados) * 100;

		//MEDIDAS
		mediaXi = parseFloat(((xff - xi) / 2)) + parseFloat(xi);
		vetorMediaXi[i] = mediaXi;

		mediaXiFi = parseFloat(mediaXi) * parseFloat(f);
		vetorMediaXiFi[i] = mediaXiFi;

		//MEDIA
		media += parseFloat(mediaXiFi);
		Efi += parseInt(vetorFrequencia[i]);

		//MEDIANA
		vetorLimiteInferior[i] = xi;


		f = 0;

		xi = parseInt(xi) + parseInt(intervalo);

	}

	xf = 0;
	xi = xmin;
	//ARMAZENA AS CLASSE EM UM VETOR
	for(i = 0; i < k; i ++){

		vetorClasses[i] = i+1;//COLUNA CLASSE

		xf += intervalo;//COLUNA VARIAVEL PESQUISADA
		vetorVariavel[i] = xi + " |- " + (parseInt(xmin) + parseInt(xf));
		xi = parseInt(xi) + parseInt(intervalo);

		vetorTabela.push("<tr>",
							"<td>" +vetorClasses[i]+ "</td>",
							"<td>" +vetorVariavel[i]+ "</td>",
							"<td>" +vetorFrequencia[i]+ "</td>",
							"<td>" +parseFloat(vetorFrequenciaP[i].toFixed(2))+ "%" + "</td>",
							"<td>" +vetorF[i]+ "</td>",
							"<td>" +parseFloat(vetorFP[i].toFixed(2))+ "%" + "</td>",
							"<td>" +vetorMediaXi[i]+ "</td>",
							"<td>" +vetorMediaXiFi[i]+ "</td>",
						"</tr>"
						);
	}

	//FINALIZA A TABELA
	vetorTabela.push("</table>");

	//MEDIDAS

	//MODA
	auxClasseMoldal = vetorFrequencia[0];
	for(i = 0; i < vetorFrequencia.length; i++){

		if(auxClasseMoldal <= vetorFrequencia[i]){

			if(auxClasseMoldal < vetorFrequencia[i]){

				//MODA
				classeMoldal = vetorMediaXi[i];
				auxClasseMoldal = parseInt(vetorFrequencia[i]);

			}

			else if(auxClasseMoldal == vetorFrequencia[i] && i == 0){

				//MODA
				classeMoldal = vetorMediaXi[i];

			}

			else if(auxClasseMoldal == vetorFrequencia[i]){

				//MODA
				classeMoldal += ", " + vetorMediaXi[i];
				
			}
		}

	}

	//MEDIA
	media = media / Efi;

	//MEDIANA
	posicao = Efi / 2;
	for(i = 0; i < vetorF.length; i++){

		if(i == 0){

			if(posicao <= vetorF[i]){

				fant = vetorF[i];
				fiNd = vetorFrequencia[i];
				limiteInferior = vetorLimiteInferior[i];

				//MEDIANA FINAL
				mediana = limiteInferior + ( ( (posicao - fant) / fiNd ) * intervalo );

			}

		}

		else{

			if((posicao > vetorF[i - 1]) && (posicao <= vetorF[i])){

				fant = vetorF[i - 1];
				fiNd = vetorFrequencia[i];
				limiteInferior = vetorLimiteInferior[i];

				//MEDIANA FINAL
				mediana = limiteInferior + ( ( (posicao - fant) / fiNd ) * intervalo ); 

			}

		}

	}

	//MEDIDAS DE DISPERSÃO
	for(i = 0; i < vetorVariavel.length; i++){

		variancia += (Math.pow(parseFloat(vetorMediaXi[i]) - parseFloat(media), 2)) * vetorFrequencia[i];

	}

	if(document.getElementById("a").checked){

		variancia = variancia / (Efi - 1);
		
	}
	else{

		variancia = variancia / Efi;
		alert("Populacao");

	}

	dp = Math.sqrt(variancia);
	cv = (dp / media) * 100;


	//FINAL MEDIDA
	medidas = "<br /> <br />"
	medidas += "Media = " + media + "<br />";
	medidas += "Moda = " + classeMoldal + "<br />";
	medidas += "Mediana = " + parseFloat(mediana.toFixed(2))+ "<br />";
	medidas += "Variância = " + parseFloat(variancia.toFixed(2)) + "<br />";
	medidas += "Desvio Padrão = " + parseFloat(dp.toFixed(2)) + "<br />";
	medidas += "Coeficiente de Variação = " + parseFloat(cv.toFixed(2)) + "%<br />";


	//ATRIBUI A TABELA CRIADA AO CORPO DO DOCUMENTO HTML
	var elementos = vetorTabela.join("\n");
	document.getElementById("tabelaHtml").innerHTML = elementos;
	document.getElementById("medidas").innerHTML = medidas;

}

//FUNÇÃO MAIOR ELEMENTO
function maiorElemento(novoVetor){
	var i;
	var maior = 0;

	for(i = 0; i < novoVetor.length; i++){
		maior = novoVetor[i];
	}

	return maior;
}

//FUNÇÃO MENOR ELEMENTO
function menorElemento(novoVetor){
	var i;
	var menor;

	menor = novoVetor[0];

	return menor;
}

//FUNÇÃO CHAMAR AMOSTRAS
function chamarAmostras(){
	window.self.location.href = "amostra.html";
}

//FUNÇÃO CHAMAR INDEX
function chamarIndex(){
	window.self.location.href = "index.html";
}