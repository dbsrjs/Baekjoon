L = int(input())
A = int(input())
B = int(input())
C = int(input())
D = int(input())

cnt = 0

while A > 0 or B > 0:
    A -= C
    B -= D
    cnt += 1

print(L - cnt)