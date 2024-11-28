name = input()
name = (name[0:5])

len = int(input())
cnt = 0

for i in range(len):
    a = input()
    a = (a[0:5])
    if name == a:
        cnt += 1

print(cnt)