n = int(input())

for _ in range(n):
    a, tp = input().split()
    a = float(a)

    if tp == "kg":
        print(f"{a * 2.2046:.4f} lb")
    elif tp == "g":
        print(f"{a * 3.7854:.4f} l")
    elif tp == "l":
        print(f"{a * 0.2642:.4f} g")
    elif tp == "lb":
        print(f"{a * 0.4536:.4f} kg")
