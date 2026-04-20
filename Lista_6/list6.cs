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


class Aluno
{
    private string nome;

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public Aluno(string nome)
    {
        this.nome = nome;
    }

    public void ExibirNome()
    {
        Console.WriteLine("Aluno: " + nome);
    }
}

class EscolaAgregacao
{
    private List<Aluno> alunos = new List<Aluno>();

    public void AdicionarAluno(Aluno aluno)
    {
        alunos.Add(aluno);
    }

    public void ExibirAlunos()
    {
        Console.WriteLine("Lista de alunos (Agregação):");

        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine("- " + aluno.GetNome());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EscolaAgregacao escola = new EscolaAgregacao();

        Aluno a1 = new Aluno("Matheus");
        Aluno a2 = new Aluno("João");
        Aluno a3 = new Aluno("Maria");

        escola.AdicionarAluno(a1);
        escola.AdicionarAluno(a2);
        escola.AdicionarAluno(a3);

        escola.ExibirAlunos();

        Console.ReadLine();
    }
}