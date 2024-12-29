import sys
input = sys.stdin.readline

# 입력
N = int(input())

# 출력
res = 1
for i in range(11, N+1):
    res *= i
print(6*res)