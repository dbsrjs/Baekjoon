ran = int(input())
num = list(map(int, input().split()))

for n in num:
    if n == 300:
        print(1, end=" ")
    elif n >= 275:
        print(2, end=" ")
    elif n >= 250:
        print(3, end=" ")
    else:
        print(4, end=" ")
