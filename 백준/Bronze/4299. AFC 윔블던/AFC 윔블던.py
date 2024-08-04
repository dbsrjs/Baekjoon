A, B = map(int, input().split())

if (A + B) % 2 != 0 or A < B:
    print(-1)
else:
    print(int(((A + B) / 2)), int((((A + B) / 2) - B)))