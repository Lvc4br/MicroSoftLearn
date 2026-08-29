// ============================================================
// C# - FUNDAMENTOS
// TIPOS DE DADOS, VARIÁVEIS, DATA/HORA, CONSOLE E OPERADORES
// ============================================================



// ============================================================
// TIPOS DE DADOS E VARIÁVEIS
// ============================================================



// ------------------------------------------------------------
// STRING
// ------------------------------------------------------------

// string armazena textos.
// O texto precisa estar entre aspas duplas: "texto".
//
// Exemplos:
// "Olá"
// "Luca"
// "C# é legal"
//
// string pode armazenar vários caracteres.
string name = "Luca";



// ------------------------------------------------------------
// CHAR
// ------------------------------------------------------------

// char armazena APENAS UM caractere.
//
// Usa aspas simples:
// 'A'
// 'B'
// '1'
//
// Diferente de string:
// string = vários caracteres
// char   = apenas um caractere
//
// '\0' representa o caractere nulo.
// Aqui estamos criando um char inicialmente "vazio".
char letter = '\0';



// ------------------------------------------------------------
// INT
// ------------------------------------------------------------

// int armazena números inteiros.
//
// Exemplos:
// -10
// 0
// 10
// 500
// 1000
//
// É um dos tipos numéricos mais usados em C#.
int age = 10;



// ------------------------------------------------------------
// LONG
// ------------------------------------------------------------

// long também armazena números inteiros,
// mas consegue armazenar valores muito maiores que int.
//
// O "L" no final indica que o número é do tipo long.
long number = 90000L;



// ------------------------------------------------------------
// SHORT
// ------------------------------------------------------------

// short armazena números inteiros,
// mas possui uma capacidade menor que int.
//
// É útil quando sabemos que os valores serão pequenos.
short nom = 100;



// ------------------------------------------------------------
// DOUBLE
// ------------------------------------------------------------

// double armazena números com casas decimais.
//
// Exemplos:
// 10.5
// 25.75
// 100.123
//
// O "D" indica explicitamente que o número é double.
// Porém, normalmente podemos simplesmente escrever:
//
// double num = 25.5;
double num = 25.5D;



// ------------------------------------------------------------
// FLOAT
// ------------------------------------------------------------

// float também armazena números decimais.
//
// Possui menos precisão que double,
// mas também ocupa menos memória.
//
// O "F" no final é necessário para indicar
// que o número é do tipo float.
float precision = 5.0001F;



// ------------------------------------------------------------
// DECIMAL
// ------------------------------------------------------------

// decimal é usado principalmente quando precisamos
// de alta precisão em valores financeiros.
//
// Exemplos:
// dinheiro
// preços
// valores monetários
//
// O "M" no final indica que o número é decimal.
decimal money = 20.40M;



// ------------------------------------------------------------
// VAR
// ------------------------------------------------------------

// var permite que o C# descubra automaticamente
// o tipo da variável através do valor atribuído.
//
// Neste caso, o C# percebe que "lulu" é uma string.
//
// IMPORTANTE:
// var NÃO significa que a variável não possui tipo.
//
// Ela continua sendo fortemente tipada.
//
// Portanto:
//
// var nome = "lulu";
//
// é equivalente a:
//
// string nome = "lulu";

var nome = "lulu";



// ============================================================
// DECLARANDO VÁRIAS VARIÁVEIS DO MESMO TIPO
// ============================================================

// Podemos declarar várias variáveis int
// na mesma instrução.
//
// Isso:
//
// int x = 10;
// int y = 20;
// int z = 30;
//
// É equivalente a:

int x = 10,
    y = 20,
    z = 30;



// ============================================================
// DATAS E HORAS
// ============================================================



// ------------------------------------------------------------
// DATETIME.NOW
// ------------------------------------------------------------

// DateTime representa DATA + HORA.
//
// DateTime.Now pega a data e hora atual
// usando o horário LOCAL do computador.
//
// Exemplo:
// 19/08/2026 14:30:25

DateTime agora = DateTime.Now;

Console.WriteLine(agora);



// ------------------------------------------------------------
// UTCNOW
// ------------------------------------------------------------

// DateTime.UtcNow pega a data e hora atual
// em UTC (Coordinated Universal Time).
//
// UTC é utilizado como referência mundial.
//
// Por exemplo:
// São Paulo pode estar 3 horas atrás do UTC.
//
// DateTime.Now  -> horário local
// DateTime.UtcNow -> horário UTC

DateTime agoraUTC = DateTime.UtcNow;

Console.WriteLine(agoraUTC);



// ------------------------------------------------------------
// DATEONLY
// ------------------------------------------------------------

// DateOnly representa SOMENTE UMA DATA.
//
// Não possui hora.
//
// Exemplo:
// 19/08/2026

DateOnly data = DateOnly.FromDateTime(DateTime.Now);

Console.WriteLine(data);



// ------------------------------------------------------------
// TIMEONLY
// ------------------------------------------------------------

// TimeOnly representa SOMENTE UM HORÁRIO.
//
// Não possui data.
//
// Exemplo:
// 14:30:25

TimeOnly hora = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(hora);



// ------------------------------------------------------------
// FORMATANDO DATAS
// ------------------------------------------------------------

// Podemos escolher como a data será exibida.
//
// dd -> dia
// MM -> mês
// yyyy -> ano
//
// Exemplo:
// 19/08/2026

DateTime hoje = DateTime.Now;

Console.WriteLine(hoje.ToString("dd/MM/yyyy"));



// ------------------------------------------------------------
// FORMATANDO HORAS
// ------------------------------------------------------------

// HH -> hora
// mm -> minutos
// ss -> segundos
//
// Exemplo:
// 14:30:25

Console.WriteLine(agora.ToString("HH:mm:ss"));



// ============================================================
// SAÍDA NO CONSOLE
// ============================================================



// ------------------------------------------------------------
// CONSOLE.WRITELINE()
// ------------------------------------------------------------

// Escreve algo no console
// e depois pula para a próxima linha.

Console.WriteLine("Hello, World!");



// ------------------------------------------------------------
// CONSOLE.WRITE()
// ------------------------------------------------------------

// Escreve algo no console,
// mas NÃO pula para a próxima linha.

Console.Write(name);



// ============================================================
// STRING INTERPOLATION
// ============================================================



// String interpolation permite colocar o valor
// de uma variável diretamente dentro de um texto.
//
// O símbolo "$" antes das aspas ativa a interpolação.
//
// Dentro de { } colocamos a variável
// ou expressão que queremos mostrar.

Console.WriteLine($"My name is {name}");



// Exemplo:
//
// int idade = 19;
//
// Console.WriteLine($"Minha idade é {idade}");
//
// Resultado:
//
// Minha idade é 19



// Também podemos colocar cálculos dentro de { }:

Console.WriteLine($"Resultado: {x + y}");



// ============================================================
// OPERADORES ARITMÉTICOS
// ============================================================



// ------------------------------------------------------------
// +
// ------------------------------------------------------------

// Soma dois valores.

int soma = 10 + 5;

Console.WriteLine(soma);

// Resultado:
// 15



// ------------------------------------------------------------
// -
// ------------------------------------------------------------

// Subtração.

int subtracao = 10 - 5;

Console.WriteLine(subtracao);

// Resultado:
// 5



// ------------------------------------------------------------
// *
// ------------------------------------------------------------

// Multiplicação.

int multiplicacao = 10 * 5;

Console.WriteLine(multiplicacao);

// Resultado:
// 50



// ------------------------------------------------------------
// /
// ------------------------------------------------------------

// Divisão.

int divisao = 10 / 5;

Console.WriteLine(divisao);

// Resultado:
// 2



// IMPORTANTE:
//
// Quando usamos int, a divisão também será inteira.
//
// 5 / 2 = 2
//
// Se quisermos um resultado decimal,
// podemos utilizar double:
//
// double resultado = 5.0 / 2.0;
//
// Resultado:
// 2.5



// ------------------------------------------------------------
// %
// ------------------------------------------------------------

// % representa o RESTO da divisão.
//
// Exemplo:
//
// 10 / 3 = 3
// resto = 1
//
// Portanto:

int resto = 10 % 3;

Console.WriteLine(resto);

// Resultado:
// 1



// % é muito utilizado para descobrir
// se um número é PAR ou ÍMPAR.
//
// Se o resto da divisão por 2 for 0,
// o número é par.
//
// Exemplo:
//
// 10 % 2 = 0 -> PAR
// 11 % 2 = 1 -> ÍMPAR



// ============================================================
// OPERADOR DE ATRIBUIÇÃO
// ============================================================



// ------------------------------------------------------------
// =
// ------------------------------------------------------------

// "=" significa ATRIBUIÇÃO.
//
// Ele coloca um valor dentro de uma variável.
//
// NÃO significa "igual" matematicamente.
//
// Exemplo:

int valor = 10;

// Estamos dizendo:
//
// "Coloque 10 dentro da variável valor."



// Podemos alterar o valor depois:

valor = 20;

// Agora:
//
// valor = 20



// ============================================================
// OPERADORES DE COMPARAÇÃO
// ============================================================



// ------------------------------------------------------------
// ==
// ------------------------------------------------------------

// "==" significa IGUALDADE.
//
// Ele compara dois valores.
//
// O resultado será:
// true
// ou
// false

bool resultadoIgual = (10 == 10);

Console.WriteLine(resultadoIgual);

// Resultado:
// True



// Exemplo:
//
// 10 == 20
//
// Resultado:
// False



// ------------------------------------------------------------
// !=
// ------------------------------------------------------------

// "!=" significa DIFERENTE.
//
// Pergunta:
// "Os valores são diferentes?"

bool resultadoDiferente = (10 != 20);

Console.WriteLine(resultadoDiferente);

// Resultado:
// True



// 10 != 10
//
// Resultado:
// False



// ------------------------------------------------------------
// >
// ------------------------------------------------------------

// ">" significa MAIOR QUE.

bool maior = (10 > 5);

Console.WriteLine(maior);

// Resultado:
// True



// ------------------------------------------------------------
// <
// ------------------------------------------------------------

// "<" significa MENOR QUE.

bool menor = (5 < 10);

Console.WriteLine(menor);

// Resultado:
// True



// ------------------------------------------------------------
// >=
// ------------------------------------------------------------

// ">=" significa MAIOR OU IGUAL.

bool maiorOuIgual = (10 >= 10);

Console.WriteLine(maiorOuIgual);

// Resultado:
// True



// ------------------------------------------------------------
// <=
// ------------------------------------------------------------

// "<=" significa MENOR OU IGUAL.

bool menorOuIgual = (10 <= 10);

Console.WriteLine(menorOuIgual);

// Resultado:
// True



// ============================================================
// OPERADORES DE ATRIBUIÇÃO COMPOSTA
// ============================================================



// ------------------------------------------------------------
// +=
// ------------------------------------------------------------

// += adiciona um valor à própria variável.
//
// Isso:
//
// x += 5;
//
// é equivalente a:
//
// x = x + 5;

int pontos = 10;

pontos += 5;

Console.WriteLine(pontos);

// Resultado:
// 15



// ------------------------------------------------------------
// -=
// ------------------------------------------------------------

// -= subtrai um valor da própria variável.
//
// Isso:
//
// pontos -= 3;
//
// é equivalente a:
//
// pontos = pontos - 3;

pontos -= 3;

Console.WriteLine(pontos);

// Resultado:
// 12



// ------------------------------------------------------------
// *=
// ------------------------------------------------------------

// *= multiplica a própria variável.
//
// Isso:
//
// pontos *= 2;
//
// é equivalente a:
//
// pontos = pontos * 2;

pontos *= 2;

Console.WriteLine(pontos);

// Resultado:
// 24



// ------------------------------------------------------------
// /=
// ------------------------------------------------------------

// /= divide a própria variável.
//
// Isso:
//
// pontos /= 4;
//
// é equivalente a:
//
// pontos = pontos / 4;

pontos /= 4;

Console.WriteLine(pontos);

// Resultado:
// 6



// ============================================================
// INCREMENTO E DECREMENTO
// ============================================================



// ------------------------------------------------------------
// ++
// ------------------------------------------------------------

// ++ adiciona 1 à variável.
//
// Isso:
//
// x++;
//
// é equivalente a:
//
// x = x + 1;

int contador = 10;

contador++;

Console.WriteLine(contador);

// Resultado:
// 11



// ------------------------------------------------------------
// --
// ------------------------------------------------------------

// -- remove 1 da variável.
//
// Isso:
//
// contador--;
//
// é equivalente a:
//
// contador = contador - 1;

contador--;

Console.WriteLine(contador);

// Resultado:
// 10



// ============================================================
// RESUMO DOS OPERADORES
// ============================================================
//
//
// ARITMÉTICOS:
//
// +   -> soma
// -   -> subtração
// *   -> multiplicação
// /   -> divisão
// %   -> resto da divisão
//
//
// ATRIBUIÇÃO:
//
// =   -> atribui um valor
//
//
// COMPARAÇÃO:
//
// ==  -> igual
// !=  -> diferente
// >   -> maior que
// <   -> menor que
// >=  -> maior ou igual
// <=  -> menor ou igual
//
//
// ATRIBUIÇÃO COMPOSTA:
//
// +=  -> soma e atribui
// -=  -> subtrai e atribui
// *=  -> multiplica e atribui
// /=  -> divide e atribui
//
//
// INCREMENTO / DECREMENTO:
//
// ++  -> adiciona 1
// --  -> remove 1
//
// ============================================================


// ============================================================
// DIFERENÇA IMPORTANTE
// ============================================================
//
// =
//
// Significa ATRIBUIR:
//
// int x = 10;
//
//
//
// ==
//
// Significa COMPARAR:
//
// x == 10
//
// Pergunta:
// "x é igual a 10?"
//
// Resultado:
// true ou false
//
// ============================================================
// IF / ELSE - TOMADA DE DECISÕES
// ============================================================


// ------------------------------------------------------------
// IF
// ------------------------------------------------------------

// "if" significa "se".
//
// Ele permite executar um código SOMENTE SE
// uma determinada condição for verdadeira.
//
// A condição precisa resultar em:
// true  -> executa o código
// false -> não executa o código
//
// Estrutura:
//
// if (condição)
// {
//     código que será executado
// }


// Exemplo:

int idadeUsuario = 20;

if (idadeUsuario >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}



// ------------------------------------------------------------
// IF COM ==
// ------------------------------------------------------------

// Podemos usar "==" para verificar se dois valores
// são iguais.

int numero = 10;

if (numero == 10)
{
    Console.WriteLine("O número é 10.");
}



// ------------------------------------------------------------
// IF COM !=
// ------------------------------------------------------------

// Podemos verificar se dois valores são diferentes.

if (numero != 5)
{
    Console.WriteLine("O número é diferente de 5.");
}



// ------------------------------------------------------------
// IF COM >
// ------------------------------------------------------------

// Verifica se um valor é MAIOR que outro.

if (numero > 5)
{
    Console.WriteLine("O número é maior que 5.");
}



// ------------------------------------------------------------
// IF COM <
// ------------------------------------------------------------

// Verifica se um valor é MENOR que outro.

if (numero < 20)
{
    Console.WriteLine("O número é menor que 20.");
}



// ------------------------------------------------------------
// IF COM >=
// ------------------------------------------------------------

// Verifica se um valor é MAIOR OU IGUAL.

if (idadeUsuario >= 18)
{
    Console.WriteLine("Pode continuar.");
}



// ------------------------------------------------------------
// IF COM <=
// ------------------------------------------------------------

// Verifica se um valor é MENOR OU IGUAL.

if (idadeUsuario <= 18)
{
    Console.WriteLine("Tem 18 anos ou menos.");
}



// ============================================================
// ELSE
// ============================================================

// "else" significa "senão".
//
// Ele é executado quando a condição do if for FALSE.
//
// Estrutura:
//
// if (condição)
// {
//     código se for true
// }
// else
// {
//     código se for false
// }


// Exemplo:

int idade = 16;

if (idade >= 18)
{
    Console.WriteLine("Maior de idade.");
}
else
{
    Console.WriteLine("Menor de idade.");
}



// Resultado:
//
// Menor de idade.
//
// Porque:
//
// 16 >= 18
//
// é FALSE.
//
// Então o programa executa o ELSE.



// ============================================================
// ELSE IF
// ============================================================

// "else if" significa:
//
// "Se a primeira condição não for verdadeira,
// verifique outra condição."
//
// Podemos ter vários "else if".
//
// Estrutura:
//
// if (condição1)
// {
//     código
// }
// else if (condição2)
// {
//     código
// }
// else
// {
//     código
// }


// Exemplo:

int nota = 7;

if (nota >= 9)
{
    Console.WriteLine("Excelente!");
}
else if (nota >= 7)
{
    Console.WriteLine("Boa nota!");
}
else if (nota >= 5)
{
    Console.WriteLine("Nota suficiente.");
}
else
{
    Console.WriteLine("Reprovado.");
}



// O C# verifica as condições DE CIMA PARA BAIXO.
//
// Nesse exemplo:
//
// nota >= 9 -> false
//
// nota >= 7 -> true
//
// Portanto:
//
// "Boa nota!"
//
// será executado.
//
// Quando uma condição é verdadeira,
// o restante da sequência é ignorado.



// ============================================================
// BOOL
// ============================================================

// bool representa um valor lógico.
//
// Ele só pode possuir dois valores:
//
// true
// false


bool maiorDeIdade = true;

if (maiorDeIdade)
{
    Console.WriteLine("É maior de idade.");
}



// Também podemos criar um bool através de uma comparação:

int idadeTeste = 20;

bool podeEntrar = idadeTeste >= 18;

Console.WriteLine(podeEntrar);

// Resultado:
//
// True

//não precisa necessariamente do bool da para simplificar

// Podemos usar esse bool diretamente no if:

if (podeEntrar)
{
    Console.WriteLine("Entrada permitida.");
}
else
{
    Console.WriteLine("Entrada negada.");
}



// ============================================================
// ! - NOT / NEGAÇÃO
// ============================================================

// "!" inverte um valor booleano.
//
// true  -> false
// false -> true


bool estaChovendo = false;

if (!estaChovendo)
{
    Console.WriteLine("Não está chovendo.");
}



// O "!" pode ser entendido como:
//
// "NÃO"
//
// Portanto:
//
// !true  -> false
// !false -> true



// ============================================================
// && - AND / E
// ============================================================

// "&&" significa "E".
//
// TODAS as condições precisam ser verdadeiras.
//
// Exemplo:
//
// idade >= 18
// E
// possuiDocumento
//
// As duas precisam ser true.


int idadePessoa = 20;
bool possuiDocumento = true;

if (idadePessoa >= 18 && possuiDocumento)
{
    Console.WriteLine("Entrada permitida.");
}
else
{
    Console.WriteLine("Entrada negada.");
}



// Nesse exemplo:
//
// idadePessoa >= 18 -> true
// possuiDocumento   -> true
//
// true && true -> true



// Se uma das condições for false:
//
// true && false -> false
//
// O IF não será executado.



// ============================================================
// || - OR / OU
// ============================================================

// "||" significa "OU".
//
// Basta UMA das condições ser verdadeira.


bool temIngresso = false;
bool temConvite = true;

if (temIngresso || temConvite)
{
    Console.WriteLine("Pode entrar.");
}
else
{
    Console.WriteLine("Não pode entrar.");
}



// Nesse exemplo:
//
// temIngresso -> false
// temConvite -> true
//
// false || true -> true
//
// Portanto:
//
// "Pode entrar."



// ============================================================
// COMBINANDO OPERADORES
// ============================================================

// Podemos combinar:
// if
// else
// bool
// ==
// !=
// >
// <
// >=
// <=
// &&
// ||
// !


// Exemplo:

int idadeAtual = 20;
bool autorizado = true;

if (idadeAtual >= 18 && autorizado)
{
    Console.WriteLine("Acesso permitido.");
}
else
{
    Console.WriteLine("Acesso negado.");
}



// ============================================================
// EXEMPLO MAIS COMPLETO
// ============================================================

// Sistema simples de classificação de idade.

int idadeClassificacao = 20;

if (idadeClassificacao < 12)
{
    Console.WriteLine("Criança.");
}
else if (idadeClassificacao < 18)
{
    Console.WriteLine("Adolescente.");
}
else if (idadeClassificacao < 60)
{
    Console.WriteLine("Adulto.");
}
else
{
    Console.WriteLine("Idoso.");
}



// O programa verifica:
//
// idade < 12
//       ↓
//      NÃO
//
// idade < 18
//       ↓
//      NÃO
//
// idade < 60
//       ↓
//      SIM
//
// Resultado:
//
// Adulto.



// ============================================================
// RESUMO
// ============================================================
//
// IF
//     -> executa se a condição for verdadeira.
//
// ELSE IF
//     -> verifica outra condição.
//
// ELSE
//     -> executa quando nenhuma condição anterior foi verdadeira.
//
//
// BOOL
//     -> true ou false.
//
//
// !
//     -> NÃO / inverte true e false.
//
//
// &&
//     -> E
//     -> todas as condições precisam ser verdadeiras.
//
//
// ||
//     -> OU
//     -> pelo menos uma condição precisa ser verdadeira.
//
// ============================================================