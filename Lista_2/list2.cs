using System;

class Carro
{
    public string marca;
    public string modelo;
    public string cor;
    public int anoFabricacao;

    public void exibirInformacoes()
    {
        Console.WriteLine("\nMarca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Cor: " + cor);
        Console.WriteLine("Ano de Fabricação: " + anoFabricacao);
        Console.WriteLine("-----------------------");
    }

    public void buzinar()
    {
        Console.WriteLine("Beep Beep!");
    }
}

class Filme
{
    public string titulo;
    public string diretor;
    public int anoLancamento;
    public bool emprestado;

    public void exibirInformacoes()
    {
        Console.WriteLine("\nTítulo: " + titulo);
        Console.WriteLine("Diretor: " + diretor);
        Console.WriteLine("Ano: " + anoLancamento);
        Console.WriteLine("Emprestado: " + (emprestado ? "Sim" : "Não"));
    }

    public void emprestar()
    {
        if (!emprestado)
        {
            emprestado = true;
            Console.WriteLine("Filme emprestado com sucesso.");
        }
        else
        {
            Console.WriteLine("O filme já está emprestado.");
        }
    }

    public void devolver()
    {
        if (emprestado)
        {
            emprestado = false;
            Console.WriteLine("Filme devolvido com sucesso.");
        }
        else
        {
            Console.WriteLine("O filme já está disponível.");
        }
    }
}

class Jogo
{
    public string titulo;
    public string plataforma;
    public int anoLancamento;
    public bool emprestado;

    public void exibirInformacoes()
    {
        Console.WriteLine("\nTítulo: " + titulo);
        Console.WriteLine("Plataforma: " + plataforma);
        Console.WriteLine("Ano: " + anoLancamento);
        Console.WriteLine("Emprestado: " + (emprestado ? "Sim" : "Não"));
    }

    public void emprestar()
    {
        if (!emprestado)
        {
            emprestado = true;
            Console.WriteLine("Jogo emprestado com sucesso.");
        }
        else
        {
            Console.WriteLine("O jogo já está emprestado.");
        }
    }

    public void devolver()
    {
        if (emprestado)
        {
            emprestado = false;
            Console.WriteLine("Jogo devolvido com sucesso.");
        }
        else
        {
            Console.WriteLine("O jogo já está disponível.");
        }
    }
}

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Atividade Carro");
            Console.WriteLine("2 - Atividade Filme");
            Console.WriteLine("3 - Atividade Jogo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    atividadeCarro();
                    break;

                case 2:
                    atividadeFilme();
                    break;

                case 3:
                    atividadeJogo();
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);
    }

    static void atividadeCarro()
    {
        Carro[] carros = new Carro[3];

        for (int i = 0; i < 3; i++)
        {
            carros[i] = new Carro();

            Console.WriteLine("\nCadastro do Carro " + (i + 1));

            Console.Write("Marca: ");
            carros[i].marca = Console.ReadLine();

            Console.Write("Modelo: ");
            carros[i].modelo = Console.ReadLine();

            Console.Write("Cor: ");
            carros[i].cor = Console.ReadLine();

            Console.Write("Ano: ");
            carros[i].anoFabricacao = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Carros cadastrados ---");

        for (int i = 0; i < 3; i++)
        {
            carros[i].exibirInformacoes();
            carros[i].buzinar();
        }
    }

    static void atividadeFilme()
    {
        Console.Write("Quantos filmes deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        Filme[] filmes = new Filme[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            filmes[i] = new Filme();

            Console.WriteLine("\nCadastro do Filme " + (i + 1));

            Console.Write("Título: ");
            filmes[i].titulo = Console.ReadLine();

            Console.Write("Diretor: ");
            filmes[i].diretor = Console.ReadLine();

            Console.Write("Ano: ");
            filmes[i].anoLancamento = int.Parse(Console.ReadLine());

            filmes[i].emprestado = false;
        }

        Console.WriteLine("\n--- Lista de Filmes ---");

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("\nFilme " + (i + 1));
            filmes[i].exibirInformacoes();
        }

        Console.Write("\nEscolha um filme para emprestar: ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        filmes[indice].emprestar();

        Console.Write("\nAgora devolvendo o mesmo filme...\n");

        filmes[indice].devolver();
    }

    static void atividadeJogo()
    {
        Console.Write("Quantos jogos deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        Jogo[] jogos = new Jogo[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            jogos[i] = new Jogo();

            Console.WriteLine("\nCadastro do Jogo " + (i + 1));

            Console.Write("Título: ");
            jogos[i].titulo = Console.ReadLine();

            Console.Write("Plataforma: ");
            jogos[i].plataforma = Console.ReadLine();

            Console.Write("Ano: ");
            jogos[i].anoLancamento = int.Parse(Console.ReadLine());

            jogos[i].emprestado = false;
        }

        Console.WriteLine("\n--- Lista de Jogos ---");

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("\nJogo " + (i + 1));
            jogos[i].exibirInformacoes();
        }

        Console.Write("\nEscolha um jogo para emprestar: ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        jogos[indice].emprestar();

        Console.Write("\nAgora devolvendo o mesmo jogo...\n");

        jogos[indice].devolver();
    }
}