/* Para toda lista de exercicios, podem existir testes ou atividades 
 * que o compilador não vai permitir a execução. Quando isto ocorrer 
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

// caso insira um valor muito grande para armazenar como short:
// System.OverflowException: 'Value was either too large or too small for an Int16.'
Console.WriteLine("short: ");          
a = short.Parse(Console.ReadLine());    
Console.WriteLine("short: " + a);

// caso insira um valor muito grande para armazenar como int:
// System.OverflowException: 'Value was either too large or too small for an Int32.'
Console.WriteLine("int: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("int: " + b);

// caso insira um valor muito grande para armazenar como long:
// System.OverflowException: 'Value was either too large or too small for an Int64.'
Console.WriteLine("long: ");
c = long.Parse(Console.ReadLine());
Console.WriteLine("long: " + c);


Console.WriteLine("float: ");
d = float.Parse(Console.ReadLine());
Console.WriteLine("float: " + d);

// transforma em notação cientifica valores muito grandes ao tentar imprimir o valor no console
Console.WriteLine("double: ");
e = double.Parse(Console.ReadLine());
Console.WriteLine("double: " + e);

// caso insira um valor muito grande para armazenar como decimal:
// System.OverflowException: 'Value was either too large or too small for a Decimal.'
Console.WriteLine("decimal: ");
f = decimal.Parse(Console.ReadLine());
Console.WriteLine("decimal: " + f);

// Nos casos short, int e longe, se inserir um numero ponto flutuante ou string:
// System.FormatException: 'Input string was not in a correct format.'

// Nos casos float, double e decimal, se inserir uma string:
// System.FormatException: 'Input string was not in a correct format.'

