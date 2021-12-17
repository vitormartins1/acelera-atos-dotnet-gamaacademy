using System;

namespace Interfaces 
{
    interface IPersistencia {
        void Salvar();
        void Consultar();
    }

    public class Arquivo {

    }

    public class Banco : IPersistencia {
        public void Consultar() {
            Console.WriteLine("Consultar no Banco.");
        }

        public void Salvar() {
            Console.WriteLine("Salvar no Banco.");
        }
    }

    internal class Program {
        static void Main(string[] args) {
            IPersistencia ip;
            ip = new Banco();

            ip.Salvar();
            ip.Consultar();
        }
    }
}