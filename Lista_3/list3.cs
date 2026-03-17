using System;

class ContaBancaria
{
    // Atributos privados
    private string titular;
    private double saldo;

    // Getters
    public string getTitular()
    {
        return titular;
    }

    public double getSaldo()
    {
        return saldo;
    }

    // Setters
    public void setTitular(string nome)
    {
        titular = nome;
    }

    public void setSaldo(double valor)
    {
        saldo = valor;
    }

    // Método Depositar
    public void Depositar(double valor)
    {
        saldo += valor;
        Console.WriteLine($"Depósito realizado: {valor}");
    }

    // Método Sacar
    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saque realizado: {valor}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();

        //Criação 
        Console.WriteLine("=== Criação da Conta ===");

        Console.Write("Nome do titular: ");
        string nome = Console.ReadLine();
        conta.setTitular(nome);

        Console.Write("Saldo inicial: R$ ");
        double saldoInicial = double.Parse(Console.ReadLine());
        conta.setSaldo(saldoInicial);

        Console.Write("Valor do depósito inicial: R$ ");
        double deposito = double.Parse(Console.ReadLine());
        conta.Depositar(deposito);

        //Menu de saques 
        Console.WriteLine("\n=== Operações de Saque ===");
        string opcao;
        do
        {
            Console.Write("\nDigitar valor para saque (ou 0 para sair): R$ ");
            double valorSaque = double.Parse(Console.ReadLine());

            if (valorSaque == 0)
                break;

            conta.Sacar(valorSaque);
            Console.WriteLine($"Saldo atual: R$ {conta.getSaldo():F2}");

            Console.Write("Realizar outro saque? (s/n): ");
            opcao = Console.ReadLine();
        } while (opcao?.ToLower() == "s");

        Console.WriteLine("\n=== Resumo da Conta ===");
        Console.WriteLine($"Titular: {conta.getTitular()}");
        Console.WriteLine($"Saldo final: R$ {conta.getSaldo():F2}");
    }
}