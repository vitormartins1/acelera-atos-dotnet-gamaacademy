// Construa um programa console para receber o cadastro de alunos
// (Utilizando uma Struct), como nome, idade, nota e situação
// (aprovado,reprovado, recuperação), um enum deve ser utilizado
// para representar a situação do aluno. A entrada dos dados deve ser
// um metodo da struct. O programa deve receber a entrada de informações
// de 10 alunos, e ao termino imprimir na saida do console:
//
// Uma listagem contendo todos os dados de todos os alunos.
// A maior e a menor nota, e a média aritmetica das notas dos alunos. 
// Uma ultima listagem deve ser exibida onde os alunos serão exibidos juntamente
// com seu status que será calculado da seguinte forma:
// Nota do aluno 3 pontos acima ou abaixo da media da turma ele é considerado em recuperação
// Nota acima da média da turma+3 pontos aprovado
// Nota abaixo da média da turma-3 pontos reprovado

public enum Situacao
{
    APROVADO, RECUPERACAO, REPROVADO
}

struct Aluno
{
    public string nome;
    public short idade;
    public float nota;
    public Situacao situacao;

    public void preencher()
    {
        Console.WriteLine("Nome do aluno: ");
        nome = Console.ReadLine();

        Console.WriteLine("Idade do aluno: ");
        idade = short.Parse(Console.ReadLine());

        Console.WriteLine("Nota do aluno: ");
        nota = float.Parse(Console.ReadLine());

        //Console.WriteLine("Situação do aluno: Aprovado = (1) Recuperação = (2) Reprovado = (3) ");
        //int numSituacao = int.Parse(Console.ReadLine());
        //switch (numSituacao)
        //{
        //    case 1:
        //        situacao = "Aprovado";
        //        break;
        //    case 2:
        //        situacao = "Recuperação";
        //        break;
        //    case 3:
        //        situacao = "Reprovado";
        //        break;
        //    default:
        //        break;
        //}

        //switch (nota)
        //{
        //    case >7f:
        //        situacao = "Aprovado";
        //        break;
        //    case <3.5f:
        //        situacao = "Reprovado";
        //        break;
        //    default:
        //        situacao = "Recuperação";
        //        break;
        //}
    }
}

class Program
{
    static void Main()
    {
        int quantidadeDeAlunos = 3;
        List<Aluno> alunos = new List<Aluno>();

        for (int i = 0; i < quantidadeDeAlunos; i++)
        {
            Aluno aluno = new Aluno();
            aluno.preencher();
            alunos.Add(aluno);
        }

        // listagem dos dados de todos os alunos
        for (int i = 0; i < quantidadeDeAlunos; i++)
        {
            Console.WriteLine("Nome: " + alunos[i].nome + 
                              ", Idade: " + alunos[i].idade + 
                              ", Nota: " + alunos[i].nota);

        }

        // maior e menor nota
        // uso o metodo de ordencao de listas passando como referencia de ordenacao a nota crescente
        alunos.Sort((a, b) => a.nota.CompareTo(b.nota));
        Console.WriteLine(alunos[alunos.Count - 1].nome + " teve a maior nota: " + alunos[alunos.Count - 1].nota);
        Console.WriteLine(alunos[0].nome + " teve a menor nota: " + alunos[0].nota);

        // media aritimetica das notas de todos os alunos
        float mediaAritimetica = 0;
        foreach (var item in alunos) {
            mediaAritimetica += item.nota;
        }
        mediaAritimetica /= alunos.Count;
        Console.WriteLine("A media aritimetica das notas de todos os alunos é: " + mediaAritimetica);

        // 
        for (int i = 0; i < alunos.Count - 1; i++)
        {
            if (alunos[i].nota < mediaAritimetica + 3 && alunos[i].nota > mediaAritimetica - 3)
            {
                alunos[i].nota = mediaAritimetica + 3;
            }
        }
    }
}

