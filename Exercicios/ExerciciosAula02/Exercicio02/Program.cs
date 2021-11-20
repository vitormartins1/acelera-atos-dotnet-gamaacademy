/*
 * O que acontece se eu colocar um valor maior do que o 
 * suportado em uma variável byte ou sbyte ?
 * 
 * byte (8 bit)
 * 0 ate 255
 * sbyte (8 bit)  permite valores negativos
 * -128 ate 127
 * 
 * Faça um programa console C# para fazer este teste, e printar 
 * na tela o resultado de duas variáveis uma byte e outra sbyte 
 * com valores superiores ao limites acima apresentados. 
 * Faça usando tres formas que são:
 * 
 * 1 - Atribua diretamente um valor acima do limite para as variáveis.
 * 2 - Atribua um valor acima do limite para uma variável int depois 
 * faça um cast para as variáveis byte e sbyte.
 * 3 - Recupere valores do usuário para atribuir para as variáveis. 
 * Quando executar o programa insira valores acima do limite das 
 * variáveis.
 */

byte meuByte;
sbyte meuSbyte;

//meuByte = 512;  // Erro CS0031	O valor de constante "512" não pode ser convertido em "byte"
//meuSbyte = 256; // Erro CS0031	O valor de constante "256" não pode ser convertido em "sbyte"

int meuInteiro = 500;

meuByte = (byte)meuInteiro;
meuSbyte = (sbyte)meuInteiro;

Console.WriteLine("Byte apos cast to int: " + meuByte);
Console.WriteLine("Sbyte apos cast to int: " + meuSbyte);

// caso seja maior ou menor que o valor permitido para byte:
// System.OverflowException: 'Value was either too large or too small for an unsigned byte.'
Console.WriteLine("Atribua um valor ao byte (atribuicao direta): ");
meuByte = byte.Parse(Console.ReadLine());
Console.WriteLine("Byte: " + meuByte);

// caso seja maior ou menor que o valor permitido para sbyte:
// System.OverflowException: 'Value was either too large or too small for a signed byte.'
Console.WriteLine("Atribua um valor ao sbyte (atribuicao direta): ");
meuSbyte = sbyte.Parse(Console.ReadLine());
Console.WriteLine("Sbyte: " + meuSbyte);

Console.WriteLine("Atribua um valor ao byte (int parse e depois byte cast): ");
var meuValor = int.Parse(Console.ReadLine());
meuByte = (byte)meuValor;
Console.WriteLine("Byte: " + meuByte);

Console.WriteLine("Atribua um valor ao sbyte (int parse e depois sbyte cast): ");
var meuValor2 = int.Parse(Console.ReadLine());
meuSbyte = (sbyte)meuValor2;
Console.WriteLine("Byte: " + meuSbyte);