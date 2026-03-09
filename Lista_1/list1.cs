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
            Console.WriteLine("1 - Multiplicação recursiva (soma repetida)");
            Console.WriteLine("2 - Mostrar múltiplos recursivamente");
            Console.WriteLine("3 - Soma da série 1/n");
            Console.WriteLine("4 - Soma recursiva de vetor");
            Console.WriteLine("5 - Imprimir número em binário recursivamente");
            Console.WriteLine("6 - Gerenciar cadastro de funcionários");
            Console.WriteLine("7 - Operações em vetor (preencher, somas, listar)");
            Console.WriteLine("8 - Dados e classificação de livro");
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
        Console.WriteLine("Executando: Imprimir número em binário recursivamente");

        void PrintBinary(int n)
        {
            if (n == 0)
                return;

            PrintBinary(n / 2);
            Console.Write(n % 2);
        }

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Número natural esperado.");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            PrintBinary(n);
            Console.WriteLine();
        }
    }

    //  ATIVIDADE 6 
    static void Atv6()
    {
        Console.WriteLine("Executando: Gerenciar cadastro de funcionários");
        const int TAM = 50;
        Funcionario[] funcionarios = new Funcionario[TAM];
        int quantidade = 0;

        Console.Write("Quantos funcionários deseja cadastrar? (máx 50): ");
        quantidade = int.Parse(Console.ReadLine());

        if (quantidade < 0 || quantidade > TAM)
        {
            Console.WriteLine("Quantidade inválida.");
            return;
        }

        // ================= CADASTRO =================
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nCadastro do Funcionário {i + 1}");

            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Departamento: ");
            string departamento = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Dia de admissão: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Mês de admissão: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ano de admissão: ");
            int ano = int.Parse(Console.ReadLine());

            Data data = new Data(dia, mes, ano);

            funcionarios[i] = new Funcionario(
                matricula,
                nome,
                departamento,
                salario,
                data
            );
        }

        // ================= LISTAGEM POR DEPARTAMENTO =================
        Console.Write("\nDigite o departamento para listar: ");
        string depBusca = Console.ReadLine();

        bool encontrou = false;

        for (int i = 0; i < quantidade; i++)
        {
            if (funcionarios[i].GetDepartamento() == depBusca)
            {
                Console.WriteLine("\nFuncionário encontrado:");
                Console.WriteLine("Matrícula: " + funcionarios[i].GetMatricula());
                Console.WriteLine("Nome: " + funcionarios[i].GetNome());
                Console.WriteLine("Departamento: " + funcionarios[i].GetDepartamento());
                Console.WriteLine("Salário: " + funcionarios[i].GetSalario());
                Console.WriteLine("Data de Admissão: " + funcionarios[i].GetDataAdmissao());
                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Nenhum funcionário encontrado nesse departamento.");
        }

        Console.WriteLine("\nPrograma encerrado.");
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
    private int dia;
    private int mes;
    private int ano;

    public Data(int d, int m, int a)
    {
        dia = d;
        mes = m;
        ano = a;
    }

    public int GetDia() { return dia; }
    public int GetMes() { return mes; }
    public int GetAno() { return ano; }

    public override string ToString()
    {
        return dia.ToString("D2") + "/" + mes.ToString("D2") + "/" + ano;
    }
}

class Funcionario
{
    private string matricula;
    private string nome;
    private string departamento;
    private double salario;
    private Data dataAdmissao;

    public Funcionario(string m, string n, string d, double s, Data data)
    {
        matricula = m;
        nome = n;
        departamento = d;
        salario = s;
        dataAdmissao = data;
    }

    public string GetMatricula() { return matricula; }
    public string GetNome() { return nome; }
    public string GetDepartamento() { return departamento; }
    public double GetSalario() { return salario; }
    public Data GetDataAdmissao() { return dataAdmissao; }
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