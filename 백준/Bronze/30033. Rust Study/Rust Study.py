N = int(input())
cnt = 0

A = list(map(int, input().split()))
B = list(map(int, input().split()))

for i in range(N):
    a = A[i]
    b = B[i]

    if b >= a:
        cnt += 1

print(cnt)
