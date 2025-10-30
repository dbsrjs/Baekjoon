input_str = input().split()
scores = list(map(int, input_str))

scores.sort()
print(scores[1])