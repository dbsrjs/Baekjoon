n = int(input())
scores = list(map(int, input().split()))

print(min(scores) * max(scores))
