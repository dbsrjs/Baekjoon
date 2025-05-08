numbers = list(range(1, 31))

for _ in range(28):
    num = int(input())
    if num in numbers:
        numbers.remove(num)

numbers.sort()
print(numbers[0])
print(numbers[1])
