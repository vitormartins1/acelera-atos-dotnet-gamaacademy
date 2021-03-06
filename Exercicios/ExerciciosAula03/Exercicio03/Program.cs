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
    Aprovado, Recuperacao, Reprovado
}

struct Aluno
{
    public string nome { get; set; }
    public short idade { get; set; }
    public float nota { get; set; }
    public Situacao situacao { get; set; }

    public void preencher()
    {
        Console.WriteLine("Nome do aluno: ");
        nome = Console.ReadLine();

        Console.WriteLine("Idade do aluno: ");
        idade = short.Parse(Console.ReadLine());

        Console.WriteLine("Nota do aluno: ");
        nota = float.Parse(Console.ReadLine());
    }
}

internal class Program
{
    const int QUANTIDADE_ALUNOS = 3;

    // posso criar um list de alunos, mas estarei passando referencia
    // e nao valor.nesse caso onde usamos struct e considerado uma ma pratica
    static List<Aluno> alunos = new List<Aluno>();

    // Declaro estrutura que e do tipo valor e nao classe.
    // Quando atribuo um valor tipo eu crio uma copia
    // ao inves de atribuir uma referencia a ela
    static Aluno[] alu = new Aluno[QUANTIDADE_ALUNOS]; 
    static void Main()
    {

        for (int i = 0; i < QUANTIDADE_ALUNOS; i++)
        {
            Aluno aluno = new Aluno();
            aluno.preencher();
            alunos.Add(aluno);
        }

        // listagem dos dados de todos os alunos
        for (int i = 0; i < QUANTIDADE_ALUNOS; i++)
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

        // definição da situação do aluno
        for (int i = 0; i < alunos.Count; i++)
        {
            Aluno aluno = alunos[i];
            if (aluno.nota < mediaAritimetica + 3 && aluno.nota > mediaAritimetica - 3)
            {
                aluno.situacao = Situacao.Recuperacao;
            }
            else if (aluno.nota >= mediaAritimetica + 3)
            {
                aluno.situacao = Situacao.Aprovado;
            }
            else if (aluno.nota <= mediaAritimetica - 3)
            {
                aluno.situacao = Situacao.Reprovado;
            }
            alunos[i] = aluno;
        }

        // ultima listagem com definição da situação dos alunos
        foreach (var item in alunos)
        {
            Console.WriteLine(item.nome + " SITUAÇÃO: " + item.situacao);
        }
    }
}

