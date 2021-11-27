using System;

namespace Basico
{
    public class Aluno
    {
        public int Num { get; set; }
        private int num2;

        public Aluno(int num)
        {
            this.Num = num;
        }

        public Aluno(float x)
        {

        }

        public Aluno() { }

        public int Num2
        {
            get { return Num2; }
            set
            {
                if (value <= 150)
                {
                    Num2 = value;
                } else
                {
                    Console.WriteLine("Valor invalido.");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno alu;
            alu = new Aluno(18);
            alu.Num = 13;
            alu.Num2 = 50;
            alu.Num2 = 180;
            Console.WriteLine("Oi");
        }
    }
}