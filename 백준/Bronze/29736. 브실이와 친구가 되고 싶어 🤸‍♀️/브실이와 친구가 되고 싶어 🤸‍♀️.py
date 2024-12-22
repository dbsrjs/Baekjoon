
A, B = map(int, input().split())


K, X = map(int, input().split())

people = 0
for i in range(K - X, K + X + 1):
    if i < A or i > B:
        continue
    people += 1

if people == 0:
    print("IMPOSSIBLE")
else:
    print(people)
