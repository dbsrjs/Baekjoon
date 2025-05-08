n, m = map(int, input().split())
nums = list(range(1, n + 1))

for _ in range(m):
    m1, m2 = map(int, input().split())
    # 1-based index를 0-based로 보정
    nums[m1 - 1], nums[m2 - 1] = nums[m2 - 1], nums[m1 - 1]

print(*nums)
