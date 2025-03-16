array1 = [int(input()) for _ in range(9)]

max_value = max(array1)
index = array1.index(max_value) + 1

print(max_value)
print(index)
