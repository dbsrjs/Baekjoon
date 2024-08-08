import math

result = 0
for i in range(5):
    num = int(input())
    if num < 40:
        num = 40
    result += num
print(math.floor(result/5))