/*
 * Construa um programa console que receba uma frase digitada 
 * pelo usuário, caso a frase contenha a letra G, imprima na 
 * saida do console, "encontrei a letra G". Caso não encontre 
 * imprima "não encontrei a letra G".
 */

string frase;

frase = Console.ReadLine();

if (frase.Contains("G") || frase.Contains("g"))
{
    Console.WriteLine("Encontrei a letra G");
}
else
{
    Console.WriteLine("Não encontrei a letra G");
}
