using System;

class ConversorTemperatura
{
    public static double CelsiusParaFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    public static double FahrenheitParaCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Celsius
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = ConversorTemperatura.CelsiusParaFahrenheit(celsius);
        Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);

        Console.WriteLine();

        //Fahrenheit
        Console.Write("Digite a temperatura em Fahrenheit: ");
        double fahr = Convert.ToDouble(Console.ReadLine());

        double cels = ConversorTemperatura.FahrenheitParaCelsius(fahr);
        Console.WriteLine("Temperatura em Celsius: " + cels);
    }
}


// ==============================


class Aluno
{
    public string nome;

    private static int totalAlunos = 0;
    public Aluno(string nomeAluno)
    {
        nome = nomeAluno;
        totalAlunos++;
    }


    public static void ExibirTotalAlunos()
    {
        Console.WriteLine("Total de alunos cadastrados: " + totalAlunos);
    }
}

class Program
{
    static void Main(string[] args)
    {

        Aluno aluno1 = new Aluno("Carlos");
        Aluno aluno2 = new Aluno("Mariana");
        Aluno aluno3 = new Aluno("João");

        Console.WriteLine("Aluno 1: " + aluno1.nome);
        Console.WriteLine("Aluno 2: " + aluno2.nome);
        Console.WriteLine("Aluno 3: " + aluno3.nome);

        Console.WriteLine();


        Aluno.ExibirTotalAlunos();
    }
}

//===================


class Curso
{

    private string nome;
    private int cargaHoraria;

    // Construtor 1
    public Curso(string nome)
    {
        this.nome = nome;
        this.cargaHoraria = 40;
    }

    // Construtor 2
    public Curso(string nome, int cargaHoraria)
    {
        this.nome = nome;
        this.cargaHoraria = cargaHoraria;
    }

    //exibir
     public void ExibirDados(){
        Console.WriteLine("Curso: " + nome);
        Console.WriteLine("Carga Horária: " + cargaHoraria + " horas");
        Console.WriteLine();
    }

    // Destrutor
    ~Curso()
    {
        Console.WriteLine("Curso " + nome + " removido da memória.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Curso curso1 = new Curso("Programação em C#");


        Curso curso2 = new Curso("Banco de Dados", 80);

        curso1.ExibirDados();
        curso2.ExibirDados();

        Console.WriteLine("Os cursos foram criados com sucesso.");

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Finalizando o programa...");
    }
}