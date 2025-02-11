import sys

N, X = map(int, input().split())

max_start = -1

for _ in range(N):
    S, T = map(int, input().split())

    if S + T <= X and max_start < S:
        max_start = S

print(max_start)