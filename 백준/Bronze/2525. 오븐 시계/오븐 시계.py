h, m = map(int, input().split())
num = int(input())

m += num
h += m // 60
m = m % 60
h = h % 24

print(h, m)
