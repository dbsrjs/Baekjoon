num = int(input())
cnt = 0

for i in range(1, num + 1):
    print(i,'', end='')
    cnt += 1
    if cnt == 6 and i != num:
        print("Go! ", end='')
        cnt = 0
print("Go!")