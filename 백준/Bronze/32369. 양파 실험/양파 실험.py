N, A, B = map(int, input().split())
x, y = 1, 1

while N:
    # 1번 조건
    x += A
    y += B

    # 2번 조건
    if x < y:
        x, y = y, x

    # 3번 조건
    if x == y:
        y -= 1

    N -= 1


print(x, y)