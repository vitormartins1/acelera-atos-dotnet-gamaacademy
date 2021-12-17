// See https://aka.ms/new-console-template for more information
using Aula1Segundo.Teste;

int a = 10;
char b = 'X';
double d = 2.3;
string s = "oi";

var e = 50; // nao defino a variavel ate que ela assuma um valor. o valor e definido quando ela for atribuida.
var f = "Roberto"; // quando uma colecao de dados retorna varios tipos deixa
                   // o codigo mais pratico ja que a atribuicao e automatica

if (a > 0)
{
    Console.WriteLine("10 > 0 true");
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("For... " + i);
}

int j = 0;
while (j < 10)
{
    Console.WriteLine("While... " + j);
    j++;
}

List<int> list = new List<int>();
list.Add(a);
list.Add(e);
list.Add(3);
list.Add(4);
list.Add(5);

foreach (int x in list)
{
    Console.WriteLine("Foreach... " + x);
}

//do
//{
//    Console.WriteLine("While... " + j);
//    j++;
//} while (j < 10);

Class1.Imp();
Console.WriteLine(f + " Hello, World!");
