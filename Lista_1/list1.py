
def atv1():
    print("Executando atividade 1")

    def recursive_multi(a, b):
        if b == 0:
            return 0
        return a + recursive_multi(a, b - 1)

    a = (int(input("A = ")))
    b = (int(input("B = ")))
    print(recursive_multi(a,b))

def atv2():
    print("Executando atividade 2")

    def show_multiples(n, q, count):
        if count > q:
            return
        print(n * (count))
        show_multiples(n, q, count + 1)

    n = (int(input("n = ")))
    q = (int(input("q = ")))
    show_multiples(n, q, 1)

def atv3():
    print("Executando atividade 3")

    def series(n):
        if n == 1:
            return 1
        return (1 / n) + series(n - 1)

    n = (int(input("n = ")))

    if n < 1:
        print("n deve ser maior ou igual a 1.")
    else:
        print(series(n))

def atv4():  
    print("Executando atividade 4")

    def sum_vetor(v, n):
        if n == 0:
            return 0
        return v[n - 1] + sum_vetor(v, n - 1)
    n = (int(input("n = ")))
    vetor = []
    for i in range(n):
        valor = (int(input(f"v[{i}] = ")))
        vetor.append(valor)
    print(sum_vetor(vetor, n)) 

def atv5():
    print("Executando atividade 5")

    def binary_base(n, b):
        if n == 0:
            return "0"
        digits = []
        while n:
            digits.append(str(n % b))
            n //= b
        return ''.join(digits[::-1])
    n = (int(input("n = ")))
    b = (int(input("b = ")))
    print(binary_base(n, b))

def atv6():
    print("Execultando atividade 6")

    class Data:
        def __init__(self, dia, mes, ano):
            self.dia = dia
            self.mes = mes
            self.ano = ano

        def __str__(self):
            return f"{self.dia:02d}/{self.mes:02d}/{self.ano}"

    class Funcionario:
        def __init__(self, matricula, nome, departamento, salario, data_admissao):
            self.matricula = matricula
            self.nome = nome
            self.departamento = departamento
            self.salario = salario
            self.data_admissao = data_admissao

        def __str__(self):
            return f"Matrícula: {self.matricula}, Nome: {self.nome}, Departamento: {self.departamento}, Salário: {self.salario}, Data de Admissão: {self.data_admissao}"
    
    def register_employee():

        funcionarios = []

        for i in range(50):
            print(f"\nCadastro de Funcionário {i+1}")

            matricula = input("Matrícula: ")
            nome = input("Nome: ")
            departamento = input("Departamento: ")
            salario = float(input("Salário: "))
            dia = int(input("Dia de Admissão: "))
            mes = int(input("Mês de Admissão: "))
            ano = int(input("Ano de Admissão: "))

            data_admissao = Data(dia, mes, ano)
            funcionario = Funcionario(matricula, nome, departamento, salario, data_admissao)
            
            funcionarios.append(funcionario)
        return funcionarios
    
    def show(funcionarios):
        print("\nDigite o departamento para listar os funcionários:")
        
        departamento = input("Departamento: ")
        print(f"\nFuncionários do Departamento '{departamento}':")

        valid = False
        for f in funcionarios:
            if f.departamento == departamento:
                print(f)
                valide = True
        if not valid:
            print("Nenhum funcionário encontrado nesse departamento.")

    funcionarios = register_employee()
    show(funcionarios)

def atv7():
    print("Executando atividade 7")

    class Vetor:
        def __init__(self, n):
            self.n = n
            self.vetor = [0] * n

        # Preenche um valor em uma posição
        def preencher(self, posicao, valor):
            if 0 <= posicao < self.n:
                self.vetor[posicao] = valor
                print("Valor preenchido com sucesso.")
            else:
                print("Posição inválida.")

        # Recupera o valor de uma posição
        def recuperar(self, posicao):
            if 0 <= posicao < self.n:
                return self.vetor[posicao]
            return "Posição inválida."
            
        # Verifica se um valor existe no vetor
        def existe(self, valor):
            return valor in self.vetor
        
        # Soma total dos valores do vetor
        def soma(self):
            return sum(self.vetor)
        def soma_par(self):
            return sum(x for x in self.vetor if x % 2 == 0)
        def soma_impar(self):
            return sum(x for x in self.vetor if x % 2 != 0)
        
        # Lista os valores do vetor
        def lista(self):
            print("Vetor:", self.vetor)
            for i, valor in enumerate(self.vetor):
                print(f"Posição {i}: {valor}")

    n = int(input("Tamanho do vetor: "))
    v = Vetor(n)

    while True:
        print("\nMenu:")
        print("1 - Preencher posição")
        print("2 - Recuperar valor")
        print("3 - Verificar existência de valor")
        print("4 - Soma total")
        print("5 - Soma dos pares")
        print("6 - Soma dos ímpares")
        print("7 - Listar vetor")
        print("0 - Sair")

        opcao = int(input("Escolha: "))

        if opcao == 1:
            posicao = int(input("Posição: "))
            valor = int(input("Valor: "))
            v.preencher(posicao, valor)
        elif opcao == 2:
            posicao = int(input("Posição: "))
            valor = v.recuperar(posicao)
            if valor is not None:
                print(f"Valor na posição {posicao}: {valor}")
        elif opcao == 3:
            valor = int(input("Valor a verificar: "))
            existe = v.existe(valor)
            print(f"Valor {'existe' if existe else 'não existe'} no vetor.")
        elif opcao == 4:
            print(f"Soma total: {v.soma()}")
        elif opcao == 5:
                print(f"Soma dos pares: {v.soma_par()}")
        elif opcao == 6:
            print(f"Soma dos ímpares: {v.soma_impar()}")
        elif opcao == 7:
            v.lista()
        elif opcao == 0:
            print("Encerrando...")
            break
        else:
            print("Opção inválida.")
        

def atv8():
    print("Executando atividade 8")
    
    class Livro:
        def __init__(self, titulo, autor,genero,ano):
            self.titulo = titulo
            self.autor = autor
            self.genero = genero
            self.ano = ano
        
        def search_title(self):
            return self.titulo
        def search_author(self):
            return self.autor
        def search_genre(self):
            return self.genero
        def search_year(self):
            return self.ano
        
        def modernism(self):
            return 1930 <= self.ano <= 1945
        def borroco(self):
            return 1601 <= self.ano <= 1768
        
        def __str__(self):
            return(f"Título: {self.titulo}, Autor: {self.autor}, Gênero: {self.genero}, Ano: {self.ano}")

    def register_books():
        titulo = input("Título: ")
        autor = input("Autor: ")
        genero = input("Gênero: ")
        ano = int(input("Ano: "))
        return Livro(titulo, autor, genero, ano)
    
    livro = register_books()
    print("\nLivro cadastrado:")
    print(livro)
    
    if livro.modernism():
        print("O livro pertence ao Modernismo.")
    elif livro.borroco():
        print("O livro pertence ao Barroco.")
    
# ===== MENU PRINCIPAL =====

while True:
    print("\nLista de Exercícios")
    print("1 - Atividade 1")
    print("2 - Atividade 2")
    print("3 - Atividade 3")
    print("4 - Atividade 4")
    print("5 - Atividade 5")
    print("6 - Atividade 6")
    print("7 - Atividade 7")
    print("8 - Atividade 8")
    print("0 - Sair")

    opcao = int(input("Escolha: "))

    if opcao == 1:
        atv1()
    elif opcao == 2:
        atv2()
    elif opcao == 3:
        atv3()
    elif opcao == 4:
        atv4()
    elif opcao == 5:
        atv5()
    elif opcao == 6:
        atv6()
    elif opcao == 7:
        atv7()
    elif opcao == 8:
        atv8()    
    elif opcao == 0:
        print("Encerrando...")
        break
    else:
        print("Opção inválida.")