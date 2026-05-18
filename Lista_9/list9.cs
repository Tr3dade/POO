using System;
using System.Collections.Generic;

// Exercício 1 
class Matematica
{
    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public int Multiplicar(int a, int b, int c)
    {
        return a * b * c;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }
}

// Exercício 2
class Veiculo
{
    public virtual void Mover()
    {
        Console.WriteLine("O veículo está se movendo.");
    }
}

class Carro : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O carro está dirigindo na estrada.");
    }
}

class Bicicleta : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("A bicicleta está sendo pedalada.");
    }
}

// Exercício 3 
class Funcionario
{
    public virtual void ExibirDados()
    {
        Console.WriteLine("Funcionário cadastrado no sistema.");
    }
}

class Gerente : Funcionario
{
    public override void ExibirDados()
    {
        base.ExibirDados(); 
        Console.WriteLine("O gerente também é responsável por liderar a equipe.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        //  Ex 1 
        Console.WriteLine("=== Exercício 1: Sobrecarga ===");
        Matematica mat = new Matematica();

        int r1 = mat.Multiplicar(4, 5);
        Console.WriteLine($"Multiplicar(4, 5)          = {r1}");     

        int r2 = mat.Multiplicar(2, 3, 6);
        Console.WriteLine($"Multiplicar(2, 3, 6)       = {r2}");      

        double r3 = mat.Multiplicar(2.5, 4.0);
        Console.WriteLine($"Multiplicar(2.5, 4.0)      = {r3}");       

        // Ex 2 
        Console.WriteLine("\n=== Exercício 2: Polimorfismo ===");
        Veiculo v  = new Veiculo();
        Veiculo c  = new Carro();       
        Veiculo b  = new Bicicleta(); 

        v.Mover();
        c.Mover();
        b.Mover();

        //Ex 3 
        Console.WriteLine("\n=== Exercício 3: Uso de base ===");
        Gerente g = new Gerente();
        g.ExibirDados();
    }
}