a, b, c = map(int, input().split())

result = 0

if (a * b) - c <= 0:
    print(0)
else:
    print((a*b) - c)