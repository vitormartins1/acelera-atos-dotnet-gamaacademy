// Construa uma calculadora para implementar as 4 operações elementares.
// Um menu deve ser criado no console para escolher a operação.
// O programa deve solicitar os valores de entrada.
// Realizar a operação solicitada e retornar para o menu.
// Uma opção de saida do programa também deve existir no menu.

string operacao;
float numA;
float numB;
float resultado;
bool saida = false;

while (!saida)
{
    Console.WriteLine("Indique a operação de cálculo desejada (+) (-) (/) (*) " +
        "ou use (sair) para finalizar o programa.");
    operacao = Console.ReadLine();

    switch (operacao)
    {
        case "+":
            Console.WriteLine("Cálculo de Soma: ");
            Console.WriteLine("Primeiro valor: ");
            numA = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            numB = float.Parse(Console.ReadLine());
            resultado = numA + numB;
            Console.WriteLine("O resultado da soma do primeiro valor com o segundo valor é: " + resultado);
            break;
        case "-":
            Console.WriteLine("Cálculo de Subtração: ");
            Console.WriteLine("Primeiro valor: ");
            numA = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            numB = float.Parse(Console.ReadLine());
            resultado = numA - numB;
            Console.WriteLine("O resultado da subtração do primeiro valor com o segundo valor é: " + resultado);
            break;
        case "/":
            Console.WriteLine("Cálculo de Divisão: ");
            Console.WriteLine("Primeiro valor: ");
            numA = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            numB = float.Parse(Console.ReadLine());
            resultado = numA / numB;
            Console.WriteLine("O resultado da divisão do primeiro valor com o segundo valor é: " + resultado);
            break;
        case "*":
            Console.WriteLine("Cálculo de Multiplicação: ");
            Console.WriteLine("Primeiro valor: ");
            numA = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            numB = float.Parse(Console.ReadLine());
            resultado = numA * numB;
            Console.WriteLine("O resultado da multiplicação do primeiro valor com o segundo valor é: " + resultado);
            break;
        case "sair":
            //Environment.Exit(0);
            numA = 0;
            numB = 0;
            resultado = 0;
            operacao = "";
            saida = true;
            break;
        default:
            Console.WriteLine("O programa pede que você insira um desdes valores: (+) (-) (/) (*) (sair) \n");
            break;
    }
}