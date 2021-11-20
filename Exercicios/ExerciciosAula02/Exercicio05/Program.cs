// Construa um programa console para receber 5 dados fornecidos por
// um usuário, estas dados podem ser dos tipos (int, double, char, string).
// Voce deve recer os dados e armazer em um vetor ou lista. Logo em seguida
// o programa deve exibir na saida do console a listagem dos dados recebidos.

object[] valores = new object[5];

Console.WriteLine("Forceça 5 valores (int, double, char, string): ");

for (int i = 0; i < valores.Length; i++)
{
    valores[i] = Console.ReadLine();
}

foreach (var item in valores)
{
    Console.WriteLine(item);
}