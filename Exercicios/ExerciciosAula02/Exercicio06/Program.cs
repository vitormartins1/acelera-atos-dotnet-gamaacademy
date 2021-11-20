// Qual diferença do metodo int.Parse para o metodo Convert.ToInt32 ?
// Faça um programa console para declarar duas variáveis uma int
// e outra float. Atribua valores iniciais para a variável float
// e tente converter de forma explicita, o valor na variável float
// para a viariável int usando os dois metos acima. Ai final o programa
// caso seja possivel deve exibir na saida do console o resultado da conversão.

int meuInt;
float meuFloat = 0.643f;

// o metodo parse pede uma string ou um char
// logo não executa o trecho a baixo para fazer convercao explicita
meuInt = int.Parse(meuFloat);
Console.WriteLine(meuInt);

// Convert.ToInt32() funciona na conversao explicita
// aproxima o valor em float para o mais proximo em int
meuInt = Convert.ToInt32(meuFloat);
Console.WriteLine(meuInt);
