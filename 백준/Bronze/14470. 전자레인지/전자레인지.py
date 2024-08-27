a = int(input())
b = int(input())
c = int(input())
d = int(input())
e = int(input())

cnt = 0

if a < 0:
    cnt += d

while a < 0:
    a += 1
    cnt += c

while a < b:
    a += 1
    cnt += e

print(cnt)