/* 3) Apesar do tipo int ser o tipo primitivo mais comum, no C# 
 * existem outros tipos de dados para armazenar inteiros, cada 
 * um com sua caracteristica de tamanho em memória e capacidade 
 * ou não de armazenar numeros negativos. São eles:
 *
 * short/ ushort
 * int/ uint
 * long/ ulong
 * 
 * Faça um program console que declare variáveis dos tipos acima 
 * descritos, atribua valores iniciais para as variáveis e tente 
 * atribuir valores de variaveis de um tipo para outro tipo. 
 * Sempre printando na tela o resultado do teste quando possivel.
 */

short meuShort = -50;
ushort meuUShort = 50;
int meuInt = -500;
uint meuUInt = 500;
long meuLong = -50000;
ulong meuULong = 50000;

Console.WriteLine("Atribuindo short negativo para ushort: ");
meuUShort = (ushort)meuShort;
Console.WriteLine(meuUShort);

Console.WriteLine("Atribuindo int negativo para o uint: ");
meuUInt = (uint)meuInt;
Console.WriteLine(meuUInt);

Console.WriteLine("Atribuindo long negativo para o ulong: ");
meuULong = (ulong)meuLong;
Console.WriteLine(meuULong);