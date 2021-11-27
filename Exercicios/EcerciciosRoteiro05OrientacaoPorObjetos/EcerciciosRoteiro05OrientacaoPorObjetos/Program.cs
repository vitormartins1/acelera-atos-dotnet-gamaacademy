// 1) Tente compilar o programa abaixo:

//using System;

//namespace AulaOO
//{
//    class Pessoa
//    {
//        private string nome;
//        public string Nome { get => nome; set => nome = value; }


//        public Pessoa(string nome)
//        {
//            Console.WriteLine("Construtor PAI com parametros " + nome);

//        }

//        public virtual void Exibir() //Este é o metodo genérico
//        {
//            Console.WriteLine($"O Nome é: {Nome} ");
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            using (Pessoa pessoa = new Pessoa("Roberto"))
//            {
//                Console.WriteLine("Executando enquanto o objeto existe");
//            }
//        }
//    }
//}


// Se o mesmo executar, descreva com comentários de multiplas linhas /* */
// qual a saída no console. Se o mesmo apresentar erro, corrija e explique
// atraves de comentários o motivo do erro e qual foi a correção implementada.

using System;

namespace AulaOO
{
    class Pessoa : IDisposable
    {
        private string nome;
        public string Nome { get => nome; set => nome = value; }


        public Pessoa(string nome)
        {
            Console.WriteLine("Construtor PAI com parametros " + nome);

        }

        public virtual void Exibir() //Este é o metodo genérico
        {
            Console.WriteLine($"O Nome é: {Nome} ");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* para poder usar a instrução 'using' Pessoa precisa implementar
             * 'System.IDisposable' e sua interface obrigatoria 'Dispose'
             */
            using (Pessoa pessoa = new Pessoa("Roberto"))
            {
                Console.WriteLine("Executando enquanto o objeto existe");
            }
            /*  A correção para o erro foi implementar a interface 'IDisposable'
             *  na classe 'Pessoa' e implementar o metodo Dispose na classe Pessoa
             */
        }
    }
}