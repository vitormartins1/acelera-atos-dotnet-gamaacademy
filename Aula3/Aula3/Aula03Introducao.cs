//AULA 3 - Introdução
using System.Globalization;

namespace Aula3
{
    #region PARTE 01 Metodos
    /*
    //tipos de retorno(void, int, bool, string)
    //parametros(tipos e varios parametros) - nome intuitivos
    //parametros opicionais (int num = 39)
    //metodos staticos e dinamicos

    static void Muda(int a)
    {
        a = 10;
    }

    static void Main()
    {
        int num = 13;
        Muda(num);
        Console.WriteLine("O valor de num é: {0}", num);
    }
    */
    #endregion

    #region Parte 02 Parametros por valor
    /*
    //https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/passing-reference-type-parameters

    //Parametros Referenciados
    //https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/passing-reference-type-parameters

    //https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/out-parameter-modifier

    //A memória é dividida em duas partes, Heap e Stack
    //Heap armazena os dados
    //Stack armazena as referências para os dados

    //Quando armazenamos um valor a memoria é alocada, e este espaço armazena o dado, a variável acessa este dado diretamente. Quando atribuimos uma variável do tipo valor para outra, o valor será copiado.

    //Buil-in (primitivos), Structs, Enums são do tipo valor

    int x = 13;
    int y = x; //Y é uma copia de X
    Console.WriteLine(x); // 13
    Console.WriteLine(y); // 13
    x = 39;
    Console.WriteLine(x); // 39
    Console.WriteLine(y); // 13

    //Quando armazenamos uma referencia, na verdade estamos armazenando o endereço
    //do objeto que contem os dados, e não os dados propriamente ditos. Quando atribuimos
    //uma variável referencia para outra, copiamos apenas o endereço de onde se encontram os
    //dados de uma veriável para a outra. O dado é o mesmo, logo as variáveis do tipo referencias tem comportamento diferente. Este tipo de variável serão alvo do Garbage Colector.

    var arr = new string[2];
    arr[0] = "Roberto";
    var arr2 = arr; //Não cria uma copia dos dados
    Console.WriteLine(arr[0]);
    Console.WriteLine(arr2[0]);
    //Alterando o dado...
    arr[0] = "Alteração";
    Console.WriteLine(arr[0]);
    Console.WriteLine(arr2[0]);
    */
    #endregion

    #region Parte 03 Structs
    /*
    namespace Aula3Professor
    {
        //Tipo Valor -Diferente das classes
        struct Aluno
        {
            //Propriedades
            public int Id;
            public int Idade;
            public string Nome;

            //Metodos
            public void Imp()
            {
                Console.WriteLine($"Id = {Id} Nome = {Nome}");
            }
        }

        class Aula03Introducao
        {
            static void Main()
            {

                Aluno alu = new Aluno();
                alu.Id = 1;
                alu.Idade = 25;
                alu.Nome = "Indiana Jones";

                Aluno alu2 = alu;

                alu.Imp();
                alu2.Imp();

                alu2.Nome = "Antonio";


                alu.Imp();
                alu2.Imp();
            }
        }
    }
    // construtor de Structs
    //https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/structs
    */
    #endregion

    #region Parte 04 Enums
    //Enum:
    //É um inteiro com uma visualização melhor no nosso codigo
    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3
    }

    enum ERetornoOperacao
    {
        Sucesso = 1,
        Vazio = 2,
        Erro = 0
    }

    //Usando o enum para atribuição de um dado (em um construtor também)
    //Imprimindo um enum na saida do console

    #endregion

    #region Parte 05 Manipulando Strings
    /*
    //Strings:
    //Interpolação de Strings

    class Aula03Introducao
    {
        static void Main()
        {
            var texto ="";
            double valor;

            valor = 12.8 + 9;
            texto = "O preço é " + valor + " na BlackFraude";
            Console.WriteLine(texto);

            valor = 12.8 + 9;
            texto = string.Format("O preço é {0} na BlackFraude", valor);
            Console.WriteLine(texto);

            valor = 12.8 + 9;
            texto = $"O preço é {valor} na BlackFraude";
            Console.WriteLine(texto);

            //Uso do @ ignora caracteres de scape \n por exemplo
            valor = 12.8 + 9;
            texto = @$"O preço é {valor} na BlackFraude";
            Console.WriteLine(texto);

            //Comparação de strings

            texto = "Roberto";
            Console.WriteLine(texto.CompareTo("Roberto"));
            Console.WriteLine(texto.CompareTo("roberto"));
            Console.WriteLine(texto.Contains("ober"));
            Console.WriteLine(texto.Contains("galo"));
            Console.WriteLine(texto.Contains("OBER"));
            Console.WriteLine(texto.Contains("OBER", StringComparison.OrdinalIgnoreCase));


            texto = "Roberto Bunitão";
            Console.WriteLine(texto.StartsWith("Roberto"));
            Console.WriteLine(texto.EndsWith(" bunitão"));
            Console.WriteLine(texto.EndsWith("ão"));
            Console.WriteLine(texto.EndsWith("Bunitão"));
            Console.WriteLine(texto.StartsWith("roberto", StringComparison.OrdinalIgnoreCase));


            texto = "Roberto";
            //Este metodo equals existe para comparação de qualquer tipo de objeto
            Console.WriteLine(texto.Equals("Roberto"));
            Console.WriteLine(texto.Equals("roberto"));
            Console.WriteLine(texto.Equals("roberto", StringComparison.OrdinalIgnoreCase));


            texto = "Roberto é Bunitão demais da conta";
            Console.WriteLine(texto.IndexOf("ober"));
            Console.WriteLine(texto.IndexOf("o"));
            Console.WriteLine(texto.LastIndexOf("O", StringComparison.OrdinalIgnoreCase));

            texto = "Roberto é Bunitão demais da conta";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(5, "NOVO"));
            Console.WriteLine(texto.Remove(5, 2));
            Console.WriteLine(texto.Length);

            texto = "12345";
            Console.WriteLine(texto.PadLeft(10, '0'));
            Console.WriteLine(texto.PadRight(10, '0'));

            // Manipulando Strings:
            texto = "Roberto Bunitão";
            texto = texto.Replace("Bunitão", "Bunitão demais da conta");

            Console.WriteLine(texto);

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            var resultado = texto.Substring(8);
            Console.WriteLine(resultado);

            var semEspaco = texto.Trim();
            Console.WriteLine(semEspaco);

            // String Builder:
            texto = "Roberto Bunitão";
            texto += "demais da conta";     //consome muita memoria tipo valor
            Console.WriteLine(texto);

            var texto2 = new System.Text.StringBuilder();
            texto2.Append("Este é um");
            texto2.Append(" exemplo ");
            texto2.Append(" interessante ");
            texto2.Append(" esta usando um tipo referencia chamado StringBuilder");
            Console.WriteLine(texto2);
        }
    }
    */
    #endregion

    #region Parte 06 Datas
    class Aula03Introducao
    {
        static void Main()
        {
            //Datas:
            //Struct(logo tipo valor e não referencia)

            var data = new DateTime();
            Console.WriteLine(data);

            data = DateTime.Now;
            Console.WriteLine(data);

            data = new DateTime(2020, 10, 12, 8, 23, 14);
            Console.WriteLine(data);

            //string dateInput = "Jan 1, 2009";
            string dateInput = "01/01/2009";
            var parsedDate = DateTime.Parse(dateInput);
            Console.WriteLine(parsedDate);
            Console.WriteLine(parsedDate.DayOfWeek);


            dateInput = "12 de Janeiro de 2019";
            var cultureInfo = new CultureInfo("pt-BR");
            //var cultureInfo = new CultureInfo("en-US");
            parsedDate = DateTime.Parse(dateInput, cultureInfo);
            Console.WriteLine(parsedDate);


            dateInput = "12 de Janeiro de 2019";

            cultureInfo = new CultureInfo("pt-BR");
            //var cultureInfo = new CultureInfo("en-US");
            parsedDate = DateTime.Parse(dateInput, cultureInfo);

            Console.WriteLine(parsedDate.DayOfWeek);
            Console.WriteLine(parsedDate.ToString("dddd"));
        }
    }
    #endregion
}