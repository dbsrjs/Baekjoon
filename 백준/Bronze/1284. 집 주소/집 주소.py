while True:
    num = input()
    if num == "0":
        break

    length = 2 + (len(num) - 1)

    for c in num:
        if c == '0':
            length += 4
        elif c == '1':
            length += 2
        else:
            length += 3

    print(length)
