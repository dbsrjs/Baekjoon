N = int(input())

# 위쪽 부분
for i in range(N):
    print("*" * (i + 1) + " " * (N * 2 - (i * 2) - 2) + "*" * (i + 1))

# 아래쪽 부분
for i in range(1, N):
    print("*" * (N - i) + " " * (i * 2) + "*" * (N - i))
