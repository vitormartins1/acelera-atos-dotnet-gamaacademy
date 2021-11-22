/*namespace Aula3
{
    class Valor
    {
        public int num;
    }

    struct Aluno
    {
        public int Id;
        public int Idade;
        public string Nome;

        public void Imp()
        {
            Console.WriteLine($"id = {Id} Nome = {Nome}");
        }
    }

    class Program
    {
        static void Main()
        {
            Valor valor = new Valor();
            valor.num = 10;
            Imp4(valor);
            Console.WriteLine(valor.num);

            int a = 10;
            Imp(a);
            Console.WriteLine(a);   // mesmo num sendo alterado dentro da funcao o a continua o mesmo
                                    // pois foi passado uma copia do valor de a para o num dentro da funcao

            // ************************************************************************************************

            var arr = new string[2];
            arr[0] = "Vitor";
            var arr2 = arr;     // Não cria uma copia dos dados
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
            // Alterando o dado
            // Tenho duas variaveis distintas que estao guardando o mesmo endereço de memória
            arr[0] = "Alteração";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            // ************************************************************************************************
            // A struct sempre passa o valor
            // A classe sempre passa por referência. Sempre referênciada.
            Aluno alu = new Aluno();
            alu.Id = 1;
            alu.Idade = 2;
            alu.Nome = "Nome";

            Aluno alu2 = new Aluno();
            alu.Imp();
            alu2.Imp();

            alu2.Nome = "Antonio";

            alu.Imp();
            alu2.Imp();
        }

        static void Imp(int num)
        {
            Console.WriteLine("Oi " + num);
            num = 13;
        }

        // quando usado ref a variavel 'a' é passada como referencia 
        // logo seu valor de memoria é referenciado como o mesmo que 'num'
        // ela precisa ser inicializada para ser passada como ref
        static void Imp2(ref int num)
        {
            Console.WriteLine("Oi " + num);
            num = 13;
        }

        // quando usado out a variavel 'a' é passada para ser setada
        // dentro da funcao, logo antes dela ser usada na funcao e
        // necessario atribuir um valor
        static void Imp3(out int num)
        {
            num = 13;
            Console.WriteLine("Oi " + num);
        }

        // Todo tipo objeto e automaticamente referenciado
        static void Imp4(Valor novoValor)
        {
            novoValor.num = 13;
            Console.WriteLine("Oi " + novoValor.num);
        }

        // Quando o atributo tem um valor padrao ele se torna opcional
        // O atributo opcional deve vir sempre por ultimo depois dos parametros obrigatorios
        static void Imp5(string texto, int num = 0)
        {
            num = 13;
            Console.WriteLine("Oi " + num);
        }
    }
}*/