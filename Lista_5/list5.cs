using System;

class Veiculo
{
    private string placa;
    private string modelo;
    private int horaEntrada;
    private bool estacionado;

    private static int totalVeiculos = 0;

    public Veiculo(string placa, string modelo, int horaEntrada)
    {
        this.placa       = placa;
        this.modelo      = modelo;
        this.horaEntrada = horaEntrada;
        this.estacionado = true;
        totalVeiculos++;
    }

    //Get
    public string getPlaca() {
        return placa;
    }
    public string getModelo(){
        return modelo;
    } 
    public int getHoraEntrada(){
        return horaEntrada;
    }    
    public bool   getStatus(){
        return estacionado;
    }

    // Set
    public void setModelo(string modelo){
        this.modelo = modelo;
    }
    public void setHoraEntrada(int horaEntrada){
        this.horaEntrada = horaEntrada;
    }

    public static int getTotalVeiculos() {
        return totalVeiculos;
    }

    // registrarSaida  
    public void registrarSaida()
    {
        this.estacionado = false;
        Console.WriteLine($"  >> Saída registrada para o veículo {this.placa}.");
    }

    // mostrarDados 
    public void mostrarDados()
    {
        string status = this.estacionado ? "Estacionado" : "Saiu";
        Console.WriteLine($"  Placa       : {this.placa}");
        Console.WriteLine($"  Modelo      : {this.modelo}");
        Console.WriteLine($"  Hora Entrada: {this.horaEntrada:D2}:00");
        Console.WriteLine($"  Status      : {status}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("________________________________________");
        Console.WriteLine("    SISTEMA DE CONTROLE DE VEÍCULOS     ");
        Console.WriteLine("________________________________________\n");

        // 1. Criando 3 objetos da classe Veiculo
        Veiculo v1 = new Veiculo("ABC-1234", "Toyota Corolla", 8);
        Veiculo v2 = new Veiculo("DEF-5678", "Honda Civic",    10);
        Veiculo v3 = new Veiculo("GHI-9012", "Ford Ka",        13);

     
        Console.WriteLine("──────────────────────────────────────");
        Console.WriteLine(" DADOS INICIAIS DOS VEÍCULOS");
        Console.WriteLine("──────────────────────────────────────\n");

        Console.WriteLine("Veículo 1:");
        v1.mostrarDados();

        Console.WriteLine("Veículo 2:");
        v2.mostrarDados();

        Console.WriteLine("Veículo 3:");
        v3.mostrarDados();

        Console.WriteLine("──────────────────────────────────────");
        Console.WriteLine(" REGISTRANDO SAÍDA");
        Console.WriteLine("──────────────────────────────────────\n");
        v2.registrarSaida();

 
        Console.WriteLine("\n──────────────────────────────────────");
        Console.WriteLine(" DADOS ATUALIZADOS DOS VEÍCULOS");
        Console.WriteLine("──────────────────────────────────────\n");

        Console.WriteLine("Veículo 1:");
        v1.mostrarDados();

        Console.WriteLine("Veículo 2:");
        v2.mostrarDados();

        Console.WriteLine("Veículo 3:");
        v3.mostrarDados();

       
        Console.WriteLine("──────────────────────────────────────");
        Console.WriteLine($" Total de veículos cadastrados: {Veiculo.getTotalVeiculos()}");
        Console.WriteLine("──────────────────────────────────────");
    }
}