// Roteiro 4
// 
// 1) Evoluir o ultimo programa do roteiro 3 para incluir uma nova função
// de menu chamada salvar dados em arquivo. A informação da coleção de
// alunos deve ser armazenada em um arquivo TXT. Onde cada linha do arquivo
// irá representar um registro, e os campos devem ser separados por (;).
// Uma função para ler os dados do arquivo e armazenar na lista de alunos
// em memória também deve ser adicionada ao menu.

public enum Situacao
{
    Aprovado, Recuperacao, Reprovado
}

public enum Menu
{
    CadastroAluno = 0, 
    ListarAlunos = 1, 
    CalcularMedia = 2, 
    PesquisarAluno = 3,
    SalvarDadosEmArquivo = 4,
    CarregarDadosDeArquivo = 5,
    Sair = 6
}

struct Aluno
{
    public Aluno()
    {
        dataDeCadastro = DateTime.Now;
    }
    public Aluno(bool autopreence)
    {
        dataDeCadastro = DateTime.Now;
        if (autopreence)
            preencher();
    }

    public string nome = "";
    public short idade = 0;
    public float nota = 0f;
    public Situacao situacao = Situacao.Recuperacao;
    public DateTime dataDeCadastro;

    void preencher()
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
        const string CAMINHO = "C://NOVO/alunos.txt";
        int quantidadeDeAlunos = 3;
        float mediaAritimetica = 0;
        List<Aluno> alunos = new List<Aluno>();
        Menu menu = new Menu();

        bool sair = false;
        while (!sair)
        {
            // rotina do menu
            bool validInfo = true;
            Console.WriteLine("Escolha a opção: " +
                "\n (0) => Cadastro de aluno " +
                "\n (1) => Listar alunos " +
                "\n (2) => Calcular media e atualizar situação dos alunos " +
                "\n (3) => Pesquisar Aluno" +
                "\n (4) => Salvar dados em arquivo" +
                "\n (5) => Carregar dados de arquivo" +
                "\n (6) => Sair");

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
                    menu = Menu.SalvarDadosEmArquivo;
                    break;
                case 5:
                    menu = Menu.CarregarDadosDeArquivo;
                    break;
                case 6:
                    menu = Menu.Sair;
                    break;
                default:
                    Console.WriteLine("Insira um valor válido...");
                    validInfo = false;
                    break;
            }

            // rotina das opcoes de menu
            if (validInfo)
            {
                Console.WriteLine(menu.ToString() + ":");

                switch (menu)
                {
                    case Menu.CadastroAluno:
                        // CadastroDeAlunos(quantidadeDeAlunos, alunos);
                        CadastrarAluno(alunos);
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
                        PesquisarAluno(alunos);
                        break;
                    case Menu.SalvarDadosEmArquivo:
                        SalvarArquivoTexto(CAMINHO, alunos);
                        break;
                    case Menu.CarregarDadosDeArquivo:
                        //alunos = new List<Aluno>(LerArquivoTexto("C://NOVO/alunos.txt"));
                        alunos = LerArquivoTexto(CAMINHO);
                        break;
                    case Menu.Sair:
                        sair = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    static void SalvarArquivoTexto(string caminho, List<Aluno> listaAlunos)
    {
        StreamWriter sw = new StreamWriter(caminho);

        foreach (var alu in listaAlunos)
        {
            sw.WriteLine($"{alu.nome};{alu.idade};{alu.nota}");
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
            alu.nome = campos[0];
            alu.idade = short.Parse(campos[1]);
            alu.nota = int.Parse(campos[2]);
            listaAlunos.Add(alu);
            line = sr.ReadLine();
        }

        sr.Close();
        return listaAlunos;
    }

    private static void PesquisarAluno(List<Aluno> alunos)
    {
        Console.WriteLine("Insira o nome do aluno: ");
        string nome = Console.ReadLine();

        foreach (var item in alunos)
        {
            if (item.nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nome: " + item.nome +
                                  "| Idade: " + item.idade +
                                  "| Nota: " + item.nota +
                                  "| Cadastro: " + item.dataDeCadastro.ToString());
            }
            else
            {
                Console.WriteLine("Nenhum aluno com o nome informado foi encontrado.");
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
        if (alunos.Count > 0)
        {
            // maior e menor nota
            // uso o metodo de ordencao de listas passando como referencia de ordenacao a nota crescente
            alunos.Sort((a, b) => a.nota.CompareTo(b.nota));
            Console.WriteLine(alunos[alunos.Count - 1].nome + " teve a maior nota: " + alunos[alunos.Count - 1].nota);
            Console.WriteLine(alunos[0].nome + " teve a menor nota: " + alunos[0].nota);
        }
        else
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
        }
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
            Aluno aluno = new Aluno(true);
            //aluno.preencher();
            alunos.Add(aluno);
        }
    }

    private static void CadastrarAluno(List<Aluno> alunos)
    {
        Aluno aluno = new Aluno(true);
        alunos.Add(aluno);
    }

    private static void ListarAlunos(int quantidadeDeAlunos, List<Aluno> alunos)
    {
        if (alunos.Count > 0)
        {
            // listagem dos dados de todos os alunos
            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine("Nome: " + alunos[i].nome +
                                  "| Idade: " + alunos[i].idade +
                                  "| Nota: " + alunos[i].nota +
                                  "| Cadastro: " + alunos[i].dataDeCadastro.ToString());
            }
        }
        else
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
        }
    }
}