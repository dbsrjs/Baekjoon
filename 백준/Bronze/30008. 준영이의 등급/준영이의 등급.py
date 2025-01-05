N, K = map(int, input().split())
G = list(map(int, input().split()))

for i in G:
    P = (i * 100) // N
    if 0 <= P <= 4:
        print(1, end=' ')
    elif P <= 11:
        print(2, end=' ')
    elif P <= 23:
        print(3, end=' ')
    elif P <= 40:
        print(4, end=' ')
    elif P <= 60:
        print(5, end=' ')
    elif P <= 77:
        print(6, end=' ')
    elif P <= 89:
        print(7, end=' ')
    elif P <= 96:
       print(8, end=' ')
    elif P <= 100:
        print(9, end=' ')