using System;

// 1 Questão ========================================
// class Produto
// {
//     protected string nome;
//     protected double preco;

//     public Produto(string nome, double preco)
//     {
//         this.nome  = nome;
//         this.preco = preco;
//     }

//     public void ExibirDados()
//     {
//         Console.WriteLine($"  Nome  : {nome}");
//         Console.WriteLine($"  Preço : R$ {preco:F2}");
//     }
// }

// class Livro : Produto
// {
//     protected string autor;

//     public Livro(string nome, double preco, string autor)
//         : base(nome, preco)
//     {
//         this.autor = autor;
//     }

//     public void ExibirDadosLivro()
//     {
//         ExibirDados();                       
//         Console.WriteLine($"  Autor : {autor}");
//     }
// }

// class Program
// {
//     static void Main()
//     {

//         Console.WriteLine(" DADOS DO LIVRO");

//         Livro livro = new Livro("O Senhor dos Anéis", 89.90, "J.R.R. Tolkien");
//         livro.ExibirDadosLivro();

//     }
// }

// 2 Questão ========================================
// class Pessoa
// {
//     protected string nome;
//     protected int    idade;
 
//     public Pessoa(string nome, int idade)
//     {
//         this.nome  = nome;
//         this.idade = idade;
//     }
 
//     public void ExibirDados()
//     {
//         Console.WriteLine($"  Nome  : {nome}");
//         Console.WriteLine($"  Idade : {idade} anos");
//     }
// }
 
// class Aluno : Pessoa
// {
//     protected string curso;
 
//     public Aluno(string nome, int idade, string curso)
//         : base(nome, idade)
//     {
//         this.curso = curso;
//     }
 
//     public void ExibirDadosAluno()
//     {
//         ExibirDados();   
//         Console.WriteLine($"  Curso : {curso}");
//     }
// }
 
// class Program
// {
//     static void Main()
//     {

//         Console.WriteLine("DADOS DO ALUNO");

 
//         Aluno aluno = new Aluno("Maria Silva", 21, "Análise e Desenvolvimento de Sistemas");
//         aluno.ExibirDadosAluno();
//     }
// }

// 3 Questão ========================================
class Dispositivo
{
    protected string marca;
    protected string modelo;
 
    public Dispositivo(string marca, string modelo)
    {
        this.marca   = marca;
        this.modelo  = modelo;
    }
 
    public void ExibirDados()
    {
        Console.WriteLine($"  Marca  : {marca}");
        Console.WriteLine($"  Modelo : {modelo}");
    }
}
 

// ==================== CLASSE DERIVADA ====================
class Celular : Dispositivo
{
    protected int armazenamento; // em GB
 
    public Celular(string marca, string modelo, int armazenamento)
        : base(marca, modelo)
    {
        this.armazenamento = armazenamento;
    }
 
    public void ExibirDadosCelular()
    {
        ExibirDados();                                              // método herdado de Dispositivo
        Console.WriteLine($"  Armaz. : {armazenamento} GB");
    }
}
 
// ==================== PROGRAMA PRINCIPAL ====================
class Program
{
    static void Main()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("      DADOS DO CELULAR        ");
        Console.WriteLine("==============================");
 
        Celular celular = new Celular("Samsung", "Galaxy S24", 256);
        celular.ExibirDadosCelular();
 
        Console.WriteLine("==============================");
    }
}