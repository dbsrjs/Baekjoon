while(True):
    a, b, c = input().split()
    b = int(b)
    c = int(c)

    if a == "#" and b == 0 and c == 0:
        break

    print(a + " ", end='')
    if b > 17 or c >= 80:
        print("Senior")
    else:
        print("Junior")
