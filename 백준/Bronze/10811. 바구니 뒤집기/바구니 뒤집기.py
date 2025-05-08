n, m = map(int, input().split())
nums = list(range(1, n + 1))

for _ in range(m):
    m1, m2 = map(int, input().split())
    # 슬라이싱
    nums[m1 - 1:m2] = nums[m1 - 1:m2][::-1]

print(*nums)
