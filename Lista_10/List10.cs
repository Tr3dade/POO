using System;
using System.Collections.Generic;

// Interface de Manutenção
interface IManutencao
{
    void RealizarManutencao();
}
// Classe base
class Transporte
{
    public string Modelo { get; set; }
    public int Capacidade { get; set; }
    public Transporte(string modelo, int capacidade)
    {
        Modelo = modelo;
        Capacidade = capacidade;
    }
    public virtual void Mover()
    {
        Console.WriteLine($"Transporte {Modelo} em movimento.");
    }
}
// Classe derivada Carro (herança + interface)
class Carro : Transporte, IManutencao
{
public string Combustivel { get; set; }
    public Carro(string modelo, int capacidade, string combustivel)
    : base(modelo, capacidade)
    {
        Combustivel = combustivel;
    }
    public override void Mover()
    {
        Console.WriteLine($"Carro {Modelo} acelerando com { Combustivel}.");
    }
    public void RealizarManutencao()
    {
        Console.WriteLine($"Realizando manutenção no carro {Modelo}.");
    }
}
// Classe derivada Bicicleta (apenas herança)
class Bicicleta : Transporte
{
    public string Tipo { get; set; }
    public Bicicleta(string modelo, int capacidade, string tipo)
    : base(modelo, capacidade)
    {
        Tipo = tipo;
    }
    public override void Mover()
    {
        Console.WriteLine($"Bicicleta {Modelo} ({Tipo}) pedalando.");
    }
}
// Classe Garagem - relacionamento de Agregação com Transporte
class Garagem
{
    private List<Transporte> transportes = new List<Transporte>();
    public void Adicionar(Transporte t)
    {
        transportes.Add(t);
        Console.WriteLine($"{t.Modelo} adicionado à garagem.");
    }
    public void ListarTransportes()
    {
        Console.WriteLine("\n=== Transportes na Garagem ===");
        foreach (var t in transportes)
        {
            t.Mover(); // Polimorfismo dinâmico
            if (t is IManutencao manutencao)
                manutencao.RealizarManutencao();
        }
    }
}
class Programa
{
    static void Main()
    {
        Carro carro = new Carro("Fiat Uno", 5, "Gasolina");
        Bicicleta bike = new Bicicleta("Caloi", 1, "Urbana");
        Garagem garagem = new Garagem();
        garagem.Adicionar(carro);
        garagem.Adicionar(bike);
        garagem.ListarTransportes();
    }
}