using System;
using System.Collections.Generic;

//Parte 1===============================================================
// class Aluno
// {
//     private string nome;

//     public string GetNome()
//     {
//         return nome;
//     }

//     public void SetNome(string nome)
//     {
//         this.nome = nome;
//     }

//     public Aluno(string nome)
//     {
//         this.nome = nome;
//     }

//     public void ExibirNome()
//     {
//         Console.WriteLine("Aluno: " + nome);
//     }
// }

// class EscolaDependencia
// {
//     public void ExibirAluno(Aluno aluno)
//     {
//         Console.WriteLine("Exibindo aluno (Dependência): " + aluno.GetNome());
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         EscolaDependencia escola = new EscolaDependencia();
//         Aluno aluno = new Aluno("Matheus");

//         escola.ExibirAluno(aluno);

//         Console.ReadLine();
//     }
// }


//Parte 2 ===============================================================

// class Aluno
// {
//     private string nome;

//     public string GetNome()
//     {
//         return nome;
//     }

//     public void SetNome(string nome)
//     {
//         this.nome = nome;
//     }

//     public Aluno(string nome)
//     {
//         this.nome = nome;
//     }

//     public void ExibirNome()
//     {
//         Console.WriteLine("Aluno: " + nome);
//     }
// }

// class EscolaAssociacao
// {
//     private Aluno aluno;

//     public EscolaAssociacao(Aluno aluno)
//     {
//         this.aluno = aluno;
//     }

//     public void ExibirAluno()
//     {
//         Console.WriteLine("Exibindo aluno (Associação): " + aluno.GetNome());
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Aluno aluno = new Aluno("Matheus");
//         EscolaAssociacao escola = new EscolaAssociacao(aluno);

//         escola.ExibirAluno();

//         Console.ReadLine();
//     }
// }


//Parte 3 ===============================================================

// class Aluno
// {
//     private string nome;

//     public string GetNome()
//     {
//         return nome;
//     }

//     public void SetNome(string nome)
//     {
//         this.nome = nome;
//     }

//     public Aluno(string nome)
//     {
//         this.nome = nome;
//     }

//     public void ExibirNome()
//     {
//         Console.WriteLine("Aluno: " + nome);
//     }
// }

// class EscolaAgregacao
// {
//     private List<Aluno> alunos = new List<Aluno>();

//     public void AdicionarAluno(Aluno aluno)
//     {
//         alunos.Add(aluno);
//     }

//     public void ExibirAlunos()
//     {
//         Console.WriteLine("Lista de alunos (Agregação):");

//         foreach (Aluno aluno in alunos)
//         {
//             Console.WriteLine("- " + aluno.GetNome());
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         EscolaAgregacao escola = new EscolaAgregacao();

//         Aluno a1 = new Aluno("Matheus");
//         Aluno a2 = new Aluno("João");
//         Aluno a3 = new Aluno("Maria");

//         escola.AdicionarAluno(a1);
//         escola.AdicionarAluno(a2);
//         escola.AdicionarAluno(a3);

//         escola.ExibirAlunos();

//         Console.ReadLine();
//     }
// }

//Parte 4 ===============================================================

//crie um objeto aluno que tenha os atributos nome, matricula e curso. A escola deve ter uma lista de alunos e um método para adicionar alunos à lista. O aluno deve ter um método para exibir suas informações.

class Aluno
{
    private string nome;
    private string matricula;
    private string curso;

    public string GetNome()
    {
        return nome;
    }

    public string GetMatricula()
    {
        return matricula;
    }

    public string GetCurso()
    {
        return curso;
    }

    public Aluno(string nome, string matricula, string curso)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.curso = curso;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Aluno: " + nome);
        Console.WriteLine("Matrícula: " + matricula);
        Console.WriteLine("Curso: " + curso);
    }
}

class EscolaComposicao
{
    private List<Aluno> alunos = new List<Aluno>();

    public void AdicionarAluno(string nome, string matricula, string curso)
    {
        Aluno novoAluno = new Aluno(nome, matricula, curso);
        alunos.Add(novoAluno);
    }

    public void ExibirAlunos()
    {
        Console.WriteLine("Lista de alunos (Composição):");

        foreach (Aluno aluno in alunos)
        {
            aluno.ExibirInformacoes();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EscolaComposicao escola = new EscolaComposicao();

        escola.AdicionarAluno("Matheus", "12345", "Engenharia");
        escola.AdicionarAluno("João", "67890", "Medicina");
        escola.AdicionarAluno("Maria", "54321", "Direito");

        escola.ExibirAlunos();

        Console.ReadLine();
    }
}