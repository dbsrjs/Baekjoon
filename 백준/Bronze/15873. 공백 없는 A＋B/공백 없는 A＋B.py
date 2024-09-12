n = input()
if len(n) == 4:           #1010
    print(20)
elif len(n) == 2:         #ab
    print(int(n[0]) + int(n[1]))
else:
    if int(n[-1]) == 0:   #a10
        print(int(n[0]) + 10)
    else:                 #10b
        print(int(n[-1]) + 10)