s, k, h = map(int, input().split())

sum = s+k+h

if sum >= 100:
    print("OK")

else:
    min1 = min(s, k)
    min2 = min(min1, h)

    if min2 == s:
        print("Soongsil")
    elif min2 == k:
        print("Korea")
    elif min2 == h:
        print("Hanyang")