numbers = set()

for _ in range(10):
    num = int(input()) % 42
    numbers.add(num)

print(len(numbers))
