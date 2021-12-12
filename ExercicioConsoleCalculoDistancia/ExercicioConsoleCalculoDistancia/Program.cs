using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int a = 1, b = 3;

        int res = funcao(a, b);

        Console.WriteLine($"Resultado={res}");
    }

    //// I
    //public static int funcao(int x, int y)
    //{
    //    int resultado = 1;
    //    for(int i = 0; i < y; i++)
    //    {
    //        resultado *= x;
    //    }

    //    return resultado;
    //}

    //// II
    //public static int funcao(int x, int y)
    //{
    //    int resultado = 1;
    //    for (int i = 0; i < x; i++)
    //    {
    //        resultado *= y;
    //    }

    //    return resultado;
    //}

    // III
    public static int funcao(int x, int y)
    {
        int resultado = 1;

        resultado *= x * y;

        return resultado;
    }
}