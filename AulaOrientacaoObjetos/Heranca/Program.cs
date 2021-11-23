using System;

namespace Heranca
{
    class Pessoa
    {
        public string nome { get; set;}
        public string telefone { get; set;}

        public virtual void Imprimir()
        {
            Console.WriteLine($"Nome: {this.nome} Telefone: {this.telefone}");
        }
    }

    class PessoaFisica : Pessoa
    {
        public string cpf { get; set;}

        public override void Imprimir()
        {
            Console.Write($"CPF: {this.cpf} ");
            base.Imprimir();
        }
    }

    class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set;}
        public override void Imprimir()
        {
            Console.Write($"CPF: {this.cnpj} ");
            base.Imprimir();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            PessoaFisica pessoaFisica = new PessoaFisica();

            // conversao implicita de tipos e diferente de conversao implicita de tipos primitivos
            // aqui o menor recebe o maior, onde nos primitivos nao e garantido
            // consegue manipular tudo que e publico de pessoa 
            Pessoa pe = new PessoaFisica();

            pessoa.nome = "BBBBBBBBB";
            pessoa.telefone = "(21) 95658-6358";
            pessoa.Imprimir();

            pessoaFisica.nome = "Nome Sobrenome";
            pessoaFisica.telefone = "(21) 98958-6358";
            pessoaFisica.cpf = "256.879.485-96";
            pessoaFisica.Imprimir();

        }
    }
}