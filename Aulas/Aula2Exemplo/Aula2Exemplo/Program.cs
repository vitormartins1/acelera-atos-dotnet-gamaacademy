
uint i = 1; // somente inteiros positivos

byte ab; // 8 bits 0 a 255
sbyte sb; // 8 bits -128 a 127

var num = 10; // assume um tipo quando atribuo um valor
var num2 = 13.0;

float num3a = (float)10.6;
float num3b = 10.6f; // f -> cast padrao float

decimal num4 = 10.6m; // m -> cast padrao decimal

int num5;
num5 = int.Parse(Console.ReadLine());
Console.WriteLine(num5);

int num6;
bool resposta = int.TryParse(Console.ReadLine(), out num6);

float num7a = 13.9f;
int num7b = Convert.ToInt32(num7a);
Console.WriteLine(num7b);

object[] vetor = new object[10]; // object pode ser qualquer coisa, e um objeto generico
vetor[0] = "Nome";
vetor[1] = 13;
vetor[2] = 98.3;
vetor[3] = true;
vetor[4] = null;

int? num8 = 10; // ? -> em alguns momentos voce nao quer que o 0 seja o numero
                // inicial default da variavel, entao ? forca o uso do null 
                // tipos primitivos por padrao nao aceitam null como valor
                // tendo que usar o -> ?
num8 = null;

int num9 = 0;
num9 += 13;
num9 -= 1;
num9 *= 10;
num9 /= 10;
num9++;
num9--;



/*
 *  short 16
 *  int 32
 *  long 64
 *  
 *  float 32
 *  double 64
 *  decimal 128
 */

short a = 10;
int b = 20;
long c = 30;
float f = 12.5f;
double d = 50.43;
decimal e = 0.2m;


a = short.Parse(Console.ReadLine());
b = short.Parse(Console.ReadLine());
c = short.Parse(Console.ReadLine());
f = short.Parse(Console.ReadLine());
d = short.Parse(Console.ReadLine());
e = short.Parse(Console.ReadLine());


b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
f = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());
e = int.Parse(Console.ReadLine());


c = long.Parse(Console.ReadLine());
f = long.Parse(Console.ReadLine());
d = long.Parse(Console.ReadLine());
e = long.Parse(Console.ReadLine());


a = short.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = long.Parse(Console.ReadLine());

Console.WriteLine($"nint.MinValue = {nint.MinValue}");
Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");
Console.WriteLine($"nuint.MinValue = {nuint.MinValue}");
Console.WriteLine($"nuint.MaxValue = {nuint.MaxValue}");


// output when run in a 64-bit process
//nint.MinValue = -9223372036854775808
//nint.MaxValue = 9223372036854775807
//nuint.MinValue = 0
//nuint.MaxValue = 18446744073709551615

//output when run in a 32-bit process
//nint.MinValue = -2147483648
//nint.MaxValue = 2147483647
//nuint.MinValue = 0
//nuint.MaxValue = 4294967295

