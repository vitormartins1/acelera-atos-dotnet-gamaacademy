// Construa um aplicativo console que exiba na saida os 10 primeiros
// multiplos de 2, usando operadores de atribuição adequados.

int count = 1;
List<int> multiplos = new List<int>();
int numero = 2;

while (multiplos.Count < 10)
{
    if (count % numero == 0)
    {
        multiplos.Add(count);
    }
    count++;
}

Console.Write("10 primeiros multiplos de 2 são: (");
foreach (var item in multiplos)
{
    Console.Write(item + (item == multiplos[multiplos.Count - 1] ? "" : ", "));
}
Console.Write(")");