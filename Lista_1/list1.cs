using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nLista de Exercícios");
            Console.WriteLine("1 - Atividade 1");
            Console.WriteLine("2 - Atividade 2");
            Console.WriteLine("3 - Atividade 3");
            Console.WriteLine("4 - Atividade 4");
            Console.WriteLine("5 - Atividade 5");
            Console.WriteLine("6 - Atividade 6");
            Console.WriteLine("7 - Atividade 7");
            Console.WriteLine("8 - Atividade 8");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Atv1(); break;
                case 2: Atv2(); break;
                case 3: Atv3(); break;
                case 4: Atv4(); break;
                case 5: Atv5(); break;
                case 6: Atv6(); break;
                case 7: Atv7(); break;
                case 8: Atv8(); break;
                case 0:
                    Console.WriteLine("Encerrando...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    //  ATIVIDADE 1 
    static void Atv1()
    {
        Console.WriteLine("Executando atividade 1");

        int RecursiveMulti(int a, int b)
        {
            if (b == 0) return 0;
            return a + RecursiveMulti(a, b - 1);
        }

        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(RecursiveMulti(a, b));
    }

    //  ATIVIDADE 2 
    static void Atv2()
    {
        Console.WriteLine("Executando atividade 2");

        void ShowMultiples(int n, int q, int count)
        {
            if (count > q) return;
            Console.WriteLine(n * count);
            ShowMultiples(n, q, count + 1);
        }

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());

        ShowMultiples(n, q, 1);
    }

    //  ATIVIDADE 3 
    static void Atv3()
    {
        Console.WriteLine("Executando atividade 3");

        double Series(int n)
        {
            if (n == 1) return 1;
            return (1.0 / n) + Series(n - 1);
        }

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
            Console.WriteLine("n deve ser maior ou igual a 1.");
        else
            Console.WriteLine(Series(n));
    }

    //  ATIVIDADE 4 
    static void Atv4()
    {
        Console.WriteLine("Executando atividade 4");

        int SumVetor(int[] v, int n)
        {
            if (n == 0) return 0;
            return v[n - 1] + SumVetor(v, n - 1);
        }

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"v[{i}] = ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(SumVetor(vetor, n));
    }

    //  ATIVIDADE 5 
    static void Atv5()
    {
        Console.WriteLine("Executando atividade 5");

        string ConvertBase(int n, int b)
        {
            if (n == 0) return "0";

            string result = "";
            while (n > 0)
            {
                result = (n % b) + result;
                n /= b;
            }
            return result;
        }

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertBase(n, b));
    }

    //  ATIVIDADE 6 
    static void Atv6()
    {
        Console.WriteLine("Executando atividade 6");

        List<Funcionario> funcionarios = new List<Funcionario>();

        for (int i = 0; i <= 50; i++) // reduzi para testes
        {
            Console.WriteLine($"\nCadastro de Funcionário {i + 1}");

            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Departamento: ");
            string departamento = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Data data = new Data(dia, mes, ano);
            funcionarios.Add(new Funcionario(matricula, nome, departamento, salario, data));
        }

        Console.Write("\nDigite o departamento para listar: ");
        string depBusca = Console.ReadLine();

        var encontrados = funcionarios.Where(f => f.Departamento == depBusca).ToList();

        if (encontrados.Count == 0)
            Console.WriteLine("Nenhum funcionário encontrado.");
        else
            encontrados.ForEach(f => Console.WriteLine(f));
    }

    //  ATIVIDADE 7 
    static void Atv7()
    {
        Console.WriteLine("Executando atividade 7");

        Console.Write("Tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        Vetor v = new Vetor(n);

        while (true)
        {
            Console.WriteLine("\n1-Preencher 2-Recuperar 3-Existe 4-Soma 5-Pares 6-Ímpares 7-Listar 0-Sair");
            int op = int.Parse(Console.ReadLine());

            if (op == 0) break;

            switch (op)
            {
                case 1:
                    Console.Write("Posição: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Valor: ");
                    int val = int.Parse(Console.ReadLine());
                    v.Preencher(p, val);
                    break;

                case 2:
                    Console.Write("Posição: ");
                    Console.WriteLine(v.Recuperar(int.Parse(Console.ReadLine())));
                    break;

                case 3:
                    Console.Write("Valor: ");
                    Console.WriteLine(v.Existe(int.Parse(Console.ReadLine())) ? "Existe" : "Não existe");
                    break;

                case 4:
                    Console.WriteLine("Soma: " + v.Soma());
                    break;

                case 5:
                    Console.WriteLine("Soma Pares: " + v.SomaPar());
                    break;

                case 6:
                    Console.WriteLine("Soma Ímpares: " + v.SomaImpar());
                    break;

                case 7:
                    v.Lista();
                    break;
            }
        }
    }

    //  ATIVIDADE 8 
    static void Atv8()
    {
        Console.WriteLine("Executando atividade 8");

        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Console.Write("Gênero: ");
        string genero = Console.ReadLine();

        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        Livro livro = new Livro(titulo, autor, genero, ano);

        Console.WriteLine(livro);

        if (livro.Modernismo())
            Console.WriteLine("Pertence ao Modernismo.");
        else if (livro.Barroco())
            Console.WriteLine("Pertence ao Barroco.");
    }
}

//  CLASSES AUXILIARES 
class Data
{
    public int Dia, Mes, Ano;

    public Data(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;
    }

    public override string ToString()
    {
        return $"{Dia:D2}/{Mes:D2}/{Ano}";
    }
}

class Funcionario
{
    public string Matricula, Nome, Departamento;
    public double Salario;
    public Data DataAdmissao;

    public Funcionario(string m, string n, string d, double s, Data data)
    {
        Matricula = m;
        Nome = n;
        Departamento = d;
        Salario = s;
        DataAdmissao = data;
    }

    public override string ToString()
    {
        return $"Matrícula: {Matricula}, Nome: {Nome}, Departamento: {Departamento}, Salário: {Salario}, Data: {DataAdmissao}";
    }
}

class Vetor
{
    private int[] vetor;

    public Vetor(int n)
    {
        vetor = new int[n];
    }

    public void Preencher(int pos, int valor)
    {
        if (pos >= 0 && pos < vetor.Length)
            vetor[pos] = valor;
    }

    public int Recuperar(int pos)
    {
        if (pos >= 0 && pos < vetor.Length)
            return vetor[pos];
        return -1;
    }

    public bool Existe(int valor) => vetor.Contains(valor);
    public int Soma() => vetor.Sum();
    public int SomaPar() => vetor.Where(x => x % 2 == 0).Sum();
    public int SomaImpar() => vetor.Where(x => x % 2 != 0).Sum();

    public void Lista()
    {
        for (int i = 0; i < vetor.Length; i++)
            Console.WriteLine($"Posição {i}: {vetor[i]}");
    }
}

class Livro
{
    public string Titulo, Autor, Genero;
    public int Ano;

    public Livro(string t, string a, string g, int ano)
    {
        Titulo = t;
        Autor = a;
        Genero = g;
        Ano = ano;
    }

    public bool Modernismo() => Ano >= 1930 && Ano <= 1945;
    public bool Barroco() => Ano >= 1601 && Ano <= 1768;

    public override string ToString()
    {
        return $"Título: {Titulo}, Autor: {Autor}, Gênero: {Genero}, Ano: {Ano}";
    }
}