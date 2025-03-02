len_ = int(input())
pos = 1

for _ in range(len_):
    x, y = map(int, input().split())

    if x == pos:
        pos = y
    elif y == pos:
        pos = x

print(pos)
