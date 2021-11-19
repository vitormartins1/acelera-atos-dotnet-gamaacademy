/* Para toda lista de exercicios, podem existir testes ou atividades 
 * que o compilador não vai permitir a execussão. Quando isto ocorrer 
 * deixe como comentários no codigo a descrição da situação, para que 
 * fique evidente a realização do seu teste.
 * 
 * 1)  Faça um programa para declarar variáveis dos seguinites tipos:
 * short, int, long, float, double, decimal
 * 
 * e atribua valores iniciais para as variáveis em um primeiro teste, 
 * em um segundo teste receba valores informados por um usuário, 
 * depois imprima os resultados das variáveis na saida do console.
 */

// declaracao das variaveis
short a;
int b;
long c;
float d;
double e;
decimal f;

// primeiro teste: atribuicao de valores
a = 1;
b = 2;
c = 1000000;
d = 0.5f;
e = 0.5;
f = 0.5m;

// segundo teste: recebendo valores informados pelo usuario
a = short.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = long.Parse(Console.ReadLine());
d = float.Parse(Console.ReadLine());
e = double.Parse(Console.ReadLine());
f = decimal.Parse(Console.ReadLine());

