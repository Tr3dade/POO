
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
            else:
                print("Posição inválida.")
        
        def recuperar(self, posicao):
            if 0 <= posicao < self.n:
                return self.vetor[posicao]
            else:
                print("Posição inválida.")
                return None
        
        def existe(self, valor):
            return valor in self.vetor
        
        def soma(self):
            return sum(self.vetor)
        
        def soma_par(self):
            return sum(x for x in self.vetor if x % 2 == 0)
        
        def soma_impar(self):
            return sum(x for x in self.vetor if x % 2 != 0)
        
        def lista(self):
            print("Vetor:", self.vetor)
            for i, valor in enumerate(self.vetor):
                print(f"Posição {i}: {valor}")

    def menu():
        n = int(input("Tamanho do vetor: "))
        vetor = Vetor(n)

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
                vetor.preencher(posicao, valor)
            elif opcao == 2:
                posicao = int(input("Posição: "))
                valor = vetor.recuperar(posicao)
                if valor is not None:
                    print(f"Valor na posição {posicao}: {valor}")
            elif opcao == 3:
                valor = int(input("Valor a verificar: "))
                existe = vetor.existe(valor)
                print(f"Valor {'existe' if existe else 'não existe'} no vetor.")
            elif opcao == 4:
                print(f"Soma total: {vetor.soma()}")
            elif opcao == 5:
                print(f"Soma dos pares: {vetor.soma_par()}")
            elif opcao == 6:
                print(f"Soma dos ímpares: {vetor.soma_impar()}")
            elif opcao == 7:
                vetor.lista()
            elif opcao == 0:
                print("Encerrando...")
                break
            else:
                print("Opção inválida.")
        

# def atv8():

# ===== MENU PRINCIPAL =====


while True:
    print("\nLista de Exercícios")
    print("1 - Atividade 1")
    print("2 - Atividade 2")
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
    
    
    elif opcao == 0:
        print("Encerrando...")
        break
    else:
        print("Opção inválida.")