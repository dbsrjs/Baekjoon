N = int(input())
check = False

for i in range(2, 10):
    if not check:  # check이 False 일 때,
        for j in range(1, 10):
            table = [i, j, i * j]
            if N in table:
                check = True
                break
    else:  # check이 True 일 때,
        break

if check:
    print(1)
else:
    print(0)