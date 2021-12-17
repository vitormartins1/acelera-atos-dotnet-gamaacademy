// multiple startup roject
// Solution 'name' Property Pages -> Multiple Startup Projects
// Com exeção do class library que não tem interface com o usuário

// Arquivos....https://docs.microsoft.com/pt-br/troubleshoot/dotnet/csharp/read-write-text-file

#region PARTE 01 Lendo Arquivos txt
using System;
using System.Collections.Generic;
using System.IO;

namespace ArquivoTexto
{

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

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arquivos");
            Aluno alu = new Aluno();
            alu.Id = 1;
            alu.Idade = 25;
            alu.Nome = "Ryu";

            Aluno alu2 = new Aluno();
            alu2.Id = 1;
            alu2.Idade = 25;
            alu2.Nome = "Ken";

            Aluno alu3 = new Aluno();
            alu3.Id = 1;
            alu3.Idade = 25;
            alu3.Nome = "Blanka";

            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(alu);
            alunos.Add(alu2);
            alunos.Add(alu3);


            SalvarArquivoTexto("C://NOVO/alunos.txt", alunos);

            List<Aluno> listaRetorno = LerArquivoTexto("C://NOVO/alunos.txt");

        }


        static void SalvarArquivoTexto(string caminho, List<Aluno> listaAlunos)
        {
            StreamWriter sw = new StreamWriter(caminho);

            foreach (var alu in listaAlunos)
            {
                sw.WriteLine($"{alu.Id};{alu.Nome};{alu.Idade}");
            }
            sw.Close();
        }


        static List<Aluno> LerArquivoTexto(string caminho)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            StreamReader sr = new StreamReader(caminho);

            var line = sr.ReadLine();

            while (line != null)
            {
                var campos = line.Split(';');
                Aluno alu = new Aluno();
                alu.Id = int.Parse(campos[0]);
                alu.Nome = campos[1];
                alu.Idade = int.Parse(campos[2]);
                listaAlunos.Add(alu);
                line = sr.ReadLine();
            }

            return listaAlunos;
        }
    }
}
#endregion

#region PARTE 02 Gravando e lendo de arquivos XML 
/*
//////////////////////////////////
//https://docs.microsoft.com/pt-br/troubleshoot/dotnet/csharp/serialize-object-xml
//Gravando e lendo de arquivos XML 

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ArquivoTexto
{

    public struct Aluno
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

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arquivos");
            Aluno alu = new Aluno();
            alu.Id = 1;
            alu.Idade = 25;
            alu.Nome = "Ryu";

            Aluno alu2 = new Aluno();
            alu2.Id = 1;
            alu2.Idade = 25;
            alu2.Nome = "Ken";

            Aluno alu3 = new Aluno();
            alu3.Id = 1;
            alu3.Idade = 25;
            alu3.Nome = "Blanka";

            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(alu);
            alunos.Add(alu2);
            alunos.Add(alu3);


            SalvarArquivoTexto("C://NOVO/alunos.txt", alunos);

            List<Aluno> listaRetorno = LerArquivoTexto("C://NOVO/alunos.txt");

        }


        static void SalvarArquivoTexto(string caminho, List<Aluno> listaAlunos)
        {
            StreamWriter sw = new StreamWriter(caminho);
            XmlSerializer x = new XmlSerializer(listaAlunos.GetType());
            x.Serialize(sw, listaAlunos);
            sw.Close();
        }


        static List<Aluno> LerArquivoTexto(string caminho)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            StreamReader sr = new StreamReader(caminho);
            XmlSerializer x = new XmlSerializer(listaAlunos.GetType());
            listaAlunos = (List<Aluno>)x.Deserialize(sr);

            return listaAlunos;
        }
    }
}
*/
#endregion

#region PARTE 03 Gravando e lendo arquivo json
/*
//////////////////////////////////
// https://docs.microsoft.com/pt-br/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-6-0
// Gravando e lendo arquivo json

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace ArquivoTexto
{

    public struct Aluno
    {
        //Propriedades
        public int Id { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }

        //Metodos
        public void Imp()
        {
            Console.WriteLine($"Id = {Id} Nome = {Nome}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arquivos");
            Aluno alu = new Aluno();
            alu.Id = 1;
            alu.Idade = 25;
            alu.Nome = "Ryu";

            Aluno alu2 = new Aluno();
            alu2.Id = 1;
            alu2.Idade = 25;
            alu2.Nome = "Ken";

            Aluno alu3 = new Aluno();
            alu3.Id = 1;
            alu3.Idade = 25;
            alu3.Nome = "Blanka";

            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(alu);
            alunos.Add(alu2);
            alunos.Add(alu3);


            SalvarArquivoTexto("C://NOVO/alunos.txt", alunos);

            List<Aluno> listaRetorno = LerArquivoTexto("C://NOVO/alunos.txt");

        }


        static void SalvarArquivoTexto(string caminho, List<Aluno> listaAlunos)
        {
            StreamWriter sw = new StreamWriter(caminho);
            string jsonString = JsonSerializer.Serialize(listaAlunos);
            sw.Write(jsonString);
            sw.Close();
        }


        static List<Aluno> LerArquivoTexto(string caminho)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            StreamReader sr = new StreamReader(caminho);
            string json = sr.ReadToEnd();
            listaAlunos = (List<Aluno>)JsonSerializer.Deserialize<List<Aluno>>(json);
            return listaAlunos;
        }
    }
}
*/
#endregion





