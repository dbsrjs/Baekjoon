def Janggi(x):
    result = 0
    point = [13, 7, 5, 3, 3, 2]
    for i in range(6):
        result += x[i] * point[i]

    return result


A = list(map(int, input().split()))  # 척이
B = list(map(int, input().split()))  # 은규

A_Point = Janggi(A)
B_Point = Janggi(B) + 1.5

if A_Point > B_Point:
    print("cocjr0208")
else:
    print("ekwoo")