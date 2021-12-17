using System;

namespace AulaOrientacaoObjetos
{
    class Endereco
    {
        public int Numero { get; set; }
        public string Logradouro { get; set; }
    }

    class Pessoa
    {
        //protected => quando e protected a classe e seus filhos conseguem acessar a variavel
        private string nome;
        private string cpf;
        private string telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Endereco Endereco { get; set; }

        public override string ToString()
        {
            return $"{Nome} {Cpf} {Telefone}";
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
            Console.WriteLine("Construtor Pai: " + nome);
        }

        public Pessoa()
        {
            Console.WriteLine("Construtor Pai sem parametros");
        }

        public virtual void Exibir()
        {
            Console.Write($"{Nome} {Cpf} {Telefone}");
        }
    }

    class Aluno : Pessoa
    {
        private string[] disciplinasCursadas;

        public string[] DisciplinasCursadas
        {
            get {  return disciplinasCursadas; }
            set => disciplinasCursadas = value;
        }

        public Aluno()
        {
            Console.WriteLine("Construtor Aluno");
        }

        public override void Exibir()
        {
            Console.Write("ALUNO: ");
            base.Exibir();
        }
    }

    class Instrutor : Pessoa
    {
        private string[] disciplinasMinistradas;
        public string[] DisciplinasMinistradas 
        { 
            get => disciplinasMinistradas; 
            set => disciplinasMinistradas = value; 
        }

        public Instrutor(string nome) : base(nome)
        {
            this.Nome = nome;
            Console.WriteLine("Construtor Instrutor " + nome);
        }

        public override void Exibir()
        {
            Console.Write("INSTR: ");
            base.Exibir();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno alu = new Aluno();
            alu.Nome = "Antonio Pereira";
            alu.Cpf = "000.000.001-95";
            alu.Telefone = "(21) 996558-7424";
            alu.DisciplinasCursadas = new string[] { "DotNet", "Java", "SQL", "GIT" };
            alu.Exibir();

            Instrutor instrutor = new Instrutor("Leonardo Dicaprio");
            instrutor.Cpf = "195.000.241-45";
            instrutor.Telefone = "(21) 96363-5411";
            instrutor.DisciplinasMinistradas = new string[] { "DotNet", "Entity Framework", "Xamarin" };
            instrutor.Exibir();
        }
    }
}