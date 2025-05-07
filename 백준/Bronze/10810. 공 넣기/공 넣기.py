n, m = map(int, input().split())
nums = [0] * n

for _ in range(m):
    i, j, k = map(int, input().split())
    for h in range(i, j + 1):
        nums[h - 1] = k

print(*nums)
