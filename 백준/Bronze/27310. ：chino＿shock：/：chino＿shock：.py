str_input = input()

length = len(str_input)
num = 0

for char in str_input:
    if char == '_':
        num += 5

print(num + length + 2)
