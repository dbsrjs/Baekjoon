n = int(input())
F = int(input())
result = (n // 100) * 100
num = 0

while result % F != 0:
    result += 1
    num += 1

print(f"{num:02d}")