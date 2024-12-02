x = 0
y = 0
cntX = 0
cntY = 0

len_ = int(input())

for _ in range(len_):
    if cntX == 2 or cntY == 2:
        break

    str_ = input()
    if str_ == "D":
        cntY -= 1
        x += 1
        cntX += 1
    elif str_ == "P":
        cntX -= 1
        y += 1
        cntY += 1

print(f"{x}:{y}")
