n = int(input())
scores = list(map(float, input().split()))
max_score = max(scores)

new_scores = [(s / max_score) * 100 for s in scores]
average = sum(new_scores) / n

print(average)
