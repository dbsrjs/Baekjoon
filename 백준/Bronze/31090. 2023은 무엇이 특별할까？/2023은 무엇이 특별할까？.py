cnt = int(input())

for _ in range(cnt):
    str = input()

    first = int(str[2:])
    num = int(str) + 1

    print("Good" if num % first == 0 else "Bye")
