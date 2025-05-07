cnt = int(input())
nums = list(map(int, input().split()))

min_val = 1000000
max_val = -1000000

for num in nums:
    if num > max_val:
        max_val = num
    if num < min_val:
        min_val = num

print(min_val, max_val)
