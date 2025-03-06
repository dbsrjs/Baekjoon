num = int(input())

for i in range(num, 0, -1):
    print(" " * (num - i) + "*" * (2 * i - 1))
