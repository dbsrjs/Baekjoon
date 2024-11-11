a = [int(input()) for _ in range(5)]

result = None
for i in range(5):
    count = 0
    for j in range(5):
        if a[i] == a[j]:
            count += 1
    if count % 2 == 1:
        result = a[i]
        break

print(result)
