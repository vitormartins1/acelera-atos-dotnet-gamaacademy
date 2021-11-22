// Evoluir o programa console (3) desta lista para permitir
// a busca dos dados de um aluno pelo nome.
// Construir um menu para acionar as funcioalidades do programa.
// Que seriam: (Lembre -se de utilizar metodos para segmentar as responsabilidades do programa)
// a) Cadastrar um aluno
// b) LIstar todos alunos
// c) Calcular a media e atualizar situação dos alunos
// d) Pesquisar aluno pelo nome
// e) Sair do programa

public enum Situacao
{
    Aprovado, Recuperacao, Reprovado
}

public enum Menu
{
    CadastroAluno = 0, ListarAlunos = 1, CalcularMedia = 2, PesquisarAluno = 3, Sair = 4
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
    }
}

class Program
{
    static void Main()
    {
        int quantidadeDeAlunos = 3;
        float mediaAritimetica = 0;
        List<Aluno> alunos = new List<Aluno>();
        Menu menu = new Menu();

        bool validInfo = false;
        while (!validInfo)
        {
            Console.WriteLine("Escolha a opção: " +
                "\n (0) => Cadastro de aluno " +
                "\n (1) => Listar alunos " +
                "\n (2) => Calcular media e atualizar situação dos alunos " +
                "\n (3) => Pesquisar Aluno" +
                "\n (4) => Sair");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    menu = Menu.CadastroAluno;
                    break;
                case 1:
                    menu = Menu.ListarAlunos;
                    break;
                case 2:
                    menu = Menu.CalcularMedia;
                    break;
                case 3:
                    menu = Menu.PesquisarAluno;
                    break;
                case 4:
                    menu = Menu.Sair;
                    break;
                default:
                    Console.WriteLine("Insira um valor válido...");
                    break;
            }

            Console.WriteLine(menu.ToString() + ":");

            switch (menu)
            {
                case Menu.CadastroAluno:
                    CadastroDeAlunos(quantidadeDeAlunos, alunos);
                    break;
                case Menu.ListarAlunos:
                    ListarAlunos(quantidadeDeAlunos, alunos);
                    break;
                case Menu.CalcularMedia:
                    OrganizarNotasCrescente(alunos);
                    mediaAritimetica = MediaAritimeticaNotas(alunos);
                    DefinirSituacaoDeAlunos(mediaAritimetica, alunos);
                    break;
                case Menu.PesquisarAluno:
                    break;
                case Menu.Sair:
                    validInfo = true;
                    break;
                default:
                    break;
            }

        }

    }

    private static void DefinirSituacaoDeAlunos(float mediaAritimetica, List<Aluno> alunos)
    {
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

    private static void OrganizarNotasCrescente(List<Aluno> alunos)
    {
        // maior e menor nota
        // uso o metodo de ordencao de listas passando como referencia de ordenacao a nota crescente
        alunos.Sort((a, b) => a.nota.CompareTo(b.nota));
        Console.WriteLine(alunos[alunos.Count - 1].nome + " teve a maior nota: " + alunos[alunos.Count - 1].nota);
        Console.WriteLine(alunos[0].nome + " teve a menor nota: " + alunos[0].nota);
    }

    private static float MediaAritimeticaNotas(List<Aluno> alunos)
    {
        // media aritimetica das notas de todos os alunos
        float mediaAritimetica = 0;
        foreach (var item in alunos)
        {
            mediaAritimetica += item.nota;
        }
        mediaAritimetica /= alunos.Count;
        Console.WriteLine("A media aritimetica das notas de todos os alunos é: " + mediaAritimetica);
        return mediaAritimetica;
    }

    private static void CadastroDeAlunos(int quantidadeDeAlunos, List<Aluno> alunos)
    {
        // cadastro de alunos
        for (int i = 0; i < quantidadeDeAlunos; i++)
        {
            Aluno aluno = new Aluno();
            aluno.preencher();
            alunos.Add(aluno);
        }
    }

    private static void ListarAlunos(int quantidadeDeAlunos, List<Aluno> alunos)
    {
        // listagem dos dados de todos os alunos
        for (int i = 0; i < quantidadeDeAlunos; i++)
        {
            Console.WriteLine("Nome: " + alunos[i].nome +
                              ", Idade: " + alunos[i].idade +
                              ", Nota: " + alunos[i].nota);
        }
    }
}