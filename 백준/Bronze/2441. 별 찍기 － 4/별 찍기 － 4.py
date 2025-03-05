num = int(input())

for i in range(num):
    for j in range(num - i, num):
        print(" ", end="")

    for k in range(i, num):
        print("*", end="")
    print()
