n = int(input())

a = 0
b = 0

for i in range(1, n + 1):
    a = a + i
print(a)
print(a ** 2)

for i in range(1, n + 1):
    b = b + (i ** 3)
print(b)