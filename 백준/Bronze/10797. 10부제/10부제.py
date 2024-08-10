num = int(input())

a, b, c, d, e = map(int, input().split())

cnt = 0

if a == num:
    cnt += 1
if b == num:
    cnt += 1
if c == num:
    cnt += 1
if d == num:
    cnt += 1
if e == num:
    cnt += 1

print(cnt)