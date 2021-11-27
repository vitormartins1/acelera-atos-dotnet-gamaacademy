// 2) Construa um programa para fazer alguns testes com interfaces e classes abstratas,
// veja o que é de fato possivel com cada uma delas. Utilize a saida do console para
// demonstrar o que é possivel fazer com as classes e interfaces e comentários para
// demonstrar suas diferenças. Sugestões de testes, tente implementar metodos publicos,
// metodos abstratos e virtuais, tente sobrescrever metodos publicos, protegidos e privados,
// todos eles de forma padrão, abstrata e virtual. 

class Program
{
    static void Main(string[] args)
    {
        CenaDeLuta cenaLuta = new CenaDeLuta();
        CenaDeRomance cenaRomance = new CenaDeRomance();

        cenaLuta.ContratarAtores();
        cenaLuta.ChamarAtores();
        cenaLuta.ChamarDuble();
        cenaLuta.IniciarGravacao();
        cenaLuta.EncerrarGravacao();

        cenaRomance.ContratarAtores();
        cenaRomance.ChamarAtores();
        cenaRomance.IniciarGravacao();
        cenaRomance.EncerrarGravacao();
    }
}

public class CenaDeLuta : CenaBase
{
    // metodo abstrato e obrigatorio a ser implementado na class
    public override void ContratarAtores()
    {
        Console.WriteLine("Brad pit - CONTRATADO");
        CriarCrachaDeFuncionario();
        Console.WriteLine("Di caprio - CONTRATADO");
        CriarCrachaDeFuncionario();
    }

    // Nao e possivel substituir o membro herdado 'CenaBase.MetodoPublicoSimples()'
    // porque ele nao esta marcado como virtual, abstract ou override
    /*public override void MetodoPublicoSimples()
    {
        Console.WriteLine("nao consigo dar override em metodos publicos simples");
    }*/

    public override void ChamarDuble()
    {
        MetodoPublicoSimples();

        Console.WriteLine("Agora vamos chamar um duble para a cena:");
        base.ChamarDuble();
    }

    // Nao e possivel substituir o membro herdado 
    // porque ele nao esta marcado como virtual, abstract ou override
    /*override void CriarCrachaDeFuncionario()
    {

    }*/

    public virtual void MetodoPublicoSimples()
    {
        Console.WriteLine("Sou um metodo publico simples que " +
            "esta sendo sobreescrito virtualmente na classe filha");

        // nao sou obrigado a implementar a solucao base do metodo
        //base.MetodoPublicoSimples(); 
    }
}

public class CenaDeRomance : CenaBase
{
    // metodo abstrato e obrigatorio a ser implementado na class
    public override void ContratarAtores()
    {
        Console.WriteLine("Gal gadod - CONTRATADA");
        Console.WriteLine("Samuel el Jackson - CONTRATADO");
    }
}

public abstract class CenaBase : IGravacao
{
    // Protected: somente a classe que herdar tera acesso a esse metodo
    protected void CriarCrachaDeFuncionario()
    {
        Console.WriteLine("Criado cracha de funcionario para poder entrar no studio.");
    }
    /* 'class member' cannot declare a body because it is marked 
     * abstract An abstract method cannot contain its implementation.
    public abstract void DemitirAtores()
    {
        Console.WriteLine("Nao funciona!");
    }
    */
    // abstract nao pode declarar um corpo dentro do metodo
    public abstract void ContratarAtores();

    // metodo virtual é opcional de ser implementado na classe
    // filha e pode ser sobreescrito ecolhendo ou nao usar o conteudo 
    // do metodo da classe mae: 'base.ChamarDuble();'
    public virtual void ChamarDuble()
    {
        Console.WriteLine("Duble, vem ca fazer uma cena.");
    }

    public virtual void ChamarAtores()
    {
        Console.WriteLine("Atores, vem cá!!");
    }

    // Só pode ser chamado internamente na classe
    private void ExecutarLimpezaNaCena()
    {
        Console.WriteLine("Varrendo tudo.");
    }

    public void EncerrarGravacao()
    {
        Console.WriteLine("Corta!");
        ExecutarLimpezaNaCena();
    }

    public void IniciarGravacao()
    {
        Console.WriteLine("Gravando!!");
    }

    public void MetodoPublicoSimples()
    {
        Console.WriteLine("Sou um metodo publico simples que " +
            "foi criado na classe mãe abstrata.");
    }
}

interface IGravacao
{
    void IniciarGravacao();
    void EncerrarGravacao();
}