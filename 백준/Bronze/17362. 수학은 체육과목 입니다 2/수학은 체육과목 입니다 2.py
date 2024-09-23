N = int(input())

# 0일 때 2, 6일 때 4, 4로 나눠서 3이 나오면 3, 이 조건들이 다 안 맞으면 N % 8 출력
if N % 8 == 0:
    print(2)
elif N % 4 == 3:
    print(3)
elif N % 8 == 6:
    print(4)
else:
    print(N % 8)