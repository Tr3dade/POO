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