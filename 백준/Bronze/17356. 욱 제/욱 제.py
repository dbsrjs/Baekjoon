import math

str_input = input().split()

a = int(str_input[0])
b = int(str_input[1])

square = math.pow(10, (b - a) / 400.0)

print(1 / (1 + square))
