total = 0

for _ in range(10):
    a = int(input())
    total += a

if total % 4 == 0:
    print("N")
elif total % 4 == 1:
    print("E")
elif total % 4 == 2:
    print("S")
elif total % 4 == 3:
    print("W")
