a, b = map(int, input().split())

cnt = a * b

str = input().split()

for value in str:
    num = int(value)
    if num > cnt:
        print(num - cnt, end=' ')
    elif num == cnt:
        print(0, end=' ')
    else:
        print(f"-{cnt - num}", end=' ')