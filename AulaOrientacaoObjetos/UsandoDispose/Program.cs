using System;

namespace UsandoDispose {

    interface IPessoa {
        string Nome { get; set; }
        //string Cpf { get; set; }
        //string Telefone { get; set; }
    }

    class Pessoa : IDisposable, IPessoa {
        private string nome;

        public string Nome { get => nome; set => nome = value;}

        public Pessoa(string nome) {
            Console.WriteLine("Construtor PAI com parametros " + nome);
        }

        public Pessoa() {
            Console.WriteLine("Construtor PAI sem parametros.");
        }

        public void Dispose() {
            Console.WriteLine("Finalizando o objeto.");
        }
    }

    internal class Program {
        static void Main(string[] args) {
            using (Pessoa pessoa = new Pessoa("Oi"))
            {
                Console.WriteLine("Executando enquanto o objeto existe.");
            }
        }
    }
}