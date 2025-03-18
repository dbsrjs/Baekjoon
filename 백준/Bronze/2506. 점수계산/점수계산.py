length = int(input())
arr = input().split()

rs = 0
cnt = 0

for num in arr:
    if num == "1":
        cnt += 1
    else:
        cnt = 0
    rs += cnt

print(rs)