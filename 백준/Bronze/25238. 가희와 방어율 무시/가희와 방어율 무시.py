a, b = map(int, input().split())

tmp = a - a*(b/100)

if tmp >= 100:
    print(0)
else:
    print(1)