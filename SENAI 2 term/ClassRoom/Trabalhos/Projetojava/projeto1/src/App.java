public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Hello, World!");
    }
}/*
Declare uma vari�vel `pessoa`, que receba suas informa��es pessoais.
As propriedades e tipos de valores para cada propriedade desse objeto devem ser:
- `nome` - String
- `sobrenome` - String
- `genero` - String
- `idade` - Number
- `altura` - Number
- `peso` - Number
- `andando` - Boolean - recebe "falso" por padr�o
- `caminhouQuantosMetros` - Number - recebe "zero" por padr�o
*/

//
var pessoa = {
	nome: 'Felipe';
	genero: 'Masculino';
	idade: 17;
	altura: 1,77;
	peso: 67;
	caminhouQuantosMetros: 0;
	andando: new Boolean(false);
	}

/*
Adicione um m�todo ao objeto `pessoa` chamado `fazerAniversario`. O m�todo deve
alterar o valor da propriedade `idade` dessa pessoa, somando `1` a cada vez que
for chamado.
*/

//

pessoa.fazerAniversario = function(){
pessoa.idade ++;
console.log( 'agora eu tenho' + idade )
}
		//ou

if (fazerAniversario = idade + 1) {
        console.log( "agora eu tenho" + idade)
}

/*
Adicione um m�todo ao objeto `pessoa` chamado `andar`, que ter� as seguintes
caracter�sticas:
- Esse m�todo deve receber por par�metro um valor que representar� a quantidade
de metros caminhados;
- Ele deve alterar o valor da propriedade `caminhouQuantosMetros`, somando ao
valor dessa propriedade a quantidade passada por par�metro;
- Ele dever� modificar o valor da propriedade `andando` para o valor
booleano que representa "verdadeiro";
*/

//

pessoa.andar = function(m){
	pessoa.caminhoQuantosmetros += m;
	pessoa.andando = true;
}


/*
Adicione um m�todo ao objeto `pessoa` chamado `parar`, que ir� modificar o valor
da propriedade `andando` para o valor booleano que representa "falso".
*/

//
pessoa.parar = function(){
	pessoa.andando = false;
}


/*
Crie um m�todo chamado `nomeCompleto`, que retorne a frase:
- "Ol�! Meu nome � [NOME] [SOBRENOME]!"
*/

//
pessoa.nomeCompleto = function(){
return "Seu nome �" + pessoa.mome + " " + pessoa.sobreNome;
}


/*
Crie um m�todo chamado `mostrarIdade`, que retorne a frase:
- "Ol�, eu tenho [IDADE] anos!"
*/

//
pessoa.mostrarIdade = function(){
return "Ol�, eu tenho" + pessoa.idade + "anos!"}


/*
Crie um m�todo chamado `mostrarPeso`, que retorne a frase:
- "Eu peso [PESO]Kg."
*/

//
pessoa.MostrarPeso = function(){
return "Eu peso" + pessoa.peso + "Kg"}


/*
Crie um m�todo chamado `mostrarAltura` que retorne a frase:
- "Minha altura � [ALTURA]m."
*/

//
pessoa.mostrarAltura function(){
return "Minha altura �" + pessoa.altura + "m."}


/*
Agora vamos trabalhar um pouco com o objeto criado:
Qual o nome completo da pessoa? (Use a instru��o para responder e coment�rios
inline ao lado da instru��o para mostrar qual foi a resposta retornada)
*/

//se remete uma parte da questao a esta ja enunciada antes
pessoa.nome = "Felipe";
pessoa.sobrenome = "Sugisawa";
pessoa.nomeCompleto(): //Seu nome � Felipe Sugisawa



/*
Qual a idade da pessoa? (Use a instru��o para responder e coment�rios
inline ao lado da instru��o para mostrar qual foi a resposta retornada)
*/

//
pessoa.idade = 17;
pessoa.mostrarIdade(); // Ol�, eu tenho 17 anos!


/*
Qual o peso da pessoa? (Use a instru��o para responder e coment�rios
inline ao lado da instru��o para mostrar qual foi a resposta retornada)
*/

//
pessoa.peso = 67;
pessoa.mostrarPeso(); // Eu peso 67Kg.


/*
Qual a altura da pessoa? (Use a instru��o para responder e coment�rios
inline ao lado da instru��o para mostrar qual foi a resposta retornada)
*/

//
pessoa.altura = 1.7;
pessoa.mostrarAltura(); // Minhaaltura � 1.7m."


/*
Fa�a a `pessoa` fazer 3 anivers�rios.
*/

//
pessoa.fazerAniversario();
pessoa.fazerAniversario();
pessoa.fazerAniversario();


/*
Quantos anos a `pessoa` tem agora? (Use a instru��o para responder e
coment�rios inline ao lado da instru��o para mostrar qual foi a resposta
retornada)
*/

//
pessoa.idade; // 17


/*
Agora, fa�a a `pessoa` caminhar alguns metros, invocando o m�todo `andar` 3x,
com as dist�ncias diferentes passadas por par�metro.
*/

//
pessoa.andar(30);
pessoa.andar(50);
pessoa.andar(40);


/*
A pessoa ainda est� andando? (Use a instru��o para responder e coment�rios
inline ao lado da instru��o para mostrar qual foi a resposta retornada)
*/

//
pessoa.andando; // true


/*
Se a pessoa ainda est� andando, fa�a-a parar.
*/

//
pessoa.parar();


/*
E agora: a pessoa ainda est� andando? (Use uma instru��o para responder e
coment�rios inline ao lado da instru��o para mostrar a resposta retornada)
*/

//
pessoa.andando; // false


/*
Quantos metros a pessoa andou? (Use uma instru��o para responder e coment�rios
inline ao lado da instru��o para mostrar a resposta retornada)
*/

//
pessoa.caminhouQuantosMetros; // 120


/*
Agora, vamos deixar a brincadeira um pouco mais divertida! :D
Crie um m�todo para o objeto `pessoa` chamado `apresentacao`. Esse m�todo deve
retornar a string:
- "Ol�, eu sou o [NOME COMPLETO], tenho [IDADE] anos, [ALTURA], meu peso � [PESO] e, s� hoje, eu j� caminhei [CAMINHOU QUANTOS METROS] metros!"

S� que, antes de retornar a string, voc� vai fazer algumas valida��es:
- Se o `genero` de `pessoa` for "Feminino", a frase acima, no in�cio da
apresenta��o, onde diz "eu sou o", deve mostrar "a" no lugar do "o";
- Se a idade for `1`, a frase acima, na parte que fala da idade, vai mostrar a
palavra "ano" ao inv�s de "anos", pois � singular;
- Se a quantidade de metros caminhados for igual a `1`, ent�o a palavra que
deve conter no retorno da frase acima � "metro" no lugar de "metros".
- Para cada valida��o, voc� ir� declarar uma vari�vel localmente (dentro do
m�todo), que ser� concatenada com a frase de retorno, mostrando a resposta
correta, de acordo com os dados inseridos no objeto.
*/

//
pessoa.apresentacao = function(){
if (pessoa.sexo === "masculino") {
var sexfem = "Ol� eu sou a "; 
return sexfem + pessoa.nomeCompleto + ", tenho " + pessoa.idade + " anos, " + pessoa.altura + ", meu peso � " + pessoa.peso + " e, s� hoje, eu j� caminhei " + pessoa.camihouQuantosMetros + " metros!";
} else if (pessoa.idade === 1){
var anos = "ano";

return "Ol�, eu sou o " + pessoa.nomeCompleto + ", tenho " + pessoa.idade + ano, " + pessoa.altura + ", meu peso � " + pessoa.peso + " e, s� hoje, eu j� caminhei " + pessoa.camihouQuantosMetros + " metros!";
} else if (pessoa.caminhouQuantosMetros === 1) {
var metro = "metro";

return "Ola, eu sou o" + pessoa.nomeCompleto + ", tenho " + pessoa.idade + ano, " + pessoa.altura + ", meu peso � " + pessoa.peso + " e, s� hoje, eu j� caminhei " + pessoa.camihouQuantosMetros + metro + "!";
} else {
return "Ol� eu sou o " + pessoa.nomeCompleto + ", tenho " + pessoa.idade + " anos, " + pessoa.altura + ", meu peso � " + pessoa.peso + " e, s� hoje, eu j� caminhei " + pessoa.camihouQuantosMetros + " metros!";
}



/* Agora, apresente-se. */

//
pessoa.apresentacao();
