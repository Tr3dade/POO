using System;

// interface IBonus
// {
//     double CalcularBonus();
// }

// class Funcionario
// {
//     public string Nome { get; set; }
//     public int Idade { get; set; }
//     public double Salario { get; set; }

//     public Funcionario(string nome, int idade, double salario)
//     {
//         Nome = nome;
//         Idade = idade;
//         Salario = salario;
//     }

//     public virtual void ExibirDados()
//     {
//         Console.WriteLine($"  Nome   : {Nome}");
//         Console.WriteLine($"  Idade  : {Idade} anos");
//         Console.WriteLine($"  Salário: R$ {Salario:F2}");
//     }
// }

// class Gerente : Funcionario, IBonus
// {
//     public string Departamento { get; set; }

//     public Gerente(string nome, int idade, double salario, string departamento)
//         : base(nome, idade, salario)
//     {
//         Departamento = departamento;
//     }

//     public override void ExibirDados()
//     {
//         Console.WriteLine("[ Gerente ]");
//         base.ExibirDados();
//         Console.WriteLine($"  Depto  : {Departamento}");
//     }

//     public double CalcularBonus()
//     {
//         return Salario * 0.20;
//     }
// }

// class Desenvolvedor : Funcionario, IBonus
// {
//     public string Linguagem { get; set; }

//     public Desenvolvedor(string nome, int idade, double salario, string linguagem)
//         : base(nome, idade, salario)
//     {
//         Linguagem = linguagem;
//     }

//     public override void ExibirDados()
//     {
//         Console.WriteLine("[ Desenvolvedor ]");
//         base.ExibirDados();
//         Console.WriteLine($"  Linguag: {Linguagem}");
//     }

//     public double CalcularBonus()
//     {
//         return Salario * 0.10;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("");
//         Console.WriteLine("       SISTEMA DE FUNCIONÁRIOS          ");
//         Console.WriteLine("\n");

//         Gerente gerente = new Gerente("Ana Paula", 38, 12000.00, "Tecnologia");
//         Desenvolvedor dev = new Desenvolvedor("Carlos Souza", 27, 8500.00, "C#");

//         gerente.ExibirDados();
//         Console.WriteLine($"  Bônus  : R$ {gerente.CalcularBonus():F2}");

//         Console.WriteLine();

//         dev.ExibirDados();
//         Console.WriteLine($"  Bônus  : R$ {dev.CalcularBonus():F2}");

//         Console.WriteLine("\n");
//     }
// }

 
interface IEmprestimo
{
    void Emprestar();
    void Devolver();
}

class ItemBiblioteca
{
    public string Titulo { get; set; }
    public int AnoPublicacao { get; set; }

    public ItemBiblioteca(string titulo, int anoPublicacao)
    {
        Titulo = titulo;
        AnoPublicacao = anoPublicacao;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"  Título : {Titulo}");
        Console.WriteLine($"  Ano    : {AnoPublicacao}");
    }
}

class Livro : ItemBiblioteca, IEmprestimo
{
    public string Autor { get; set; }

    public Livro(string titulo, int anoPublicacao, string autor)
        : base(titulo, anoPublicacao)
    {
        Autor = autor;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine("[ Livro ]");
        base.ExibirInformacoes();
        Console.WriteLine($"  Autor  : {Autor}");
    }

    public void Emprestar()
    {
        Console.WriteLine($"  >> Livro \"{Titulo}\" emprestado!");
    }

    public void Devolver()
    {
        Console.WriteLine($"  >> Livro \"{Titulo}\" devolvido!");
    }
}

class Revista : ItemBiblioteca, IEmprestimo
{
    public int NumeroEdicao { get; set; }

    public Revista(string titulo, int anoPublicacao, int numeroEdicao)
        : base(titulo, anoPublicacao)
    {
        NumeroEdicao = numeroEdicao;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine("[ Revista ]");
        base.ExibirInformacoes();
        Console.WriteLine($"  Edição : Nº {NumeroEdicao}");
    }

    public void Emprestar()
    {
        Console.WriteLine($"  >> Revista \"{Titulo}\" emprestada!");
    }

    public void Devolver()
    {
        Console.WriteLine($"  >> Revista \"{Titulo}\" devolvida!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("         SISTEMA DE BIBLIOTECA          ");

        Livro livro = new Livro("Clean Code", 2008, "Robert C. Martin");
        Revista revista = new Revista("National Geographic", 2024, 312);

        livro.ExibirInformacoes();
        Console.WriteLine();
        revista.ExibirInformacoes();

        Console.WriteLine("\nEmpréstimos");
        livro.Emprestar();
        revista.Emprestar();

        Console.WriteLine("\nDevoluções");
        livro.Devolver();
        revista.Devolver();
    }
}
