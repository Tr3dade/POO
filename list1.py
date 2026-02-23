
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

# def atv5():

# def atv6():

# def atv7():

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
    elif opcao == 0:
        print("Encerrando...")
        break
    else:
        print("Opção inválida.")